namespace Latypova
{
    public class BullsGame : IGame
    {
        public string Name => "Битва с быком";

        VictoryConditions beachConditions = new VictoryConditions(3, 5, 4, 4, 1);

        Dictionary<Team, int> teamScores = new Dictionary<Team, int>();

        public Team PlayGame(List<Team> teams)
        {
            Console.WriteLine($"Игра: {Name}");
            teamScores.Clear();
            foreach (var team in teams)
            {
                teamScores[team] = 0;
                foreach (var player in team.Players)
                {
                    if (player.Speed >= beachConditions.Speed
                        && player.Strength >= beachConditions.Strength
                        && player.Stamina >= beachConditions.Stamina
                        && player.Skill >= beachConditions.Skill
                        && player.Imagination >= beachConditions.Imagination)
                    {
                        if (!teamScores.ContainsKey(team))
                        {
                            teamScores[team] = 0;
                        }
                        teamScores[team]++;
                    }
                }
            }
            var winningTeam = teamScores.MaxBy(t => t.Value).Key;
            winningTeam.WinsCount++;
            Console.WriteLine($"Ввыиграла команда: {winningTeam.Name}!\n");
            return winningTeam;
        }
    }
}
