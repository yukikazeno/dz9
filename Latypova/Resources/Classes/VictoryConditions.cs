namespace Latypova
{
    public class VictoryConditions
    {
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

        public VictoryConditions(int speed, int strength, int stamina, int skill, int imagination)
        {
            _speed = speed;
            _strength = strength;
            _stamina = stamina;
            _skill = skill;
            _imagination = imagination;
        }
    }
}
