using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choose = false;
            int k;
            string str;
            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("\nChoose What you want:\n1-devided string\n2-Change O on A\n3-Output strink by line\n4-End");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.Clear();
                        string[] sub = str.Split(';');
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        char[] arr = str.ToUpper().ToCharArray();
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (arr[i] == 'O')
                            {
                                arr[i] = 'A';

                            }
                        }

                        for (int i = 0; i < str.Length; i++)
                        {
                            Console.Write(arr[i]);
                        }
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        sub = str.Split(';');
                        foreach (var item in sub)
                        {
                            Console.WriteLine($"{item}");
                        }
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        choose = false;
                        Console.ReadLine();
                        break;

                    
                }
            }while(true);
        }
    }
}
