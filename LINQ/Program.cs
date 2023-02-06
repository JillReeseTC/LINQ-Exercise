namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            List<string> games = new() { "Myst", "WOWC", "Doom", "Call of Duty", "Halo", "Tetris" };

            IEnumerable<string> gamesWith4Letters = games.Where(name => name.ToCharArray().Count() == 4);

            Console.WriteLine("Game Names with 4 Letters:");
            foreach (var game4 in gamesWith4Letters)
            {
                Console.WriteLine(game4);
            }
            Console.WriteLine();
            Console.WriteLine("Game Names in alphabetical order:");
            IEnumerable<string> gamesInOrder = games.OrderBy(name => name);
            foreach (var game1 in gamesInOrder)
            {
                Console.WriteLine(game1);
            }
            Console.WriteLine();
            Console.WriteLine("Game Names in order by length:");
            IEnumerable<string> gamesInOrder2 = games.OrderBy(name => name.ToCharArray().Count());
            foreach (var game2 in gamesInOrder2)
            {
                Console.WriteLine(game2);
            }

            //Exercise 2



        }
    }
}
