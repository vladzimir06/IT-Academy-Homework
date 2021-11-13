using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task1
{
    class Person
    {
        private protected int _age;
        public void SetAge(int n) 
        {
            _age = n;
        }
        public void SayHi()
        {
            Console.WriteLine("Hello");
        }
    }
}
