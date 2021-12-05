using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HW._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Butter", 2.45, "Perry", 2021, "0");
            song.GetSongData();
            Console.WriteLine(song.ToJason());
            List<string> songs = new List<string>();
            songs.Add(song.ToString());
            song.FindByGenre(songs);
        }
    }
}
