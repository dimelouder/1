using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Output(List<int> ints)
        {
            foreach (int element in ints)
            {
                Console.Write($"{element}\t");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 1. Создание пустой коллекции
            List<int> ints = new List<int>();

            // 2. Добавление элементов в коллекцию
            ints.Add(1);
            ints.Add(10);
            ints.Add(25);
            ints.Add(17);
            ints.Add(10);

            // 4 
            ints.Insert(0,250);
            Output(ints);
            Console.WriteLine();
            // 3. Вывод
            //foreach (int element in ints)
            //{
            //    Console.Write($"{element}");
            //}

            ints.AddRange(new[] {-4,0,18,-3 });
            Output(ints);
            Console.WriteLine();

            int size = ints.Count;
            Console.WriteLine($"Размер коллекции = {ints.Count}");

            ints.Remove(10);
            Output(ints);
            Console.WriteLine();
            ints.Sort();
            ints.Reverse();
        }
    }
}
