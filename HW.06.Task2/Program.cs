using System;
using System.Linq;

namespace HW._06.Task2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            bool choose = false;
            int k;
            do
            {
                Console.Clear();
                Console.WriteLine("\nChoose What you want:\n1-Deleted\n2-Change\n3-Numbers\n4-Sort\n5-End");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                         Delete(str);
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 2:
                        Change(str);
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 3:
                        Numbers(str);
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 4:
                        Sort(str);
                        choose = true;
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        choose = false;
                        Console.ReadLine();
                        break;

                }
            } while (true);
 
        }

        static void Change(string str)
        {
            Console.WriteLine($" default string: {str}");
            string min = null, max = null;
            string[] sub = str.Split(' ');
            int lenght = sub[0].Length;
            int index1 = 0, index2 = 0;
          
            for (int i = 0; i < sub.Length; i++)
            {
                if (lenght < sub[i].Length)
                {
                    index1 = i;
                    max = sub[i];
                }

                if (lenght >= sub[i].Length)
                {
                    index2 = i;
                    min = sub[i];
                }
                
                lenght = sub[i].Length;
            }
            Console.WriteLine($"min: {min} with index {index2}");
            Console.WriteLine($"max: {max} with index {index1}");

           string tmp = sub[index1];
            sub[index1] = sub[index2];
            sub[index2] = tmp;
           
            Console.WriteLine("\n");
           
            for (int i = 0; i < sub.Length; i++)
            {
                Console.Write($"{sub[i]} ");
            }

        }

        static void Numbers(string str)
        {
            Console.WriteLine($" default string: {str}");
            string[] sub = str.Split(' ');
            int lenth = sub.Length;
            int letter = 0, punctuation = 0, digit = 0, space = 0, other = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i])) letter++;
                else if (Char.IsPunctuation(str[i])) punctuation++;
                else if (Char.IsDigit(str[i])) digit++;
                
            }
            for (int j = 0; j < str.Length - letter - punctuation - digit - space; j++) {
                other++;
            }
            Console.WriteLine($"letters are: {letter}\npunctuation are: {punctuation}\ndigits are: {digit}\nspases are: {space}\nOthers: {other}");
        }

        static void Sort(string str) 
        {
            Console.WriteLine($" default string: {str}");
            string[] sub = str.Split(' ');
            sub = sub.OrderByDescending(aux => aux.Length).ToArray();
            foreach (var item in sub)
            {
                Console.Write($"{item} ");
            }
        }

        static void Delete(string str)
        {
            Console.WriteLine($" default string: {str}");
            int lenth = default;
            string len = default;
            string[] sub = str.Split(' ');
            //lenth = sub[0].Length;
            for (int i = 0; i < sub.Length ; i++)
            {
                if (lenth < sub[i].Length)
                {
                    lenth = sub[i].Length;
                    len = sub[i];
                }
                else 
                { 
                    lenth = sub[i].Length;
                }
            }
            for (int i = 0; i < sub.Length - 1; i++)
            {
                if (sub[i].Equals(len)) 
                {
                    if (sub[i].Equals(sub[0])) sub[i] = null;
                    sub[i] = sub[i + 1];
                }
                
                Console.Write($"{sub[i]} ");
            }   
        }
    }
}
