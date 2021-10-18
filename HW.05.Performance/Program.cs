using System;
using System.Diagnostics;
using System.Threading;

namespace HW._05.Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Enter arr Range: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Int64[] arr = new Int64[m];
            for (int i = 0; i < m; i++) 
            {
                arr[i] = rand.Next(-100, 100);
            }
           /* int k = 0;
            for (int j = 0; j < m / 2; j++)
            {

                k = arr[j];
                arr[j] = arr[m - 1 - j];
                arr[m - 1 - j] = k;
            }
*/
            Array.Reverse(arr);
             /*for (int i = 0; i < m; i++)
             {
                 arr[i] = rand.Next(-100, 100);
                 //Console.Write($"{arr[i]} ");
             }*/*/
            stopwatch.Stop();
            Console.WriteLine();
            TimeSpan time = stopwatch.Elapsed;
          //  string timer = String.Format(time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
            Console.WriteLine(time.Milliseconds);
           
        }
    }
}
