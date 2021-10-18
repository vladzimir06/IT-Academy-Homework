using System;
using System.Threading;

namespace HW05.Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = Random();
            int[] data1;
            Console.WriteLine("Enter size array 1: ");
            int m = Convert.ToInt32(Console.ReadLine());
            data1 = new int[m];
            for (int i = 0; i < m; i++) 
            {
                data1[i].Random;

            }
        }
    }
}
