using System;

namespace _2
{
    class Program
    {
        //Добавлены запрсы переменных для арифметического примера в строках 8,15,22.
        public static string Inquiry1()
        {
            Console.WriteLine("Enter a:");
            string a = Console.ReadLine();
            return a;
        }

        public static string Inquiry2()
        {
            Console.WriteLine("Enter b:");
            string b = Console.ReadLine();
            return b;
        }

        public static double SumEnd() 
        {
            double sum;
            Console.WriteLine("Enter Resoult:");
            sum = Convert.ToDouble(Console.ReadLine());
            return sum;
        }
        //Использование запросов в строках 36,37,44.
        //Вывод “Правильно” или “Неправильно” суммы в строках 49,54.
        static double Sum()
        {
            double sum = 0, sum1 = 0, sum2 = 0, number1, number2;
            bool q;

            do
            {
                string a = Inquiry1();
                string b = Inquiry2();

                bool result1 = double.TryParse(a, out number1);
                bool result2 = double.TryParse(b, out number2);

                if (result1 == true && result2 == true)
                {
                    sum1 = SumEnd();
                    sum2 = number1 + number2;
                   
                    if (sum1 == sum2)
                    {
                        sum = sum1;
                        Console.WriteLine($"Inquiry is true Answer: {sum}");
                    }
                    else
                    {
                        sum = sum2;
                        Console.WriteLine($"Inquari is false Answer: {sum}");
                    }
                    
                    q = true;
                }
                else
                {
                    Console.Clear();
                    if (result1 == false) Console.WriteLine($"Try Again, Your first number '{a}' isn't a number!");
                    else if (result2 == false) Console.WriteLine($"Try Again, Your second number '{b}' isn't a number!");
                    q = false;
                }

            } while (q == false);

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Answer: {0}", Sum());
        }
    }
}