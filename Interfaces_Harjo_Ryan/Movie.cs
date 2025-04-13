using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Harjo_Ryan
{
    class Movie : IGenre
    {
        public string Title { get; set; }

        public string Genre { get; set; }
        public string ESRB { get; set; }

        public Movie(string title, string genre, string esrb)
        {
            Title = title;
            Genre = genre;
            ESRB = esrb;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, Ssssshhhhh!");
        }

        public string Describe()
        {
            return $"{Title} is an {Genre} movie, rated {ESRB}";
        }
    }
}
