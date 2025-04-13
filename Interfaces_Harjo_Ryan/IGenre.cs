using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Harjo_Ryan
{
    interface IGenre
    {

        public class Game
        {
            // Automatic properties
            public string Title { get; set; }
            public string Genre { get; set; }
            public string ESRB { get; set; }

            // Method to describe the video game
            public void Describe()
            {
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Genre: {Genre}");
                Console.WriteLine($"ESRB Rating: {ESRB}");
            }
        }

    }
}
