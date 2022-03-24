using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class PhoneBook
    {
        Dictionary<string, string> _annuaire;

        public PhoneBook()
        {
            _annuaire = new Dictionary<string, string>();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber[0] == '0' && phoneNumber[1] != '0' && int.TryParse(phoneNumber, out int t);
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            return _annuaire.ContainsKey(phoneNumber);
        }

        public void PhoneContact(string phoneNumber)
        {
            if (ContainsPhoneContact(phoneNumber))
                Console.WriteLine(_annuaire[phoneNumber]);
            else
                throw new Exception("¯\\_(ツ)_/¯");
        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {
            if (IsValidPhoneNumber(phoneNumber) && !ContainsPhoneContact(phoneNumber))
            {
                _annuaire.Add(phoneNumber, name);
                return true;
            }
            return false;
        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            if (ContainsPhoneContact(phoneNumber))
            {
                _annuaire.Remove(phoneNumber);
                return true;
            }
            return false;
        }

        public void DisplayPhoneBook()
        {
            Console.WriteLine("Annuaire téléphonique :");
            Console.WriteLine("-----------------------");
            if (_annuaire.Count > 0)
            {
                foreach (var contact in _annuaire)
                {
                    Console.WriteLine($"{contact.Key} : {contact.Value}");
                }
            }
            else
            {
                Console.WriteLine("Pas de numéros téléphoniques");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
