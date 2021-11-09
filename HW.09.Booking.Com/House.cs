using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com
{
    class House : Adition
    {
        public string ArrivalData { get; set; }
        public string DateOfDeparture { get; set; }
        public string Country { get; set; }
        public int NumberOfPersons { get; set; }

        public void ShowPrices()
        {
            Console.WriteLine("Choose Appartaments: ");
            Console.WriteLine("1.Prestige New ApartComplex - BYN 1_872");
            Console.WriteLine("2.Royal Apartments Minsk - BYN 4_449");
            Console.WriteLine("3.Отель Минск - BYN 4_530");
            Console.WriteLine("4.Гостиница Беларусь - BYN 3_789");
            Console.WriteLine("5.IBB Hotel - BYN 2_954");
            Console.WriteLine("6.Бонотель - BYN 3_863");
        }
        public string ShowPrices(int a)
        {
            string hotelWithPrice = null;
            switch (a) 
            {
                case 1: hotelWithPrice = "Prestige New ApartComplex - BYN 1872";
                    break;
                case 2:
                    hotelWithPrice = "Royal Apartments Minsk - BYN 4449";
                    break;
                case 3:
                    hotelWithPrice = "Отель Минск - BYN 4530";
                    break;
                case 4:
                    hotelWithPrice = "остиница Беларусь - BYN 3789";
                    break;
                case 5:
                    hotelWithPrice = "IBB Hotel - BYN 2954";
                    break;
                case 6:
                    hotelWithPrice = "Бонотель - BYN 3863";
                    break;
            }
            return hotelWithPrice;
        }

    }
}
