using System;
using System.Text;

namespace HW._07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1a!2.3!!..4.!.? 6 7!.. ?");
            string []splited1 = sb.ToString().Split("?");
            for (int i = 0; i < splited1[0].Length - 1; i++)
            {
                if (sb[i].Equals('!'))
                {
                    sb.Remove(i, 1);
                    i--;
                    Console.WriteLine($"Remove {i} : {sb}");
                }
             }
            string[] splited2 = sb.ToString().Split("?");
            for (int i = 0; i < splited2[0].Length - 1; i++)
            {
                    if (sb[i].Equals('.')) 
                    {
                        sb.Remove(i, 1);
                        i--;
                        Console.WriteLine($"Remove {i} : {sb}");
                    }
            }
            string[] splited3 = sb.ToString().Split("?");
            for (int i = 1; i < splited3.Length - 1; i++)
            {
                sb.Replace(' ', '_');
            }
            Console.WriteLine(sb);
        }
    }
}
