using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task2
{
    class Music : Movies
    {
        string _singer;
        string _length;
        string _name;
        Guid _code;
        string _category;
        double _size;
        public string Singer { get; set; }
        public string Length { get; set; }
        public string Name { get; set; }
        public Guid Code { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }
        public Music()
        {
            Singer = _singer = "BTS";
            Length = _length = "105";
            Name = _name = "Butter";
            Code = _code = Guid.NewGuid();
            Category = _category = "K-pop";
            Size = _size = 3.9;
        }
        public string ShowDataMusic()
        {
            return $"\nMusic: {Singer} - {Length} - {Name} - {Code} - {Category} - {Size}mb";
        }
        public override string ToString()
        {
            return $"Music: {Singer} - {Length} - {Name} - {Code} - {Category} - {Size}mb";
        }
    }
}
