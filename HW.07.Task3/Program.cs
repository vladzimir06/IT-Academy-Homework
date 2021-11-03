using System;
using System.Text;

namespace HW._07.Task3
{
    class Program
    {
        string Travel(string addresses, string zipcode) 
        {
            string travel = null;
            int numOfAdresses = 0;
            bool numberInString = false;
            string[] zipcodeDivide = zipcode.Split(" ");
            StringBuilder firstAdress = new StringBuilder();
            StringBuilder adressofHouse = new StringBuilder();
            StringBuilder numberofHouse = new StringBuilder();
            string[] eachClient = addresses.Split(",");
            for (int i = 0; i < eachClient.Length; i++)
            {
                string[] parmsAdresses = eachClient[i].Split(" ");
                for (int j = 0; j < parmsAdresses.Length - 1; j++)
                {
                    if (parmsAdresses[j].Equals(zipcodeDivide[0]) && parmsAdresses[j + 1].Equals(zipcodeDivide[1]))
                    {
                        numberInString = true;
                        numOfAdresses++;
                        firstAdress.Append($"{eachClient[i]},");
                    }
                }
            }
            if(numberInString == false)
            {
                return travel = $"{zipcode}:/";
            }
            string secondAdress = Convert.ToString(firstAdress);
            string[] devideAdressString = secondAdress.Split(",");
            for (int i = 0; i < devideAdressString.Length - 1; i++)
            {
                string forHouse = Convert.ToString(devideAdressString[i]);
                string[] forAdressHouse = forHouse.Split(" ");
                for (int j = 1; j < forAdressHouse.Length - 2; j++)
                {
                    adressofHouse.Append($" {forAdressHouse[j]}");
                }
                adressofHouse.Append(",");
                numberofHouse.Append($"{forAdressHouse[0]},");

            }
            numberofHouse.Remove(numberofHouse.Length - 1, 1);
            adressofHouse.Remove(adressofHouse.Length - 1, 1);
            travel =  $"{zipcode}:{adressofHouse}/{numberofHouse}";
            return travel;
        }
        static void Main(string[] args)
        {
            string addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";
            Program program = new Program();
            Console.WriteLine(program.Travel(addresses, "NY 56432"));
        }
    }
}
