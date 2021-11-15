using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    class House
    {
        double _area;
        public House() { }
        public double Area { get; set; }
        public House(double Area) 
        {
            _area = Area;
        }
        public void ShowData() 
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }
        public void GetDoor(string color) 
        {
            Door door = new Door(color);
            door.Color = color;
            door.ShowData();
        }
    }
}