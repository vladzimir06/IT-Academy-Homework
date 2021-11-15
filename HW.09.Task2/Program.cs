using System;

namespace HW._09.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter num of ComputerPrograms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ComputerPrograms[] computerPrograms = new ComputerPrograms[n];
            for (int i = 0; i < n; i++)
            {
                computerPrograms[i] = new ComputerPrograms();
                computerPrograms[i].Name = "computerProgram";
                computerPrograms[i].Code = 1223334444;
                computerPrograms[i].Category = "Progarms";
                computerPrograms[i].Size = 420;
                computerPrograms[i].ShowData();
            }
            Films[] films = new Films[n];
            for (int i = 0; i < n; i++)
            {
                films[i] = new Films();
                films[i].Director = "James Cameron";
                films[i].MainActor = "Brad Pit";
                films[i].MainActress = "Angelina Jolie";
                films[i].Play();
            }
            MusicFiles[] musicFiles = new MusicFiles[n];
            for (int i = 0; i < n; i++)
            {
                musicFiles[i] = new MusicFiles();
                musicFiles[i].Singer = "Kim Nam-joon";
                musicFiles[i].Length = "235";
                musicFiles[i].Play();
            }
        }
    }
}
