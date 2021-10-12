using System;
using System.Threading;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zeroTime = new DateTime(1,1,1);
            DateTime data2 = DateTime.Now;
            Console.WriteLine("Enter Data: (2002 - year/12 - month/12 - day)");
            DateTime data1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(data1);
            TimeSpan data4 = data2 - data1;
            int years = (zeroTime + data4).Year - 1;

            Console.WriteLine(years);
        }
    }
}
