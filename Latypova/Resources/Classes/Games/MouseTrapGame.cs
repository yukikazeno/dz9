namespace Latypova
{
    public class MouseTrapGame : IGame
    {
        public string Name => "Мышеловка";

        VictoryConditions beachConditions = new VictoryConditions(4, 2, 4, 3, 0);

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
