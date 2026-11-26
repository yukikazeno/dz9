using Latypova.Resources.Classes.Games;

namespace Latypova
{
    class Program
    {
        static void RacesDemo()
        {
            BigRaces bigRaces = new BigRaces();
            bigRaces.AddTeam("Россия");
            bigRaces.AddTeam("Казахстан");
            bigRaces.AddTeam("Китай");
            bigRaces.AddTeam("Франция");
            BeachGame beachGame = new BeachGame();
            bigRaces.AddGame(beachGame);
            BullsGame bullsGame = new BullsGame();
            bigRaces.AddGame(bullsGame);
            FishingGame fishingGame = new FishingGame();
            bigRaces.AddGame(fishingGame);
            HillGame hillGame = new HillGame();
            bigRaces.AddGame(hillGame);
            MouseTrapGame mouseTrapGame = new MouseTrapGame();
            bigRaces.AddGame(mouseTrapGame);
            PostmanGame postmanGame = new PostmanGame();
            bigRaces.AddGame(postmanGame);
            SeaGame seaGame = new SeaGame();
            bigRaces.AddGame(seaGame);
        }

        static void Main(string[] args)
        {
            RacesDemo();
        }
    }
}