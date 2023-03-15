using System;
using System.Collections.Generic;
using System.Linq;

namespace Завдання_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"яблуко", "груша", "слива"};

            var ListSum = list.Sum(a => a.Length);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nСума довжин усіх рядків = {ListSum}");

            Console.ReadKey();
        }
    }
}