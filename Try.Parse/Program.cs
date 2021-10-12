using System;

namespace Try.Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse("a");
            bool b = bool.Parse("true");
            Console.WriteLine(b);

            int number;
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            bool result = int.TryParse(input, out number);
        }
    }
}
