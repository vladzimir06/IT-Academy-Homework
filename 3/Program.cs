using System;

namespace _3
{
    class Program
    {
        //Вывод “Должно быть больше” или “Должно быть меньше”
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
        //Вывод “Должно быть больше” или “Должно быть меньше” в строках 55, 56.
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
                        if (sum1 < sum2) { Console.WriteLine($"Should be more then {sum1}!"); }
                        else if (sum1 > sum2) { Console.WriteLine($"Should be less then {sum1}!"); }
                        sum = sum2;
                        Console.WriteLine($"Inquari Answer: {sum}");
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
