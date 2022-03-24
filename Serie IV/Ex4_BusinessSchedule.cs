using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class BusinessSchedule
    {
        private DateTime beginRange = DateTime.Parse("01/01/2020 00:00:00", new CultureInfo("fr-FR"));
        private DateTime endRange = DateTime.Parse("31/12/2030 00:00:00", new CultureInfo("fr-FR"));

        SortedDictionary<DateTime, DateTime> _edt;

        public BusinessSchedule()
        {
            _edt = new SortedDictionary<DateTime, DateTime>();
        }


        public bool IsEmpty()
        {
            return _edt.Count <= 0;
        }

        public void SetRangeOfDates(DateTime begin, DateTime end)
        {
            if (IsEmpty())
                throw new Exception("Des réunions sont encore planifiés.");

            if (begin > end)
                throw new Exception("La date de début doit être inférieure ou égale à la date de fin.");

            if (begin > DateTime.Today)
                throw new Exception("La date de début doit être inférieure ou égale à la date du jour.");

            beginRange = begin;
            endRange = end;
        }

        private KeyValuePair<DateTime, DateTime> ClosestElements(DateTime beginMeeting)
        {
            DateTime min = beginMeeting;
            DateTime max = beginMeeting;

            foreach (var reunion in _edt)
            {
                if (reunion.Key < min)
                {
                    min = reunion.Key;
                }
                if (reunion.Key > max && max != beginMeeting)
                {
                    max = reunion.Key;
                }
            }

            if (min == beginMeeting)
                min = beginRange;
            if (max == beginMeeting)
                max = endRange;

            return new KeyValuePair<DateTime, DateTime>(min, max);
        }

        public bool AddBusinessMeeting(DateTime date, TimeSpan duration)
        {
            var interval = ClosestElements(date);
            if (date >= beginRange && date <= date + duration)
            {
                if (date == beginRange && date == endRange)
                {
                    _edt.Add(date, date + duration);
                    return true;
                }
                else if (date == beginRange)
                {
                    if (date > _edt[interval.Key] && date + duration < interval.Value)
                    {
                        _edt.Add(date, date + duration);
                        return true;
                    }
                }
                else if (date == endRange)
                {
                    if (date > _edt[interval.Key] && date + duration < interval.Value)
                    {
                        _edt.Add(date, date + duration);
                        return true;
                    }
                }
                else
                {
                    if (date > _edt[interval.Key] && date + duration < interval.Value)
                    {
                        _edt.Add(date, date + duration);
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DeleteBusinessMeeting(DateTime date, TimeSpan duration)
        {
            //if ()
            return false;
        }

        public int ClearMeetingPeriod(DateTime begin, DateTime end)
        {
            //TODO
            return -1;
        }

        public void DisplayMeetings()
        {
            int i = 0;

            Console.WriteLine($"Emploi du temps : {beginRange} - {endRange}");
            Console.WriteLine("-----------------------------------------------------------");

            if (_edt.Count > 0)
            {
                foreach (var reunion in _edt)
                {
                    Console.WriteLine($"Réunion {i} : {reunion.Key} - {reunion.Value}");
                }
            }
            else
                Console.WriteLine("Pas de réunions programmées");

            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
