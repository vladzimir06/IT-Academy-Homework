using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13
{
    interface ISongService
    {
        public string FindByGenre(List<string> song)
        {
            for (int i = 0; i < song.Count; i++)
            {
                string[] devidedSongs = song[i].Split(",");
                Console.WriteLine(devidedSongs[3]);
            }
            return "";
        }
    }
}
