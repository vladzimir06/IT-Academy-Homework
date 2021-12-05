using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace HW._13
{
    class Song:ISongService
    {
        [Flags]
        public enum MusicGenre
        {
            Rock = 0,
            Hip_Hop,
            Pop
        }

        string _songName = null;
        double _songLenth = default;
        string _songAuthor = null;
        int _songYear = default;
        string _genre;

        [JsonProperty("Author")]
        public string SongAuthor { get; set; }
        Song() { }
        public Song(string songName, double songLenth, string songAuthor, int year, string genre) 
        {
            _songName = songName;
            _songLenth = songLenth;
            _songAuthor = songAuthor;
            _songYear = year;
            if (int.TryParse(genre, out int n))
            {
                MusicGenre musicGenre = (MusicGenre)Convert.ToInt32(genre);
                _genre = Convert.ToString(musicGenre);
            }
            else
            {
                switch (genre) 
                {
                    case "Rock": _genre = Convert.ToString(MusicGenre.Rock);
                        break;
                    case "Hip_Hop": _genre = Convert.ToString(MusicGenre.Hip_Hop);
                        break;
                    case "Pop": _genre = Convert.ToString(MusicGenre.Pop);
                        break;
                    default: _genre = Convert.ToString(MusicGenre.Hip_Hop | MusicGenre.Pop);
                        break;
                }
            }
        }

        public override string ToString()
        {
            var SongDescription = new
            {
                name = _songName,
                lenth = _songLenth,
                author = _songAuthor,
                year = _songYear,
            };
            Console.WriteLine(JsonConvert.SerializeObject(SongDescription));
            return $"Title: {SongDescription.name}, Minutes: {SongDescription.lenth}, AlbumYear: {SongDescription.year}, Genre: {_genre}";
        }

        public void GetSongData()
        {
            Console.WriteLine(ToString());
        }
        public string ToJason() 
        {
            var SongDescription = new Song
            {
                SongAuthor = "Perry",
            
            };
            string json = System.Text.Json.JsonSerializer.Serialize<Song>(SongDescription);
            return json;
        }
        public string FindByGenre(List<string> song)
        {
            for (int i = 0; i < song.Count; i++)
            {
                string[] devidedSongs = song[i].Split(" ");
                string[] categoruSeparet = devidedSongs[7].Split(",");
                for (int j = 0; j < categoruSeparet.Length; j++)
                {
                    Console.WriteLine(categoruSeparet[j]);
                }
            }
            Console.WriteLine(MusicGenre.Hip_Hop | MusicGenre.Pop);
            return "";
        }
    }
}
