using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractise
{
    class Array : IOutput, IMath, Isort, ICalc, IOutput2, ICalc2
    {
        int[] array;


        public Array() => array = new int[5];
        public Array(int n)
        {
            array= new int[n];
        }

        public void Random(int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max);
            }
        }

        public float Avg()
        {
            float avg = 0.0f;
            foreach (var item in array)
                avg += item;
            return avg /= array.Length;
        }

        public int Max()
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            return max;
        }

        public int Min()
        {
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
                if (array[i] < min) min = array[i];

            return min;
        }

        public bool Search(int valueToSearch)
        {
            foreach (var item in array)
                if(item == valueToSearch) return true;
            return false;
        }

        public void Show()
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Info - " + info);
            Console.WriteLine();

        }

        public void SortAsc()
        {
            int temp = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    continue;
                }
                else
                {
                    temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i = 0;
                }
            }
        }

        public void SortDesc()
        {
            int temp = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    continue;
                }
                else
                {
                    temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i = 0;
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true) SortAsc();
            else SortDesc();
        }

        public int Less(int valueToCompare)
        {
            int less = 0;
            foreach (var item in array)
                if (item < valueToCompare) less++;
            return less;
        }

        public int Greated(int valueToCompare)
        {
            int greater = 0;
            foreach (var item in array)
                if (item > valueToCompare) greater++;
            return greater;
        }

        public void ShowEven()
        {
            foreach (var item in array)
            {
                if(item %2 == 0)
                {
                    Console.Write(item + " ");
                }
               
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }

            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int count = 0;
            int countUnique = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = 0; j < array.Length; j++)
                    if (array[i] == array[j])
                        count++;
                if (count == 1)
                {
                    countUnique++;
                    Console.Write(array[i] + " ");
                }
            }

            return countUnique;


        }

        public int EqualToValue(int valueToCompare)
        {
            int equaltovalue = 0;

            foreach (var item in array)
            {
                if(item == valueToCompare) equaltovalue++;
            }

            return equaltovalue;
        }
    }
}
