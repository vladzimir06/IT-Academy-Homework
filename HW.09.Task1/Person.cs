using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    class Person
    {
        string _name;
        string _personColor;
        double _personArea;

        public string Name { get; set; } 
        public Person(string personName, double personArea, string personColor) 
        {
            _name = personName;
            _personArea = personArea;
            _personColor = personColor;
        }
        public void ShowData() 
        {
            House house = new House();
            house.Area = _personArea;
            Console.WriteLine($"NamePerson: {_name}");
            house.ShowData();
            house.GetDoor(_personColor);

        }
    }
}
