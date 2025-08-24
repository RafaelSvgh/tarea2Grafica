using PGrafica;

class Program
{
    static void Main(string[] args)
    {
        using (Game game = new())
        {
            game.Run(60.0);
        }
    }
}