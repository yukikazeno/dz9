using Latypova.Resources.Classes.Games;
using System.Runtime.InteropServices;

namespace Latypova
{
    public class BigRaces
    {
        public List<Team> teams = new List<Team>();
        public Queue<IGame> gamesQueue = new Queue<IGame>();
        public List<IGame> gameList = new List<IGame>();

        public void AddGame(IGame game)
        {
            gameList.Add(game);
        }

        public void AddTeam(string teamName)
        {
            teams.Add(new Team(teamName));
        }

        public void StatShow()
        {
            AddTeam("Россия");
            AddTeam("Казахстан");
            AddTeam("Китай");
            AddTeam("Франция");

            BeachGame beachGame = new BeachGame();
            gameList.Add(beachGame);
            BullsGame bullsGame = new BullsGame();
            gameList.Add(bullsGame);
            FishingGame fishingGame = new FishingGame();
            gameList.Add(fishingGame);
            HillGame hillGame = new HillGame();
            gameList.Add(hillGame);
            MouseTrapGame mouseTrapGame = new MouseTrapGame();
            gameList.Add(mouseTrapGame);
            PostmanGame postmanGame = new PostmanGame();
            gameList.Add(postmanGame);
            SeaGame seaGame = new SeaGame();
            gameList.Add(seaGame);
            Random.Shared.Shuffle(CollectionsMarshal.AsSpan<IGame>(gameList));
            gamesQueue = new Queue<IGame>(gameList.Take(6));

            foreach (var game in gamesQueue)
            {
                game.PlayGame(teams);
            }

            Team? winner = teams.MaxBy(t => t.WinsCount);
            Console.WriteLine($"Победитель Больших гонок: команда страны {winner?.Name}");
        }
    }
}
