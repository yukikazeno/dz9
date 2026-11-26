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
            if (teams.Count < 2)
            {
                Console.WriteLine("Недостаточно команд для проведения Больших гонок.");
                return;
            }

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
