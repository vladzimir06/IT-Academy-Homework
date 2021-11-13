using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task2
{
    class Movies
    {
        string _director;
        string _mainActress;
        string _mainActor;
        string _name;
        Guid _code;
        string _category;
        double _size;
        public string Director { get; set; }
        public string MainActress { get; set; }
        public string MainActor { get; set; }
        public string Name { get; set; }
        public Guid Code { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }
        public Movies()
        {
            Director = _director = "Даг Лайман";
            MainActress = _mainActress = "Анжелина Джоли";
            MainActor = _mainActor = "Бред Пит";
            Name = _name = "Мистер и миссис Смит";
            Code = _code = Guid.NewGuid();
            Category = _category = "Боевик";
            Size = _size = 335;
        }
        public string ShowDataMovies()
        {
            return $"\nMuvies: {Director} - {MainActress} - {MainActress} - {Name} - {Code} - {Category} - {Size}mb";
        }
        public override string ToString()
        {
            return $"Muvies: {Director} - {MainActress} - {MainActress} - {Name} - {Code} - {Category} - {Size}mb";
        }
    }
}

