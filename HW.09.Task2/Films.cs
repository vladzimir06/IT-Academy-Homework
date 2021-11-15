using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    class Films
    {
        string _director;
        string _mainActress;
        string _mainActor;
        public string Director { get; set; }
        public string MainActress { get; set; }
        public string MainActor { get; set; }
        public Films()
        {
           _director = Director;
           _mainActress = MainActress;
           _mainActor = MainActor;
        }       
        public override string ToString()
        {
            return $"Films: {Director} - {MainActor} - {MainActress}";
        }
        public void Play()
        {
            Console.WriteLine(ToString());
        }
    }
}
