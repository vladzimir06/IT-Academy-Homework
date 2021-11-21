using System;
using System.Collections;

namespace HW._10.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objectList = new ArrayList();
            Computer computer = new Computer();
            Movies movies = new Movies();
            Music music = new Music();
            objectList.Add(music);
            objectList.Add(computer);
            objectList.Add(movies);
            Console.WriteLine(computer.ShowData());
            Console.WriteLine("===============");
            foreach (var item in objectList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
