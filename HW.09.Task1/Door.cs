using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    class Door
    {
        private string _color;
        public Door() { }
        public Door(string color) {
            _color = color;
        }
        public string Color { get; set; }
        public void ShowData ()
        {
            Console.WriteLine($"I am a door, my color is {_color}");
        }
    }
}
