using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            List<SortData> lsd;
            lsd = PerformancesTest(sizes, count);

            Console.WriteLine("n;MeanInsertion;StdInsertion;MeanQuick;StdQuick");

            for (int i = 0; i < sizes.Count; i++)
            {
                Console.WriteLine($"{sizes[i]};{lsd[i].InsertionMean};{lsd[i].InsertionStd};{lsd[i].QuickMean};{lsd[i].QuickStd}");
            }
        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            List<SortData> lsd = new List<SortData>();

            for (int i = 0; i < sizes.Count; i++)
                lsd.Add(PerformanceTest(sizes[i], count));

            return lsd;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            List<int[]> l;
            List<long> insertionM = new List<long>();
            List<long> quickM = new List<long>();

            SortData sd = new SortData();

            for (int i = 0; i < count; i++)
            {
                l = ArraysGenerator(size);

                insertionM.Add(UseInsertionSort(l[0]));
                quickM.Add(UseQuickSort(l[1]));
            }

            sd.InsertionMean = (long)insertionM.Average();
            sd.QuickMean = (long)quickM.Average();

            long eI = 0;
            long eQ = 0;

            for (int i = 0; i < count; i++)
            {
                eI += (long)Math.Pow(sd.InsertionMean - insertionM[i], 2);
                eQ += (long)Math.Pow(sd.QuickMean - quickM[i], 2);
            }
            sd.InsertionStd = (long)Math.Sqrt(eI / count);
            sd.InsertionStd = (long)Math.Sqrt(eQ / count);

            return sd;
        }

        private static List<int[]> ArraysGenerator(int size)
        {
            Random rnd = new Random();
            List<int[]> l = new List<int[]>();

            int[] a = new int[size];
            int[] b = new int[size];

            int t;

            for (int i = 0; i < size; i++)
            {
                t = rnd.Next(-999, 1000);
                a[i] = t;
                b[i] = t;
            }

            l.Add(a);
            l.Add(b);

            return l;
        }

        public static long UseInsertionSort(int[] array)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            InsertionSort(array);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        public static long UseQuickSort(int[] array)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            QuickSort(array, 0, array.Length - 1);
            sw.Stop();

            return sw.ElapsedMilliseconds;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
