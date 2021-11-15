using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com
{
    class Adition
    {
        public string Aditions(int choosePrice) 
        {
            string resoult = null;
            switch (choosePrice)
            {
                case 1:
                    resoult = "Душ      Туалет      Двузспальная кровать\t\nИмеется\tИмеется\t+Имеется";
                    break;
                case 2:
                    resoult = "Душ      Телевизор      Двузспальная кровать\t\nИмеется\tИмеется\tОтсутствует";
                    break;
                case 3:
                    resoult = "Джакузи      Балкон      Доп.Комната\t\nИмеется\tОтсутствует\tИмеется";
                    break;
                case 4:
                    resoult = "Соседи      Это Люкс     Доп.Комната\t\nИмеется\tКак Посматреть\tВсе реально";
                    break;
                case 5:
                    resoult = "Окна     Холодильник      Доп.Комната\t\nИмеется\tИмеется\tОтсутствует";
                    break;
                case 6:
                    resoult = "Джакузи      Балкон      Доп.Комната\t\nОтсутствует\tОтсутствует\tИмеется";
                    break;
                default:
                    break;
            }
            return resoult;
        }
    }
}
