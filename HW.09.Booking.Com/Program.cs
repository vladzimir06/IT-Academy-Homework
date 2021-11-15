using System;
using System.Collections.Generic;

namespace HW._09.Booking.Com
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> yourChoice = new List<object>();
            Console.WriteLine("Enter What you want:\n1-Жилье ");
            int yourDecision = Convert.ToInt32(Console.ReadLine());
            switch (yourDecision)
            {
                case 1:
                    House house = new();
                    Console.WriteLine("Enter Country:");
                    house.Country = Console.ReadLine();
                    Console.WriteLine("Enter Data of arrival:");
                    house.ArrivalData = Console.ReadLine();
                    Console.WriteLine("Enter Data of departure: ");
                    house.DateOfDeparture = Console.ReadLine();
                    Console.WriteLine("Enter Number of persons: ");
                    house.NumberOfPersons = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    house.ShowPrices();
                    int choosePrice = Convert.ToInt32(Console.ReadLine());
                    yourChoice.Add(house.ShowPrices(choosePrice));
                    yourChoice.Add(house.Aditions(choosePrice));
                    yourChoice.Add($"СтранаЖ {house.Country}");
                    yourChoice.Add($"Дата Прибытия{house.ArrivalData}");
                    yourChoice.Add($"Дата отбытия {house.DateOfDeparture}");
                    yourChoice.Add($"Persons: {house.NumberOfPersons}");
                    break;
                case 2:
                    Console.WriteLine("Другие случаи не рассмотрены)");
                    break;
                default:
                    break;
            }
            Console.Clear();
            foreach (var item in yourChoice)
            {
                Console.WriteLine(item);
            }
        }
    }
}
