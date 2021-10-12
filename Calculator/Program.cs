using System;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        private const double pi = 3.14;
        public int Plus(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum: ", sum);
            return sum;
        }

        public double Minus(double a, double b)
        {
            double razn = a - b;
            Console.WriteLine("Minus: ", razn);
            return razn;
        }

        public double Multiplication(double a, double b)
        {
            double mult = a * b;
            Console.WriteLine("Mult: ", mult);
            return mult;
        }

        public double Division(double a, double b)
        {
            double div = a / b;
            Console.WriteLine("Division: ", div);
            return div;
        }

        public double Ost(double a, double b)
        {
            double ost = ost = a % b;
            Console.WriteLine("Ost: ", ost);
            return ost;
        }

        public double Square(double r)
        {
            double square = pi * r * r;
            Console.WriteLine("Square: ",square);
            return square;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool choise = false;
            Calculator calculator = new Calculator();
            do
            {
                Console.WriteLine("2.Square/1.Arithmetic");
                int a;
                while (!int.TryParse(Console.ReadLine(),out a)) 
                {
                    choise = false;
                    Console.Clear();
                    break;
                }

                if (a == 1) 
                {
                    Console.WriteLine("Choose signed: ");
                    string input = Console.ReadLine();
                    Console.WriteLine("Enter Params: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    int t = Convert.ToInt32(Console.ReadLine());
                   
                    if (input.Contains('+')) { Console.WriteLine(calculator.Plus(p,t)); }
                    else if (input.Contains('-')) { Console.WriteLine (calculator.Minus(p,t)); }
                    else if (input.Contains('*')) { Console.WriteLine (calculator.Multiplication(p, t)); }
                    else if (input.Contains('/')) { Console.WriteLine(calculator.Division(p, t)); }
                    else if (input.Contains('%')) { Console.WriteLine(calculator.Ost(p, t)); }
                }
                
                else if (a == 2) 
                {
                    Console.WriteLine("Enter radius: ");
                    int r;
                    while (!int.TryParse(Console.ReadLine(), out r))
                    {
                        Console.WriteLine("Wrong input ");
                    }
                  Console.WriteLine( calculator.Square(r));
                }
               
                else 
                {
                    Console.Clear();
                    Console.WriteLine("1.End/2.Continue");
                    int r;
                    while (!int.TryParse(Console.ReadLine(), out r))
                    {
                        Console.WriteLine("Wrong input ");
                        break;
                        Console.Clear();
                    }
                  
                    if (Convert.ToDouble(r) == 1) break;

                    else 
                    { 
                        choise = false;
                        Console.Clear();
                    }
                }

            } while (choise == false);
        }
    }

   
}
