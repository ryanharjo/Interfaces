using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Harjo_Ryan
{
    class Game : IGenre
    {
        public string Title { get; set; }

        public string Genre { get; set; }
        public string ESRB { get; set; }

        public Game(string title, string genre, string esrb)
        {
            Title = title;
            Genre = genre;
            ESRB = esrb;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting, Game On!");
        }

        public string Describe()
        { 
            return $"{Title} is a {Genre} game, rated {ESRB}";
        }

    }
}
