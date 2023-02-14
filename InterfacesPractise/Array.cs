using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractise
{
    class Array : IOutput, IMath, Isort
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
    }
}
