using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayDeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 21, 92, 3, 44, 75, 16, 17, 88, 99, 10, 11, 12 };

            Array.Sort(arr);
           
            foreach (int i in arr)
            {
                Console.WriteLine(i);
           
            }
            Console.WriteLine("====================");
           int valueofArray= Array.BinarySearch(arr, 17);
            Console.WriteLine(valueofArray);
            Console.ReadLine();
        }
    }
}
