using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(20);
            array.Random(10, 99);
            array.Show();
            Console.WriteLine("Max - " + array.Max());
            Console.WriteLine("Min - " + array.Min());
            Console.WriteLine("AVG - " + array.Avg());
            Console.WriteLine("Enter value to search: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (array.Search(value) == true) 
                Console.WriteLine("Found it!");
            else
                Console.WriteLine("Didn't found it...");
            Console.WriteLine("Array was sorted: ");
            array.SortAsc();
            array.Show();
            Console.WriteLine("Array was sorted again: ");
            array.SortDesc();
            array.Show();
            Console.WriteLine("There are " + array.Less(25) + " elements in the array that less than 25.");
            Console.WriteLine("There are " + array.Greated(25) + " elements in the array that grater than 25.");
            Console.WriteLine("Even elements: ");
            array.ShowEven();
            Console.WriteLine("Odd elements: ");
            array.ShowOdd();
            Console.WriteLine("There are " + array.CountDistinct() + " unique elements in the array.");
            Console.WriteLine("There are " + array.EqualToValue(value) + " elements that equal to " + value);

        }
    }
}
