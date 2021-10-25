using System;

namespace HW._05.GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            int hours = data.Hour;
            switch (hours) 
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Good Morning, guys");
                    break;
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Good day, guys");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine("Good evening, guys");
                    break;
                case 22:
                case 23:
                case 24:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Good night, guys");
                    break;

            }
        }
    }
}
