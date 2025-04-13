namespace Interfaces_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("Hollow Knight", "2D Side-Scrolling Metroidvania Action Adventure", "E");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();


            Movie myMovie = new Movie("The Lego Movie", "Animated Adventure Comedy", "PG");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
