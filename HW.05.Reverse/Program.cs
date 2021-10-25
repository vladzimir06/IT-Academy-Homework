using System;
using System.Diagnostics;
using System.Threading;

namespace HW._05.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Enter Size array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
            for (int i = 0; i < size; i++) {
                arr[i] = rand.Next(-10, 10);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int k = 0;
            for (int j = 0; j < size / 2; j++)
            {

                k = arr[j];
                arr[j] = arr[size - 1 - j];
                arr[size - 1 - j] = k;
            }

            Console.WriteLine("\n");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }

           
        }
    }
}
