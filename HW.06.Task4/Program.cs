using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace HW._06.Task4       
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"E:\C# (courses)\FindMe.txt", true);

            string textReaderResult = textReader.ReadToEnd();
            //textReaderResult.Trim();
            string[] arrayOfTextResult = textReaderResult.Split(" ");
            int k = 0;
             for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
             {
                if (!Char.IsLetter(textReaderResult[i]) && !Char.IsDigit(textReaderResult[i]))
                {
                    k++;
                    byte[] bytes = Encoding.Default.GetBytes(arrayOfTextResult[i]);
                    string hex = BitConverter.ToString(bytes);
                    hex = hex.Replace("-","");

                    //string Result = Char.ConvertToUtf32(textReaderResult[i], i);
                    Console.WriteLine($"{textReaderResult[i]} - index {i} - hex form - {hex}");
                }
             }

            Console.WriteLine($"There about {k} simbols");
        }
    }
}
