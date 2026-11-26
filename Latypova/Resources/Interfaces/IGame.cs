namespace Latypova
{
    public interface IGame
    {
        public string Name { get; }

        public Team PlayGame(List<Team> teams);
    }
}
