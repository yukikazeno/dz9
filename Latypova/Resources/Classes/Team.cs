namespace Latypova
{
    public class Team
    {
        public List<Player> Players { get; private set; }
        public string Name { get; private set; }
        public int WinsCount { get; set; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
            for (int i = 0; i < 15; i++)
            {
                Players.Add(new Player($"Player {i + 1}"));
            }
        }
    }
}
