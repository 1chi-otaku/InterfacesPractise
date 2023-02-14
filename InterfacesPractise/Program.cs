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
            Array array = new Array(5);
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


        }
    }
}
