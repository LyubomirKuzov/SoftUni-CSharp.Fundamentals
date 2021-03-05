using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] songArgs = Console.ReadLine().Split(new char[] { '_' }).ToArray();

                string typeList = songArgs[0];
                string name = songArgs[1];
                string time = songArgs[2];

                Song song = new Song()
                {
                    TypeList = typeList,
                    Name = name,
                    Time = time
                };

                songs.Add(song);
            }

            string songTypeToPrint = Console.ReadLine();

            if (songTypeToPrint != "all")
            {
                songs = songs
                    .Where(s => s.TypeList == songTypeToPrint)
                    .ToList();
            }

            foreach (var song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
