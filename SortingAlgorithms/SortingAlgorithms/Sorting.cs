using System;

namespace SortingAlgorithms
{
    class Sorting
    {

        public static T[] Bubble<T>(T[] data) where T : IComparable
        {
            bool sorted = false;
            do
            {
                sorted = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i].CompareTo(data[i + 1]) == 1)
                    {
                        T temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        sorted = true;
                    }
                }
            } while (sorted);
            return data;
        }

        public static T[] Selection<T>(T[] data) where T : IComparable
        {
            int n = 0; int min = n;
            while (n < data.Length - 1)
            {
                min = n;
                for (int i = n + 1; i < data.Length; i++)
                {
                    if (data[min].CompareTo(data[i]) == 1)
                    {
                        min = i;
                    }
                }
                if (min != n)
                {
                    T temp = data[n];
                    data[n] = data[min];
                    data[min] = temp;
                }
                n++;
            }
            return data;
        }

        public static T[] Insertion<T>(T[] data) where T : IComparable
        {
            int n;
            for (int i = 1; i < data.Length; i++)
            {
                n = i;
                while (n > 0 && data[n - 1].CompareTo(data[n]) == 1)
                {
                    T temp = data[n];
                    data[n] = data[n - 1];
                    data[n - 1] = temp;
                    n--;
                }
            }

            return data;
        }

    }
}
