using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, j, k;
            Console.Write("Enter size 1-100:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = num - i; k >= 0; k--)
                {
                    if (i > 9)  Console.Write($" {Convert.ToString(i)[1].ToString()}"); 
                    else Console.Write($" {i}");
                }
                Console.WriteLine();

            }
        }
    }
}
