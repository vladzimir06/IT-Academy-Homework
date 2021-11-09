using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    class ComputerPrograms
    {
        string _name;
        int _code;
        string _category;
        int _size;
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }
        public ComputerPrograms() 
        {
            _name = Name;
            _code = Code;
            _category = Category;
            _size = Size;
        }
        public void ShowData()
        {
            Console.WriteLine($"ComputerProgram: {Name} - {Code} - {Category} - {Size}");
        }
    }
}
