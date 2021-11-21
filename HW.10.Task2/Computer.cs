using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task2
{
    class Computer : Music
    {
        string _name;
        Guid _code;
        string _category;
        double _size;
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public Computer()
        {
            _name = "Visual Studio 2022";
            _code = Guid.NewGuid();
            _category = "IDE";
            _size = 15000;
        }
        public override string ToString()
        {
            return $"ComputerProgram: {_name} - Guid: {_code} - {_category} - {_size}мб";
        }
        public string ShowData()
        {
            return $"ComputerProgram: {_name} - Guid: {_code} - {_category} - {_size}мб" + ShowDataMusic() + ShowDataMovies();
        }
        public void Play()
        {
            Console.WriteLine(ToString());
        }
    }
}

