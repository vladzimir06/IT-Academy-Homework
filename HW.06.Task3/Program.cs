using System;
using System.Text;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            char[] arr = new char[str.Length];
            int t = 0;
            string dig = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str[i])) 
                {
                    t++;
                    dig = dig.Insert(dig.Length - 1, str[i].ToString()); 
                }
            }
            Console.WriteLine(dig);
            Console.WriteLine(dig.Length);
              for (int i = 0; i < dig.Length; i++)
              {
                  if (dig[i] == '+') 
                  {

                        string[] sub = dig.Split(new Char[] { '+' });
                        int j = Convert.ToInt32(sub[0]);
                        int k = Convert.ToInt32(sub[1]);
                        int answer = j + k;
                        Console.WriteLine(answer);
                   
                  }

                  if (dig[i] == '-')
                  {
                        string[] sub = dig.Split(new Char[] { '-' });
                        int j = Convert.ToInt32(sub[0]);
                        int k = Convert.ToInt32(sub[1]);
                        int answer = j - k;
                        Console.WriteLine(answer);
                  }

                  if (dig[i] == '*')
                  {
                        string[] sub = dig.Split(new Char[] { '*' });
                        int j = Convert.ToInt32(sub[0]);
                        int k = Convert.ToInt32(sub[1]);
                        int answer = j * k;
                        Console.WriteLine(answer);
                  }

                  if (dig[i] == '/')
                  {
                        string[] sub = dig.Split(new Char[] { '/' });
                        int j = Convert.ToInt32(sub[0]);
                        int k = Convert.ToInt32(sub[1]);
                        int answer = j / k;
                        Console.WriteLine(answer);
                  }
              }
        }
    }
}
