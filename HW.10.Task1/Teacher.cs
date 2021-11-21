using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task1
{
    class Teacher : Person
    {
        string _subject;
        public void Explain() 
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
