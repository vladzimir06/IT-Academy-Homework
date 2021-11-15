using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    class MusicFiles
    {
        string _singer;
        string _length;
        public string Singer { get; set; }
        public string Length { get; set; }
        public MusicFiles()
        {
            _singer = Singer;
            _length = Length;
        }
        public void ShowData()
        {
            Console.WriteLine($"MusicFiles: {Singer} - {Length} seconds");
        }
        public override string ToString()
        {
            return $"MusicFiles: {Singer} - {Length} seconds";
        }
        public void Play() 
        {
            Console.WriteLine(ToString());     
        }
    }
}
