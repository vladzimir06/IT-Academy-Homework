using System;

namespace HW._10.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());
            person.SayHi();

            Student student = new Student();
            Console.WriteLine(student.ToString());
            student.SetAge(21);
            student.SayHi();
            student.ShowAge();

            Teacher teacher = new Teacher();
            Console.WriteLine(teacher.ToString());
            teacher.SetAge(30);
            teacher.SayHi();
            teacher.Explain();
        }
    }
}
