using System;

namespace HW05.Rand
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = null;
            int[] data1 = null;     
            int[] data2 = null;
            int m = 5;
            int a;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose\n1-Random\n2-Enter\n3-Sum of elements\n\n5-End");
                a = Convert.ToInt32(Console.ReadLine());
                //Console.Clear();
                switch (a)
                {
                    case 1:
                     Console.Clear();
                        Random rand = new Random();                     
                        data = new int[m];
                        for (int i = 0; i < m; i++)
                        {
                            data[i] = rand.Next(-100, 100);
                        }
                        
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{data[i]} ");

                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        data1 = new int[m];
                        for (int i = 0; i < m; i++) 
                        {
                            Console.Write($"Enter {i} element: ");
                            data1[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{data1[i]} ");

                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        data2 = new int[m];
                        for (int i = 0; i < m; i++) 
                        {
                            data2[i] = data[i] + data1[i];
                            
                        }
                        
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{data2[i]} ");

                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                }
            } while (a != 5);
        }
    }
}
