namespace Latypova
{
    public class Player
    {
        Random rnd = new Random();
        public string Name { get; }
        private int _speed { get; }
        private int _strength { get; }
        private int _stamina { get; }
        private int _skill { get; }
        private int _imagination { get; }

        public int Speed => _speed;
        public int Strength => _strength;
        public int Stamina => _stamina;
        public int Skill => _skill;
        public int Imagination => _imagination;

        public Player(string name)
        {
            Name = name;
            _speed = rnd.Next(1, 5);
            _strength = rnd.Next(1, 5);
            _stamina = rnd.Next(1, 5);
            _skill = rnd.Next(1, 5);
            _imagination = rnd.Next(1, 5);
        }
    }
}
