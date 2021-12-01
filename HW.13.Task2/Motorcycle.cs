using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.Task2
{
    class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometre { get; set; }

        public override string ToString()
        {
            Log.Information("The proces data to Console");
            return $"Id:{Id}, Name: {Name}, Model: {Model}, Odometre: {Odometre}, Year: {Year}";
        }
    }
}
