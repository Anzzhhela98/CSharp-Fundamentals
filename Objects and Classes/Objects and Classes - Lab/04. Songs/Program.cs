using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSongs = int.Parse(Console.ReadLine());
            List<Song> saveSongs = new List<Song>();
            for (int i = 0; i < countSongs; i++)
            {
                string[] arr = Console
                         .ReadLine()
                         .Split("_")
                         .ToArray();
                string typeList = arr[0];
                string nameOfSong = arr[1];
                string time = arr[2];
                Song song = new Song();
                song.TypeList = typeList;
                song.NameOfSong = nameOfSong;
                song.Time = time;
                saveSongs.Add(song);
            }
            string type = Console.ReadLine();
            if (type == "all")
            {
                foreach (var song in saveSongs)
                {
                    Console.WriteLine(song.NameOfSong);
                    continue;
                }
            }

            foreach (var song in saveSongs)
            {
                if (song.TypeList == type)
                {
                    Console.WriteLine(song.NameOfSong);
                    continue;
                }
            }


        }
        class Song
        {
            public string TypeList { get; set; }
            public string NameOfSong { get; set; }
            public string Time { get; set; }
        }
    }
}
