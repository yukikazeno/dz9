namespace Tumakov
{
    internal class Circle : Point, IAreaCalculable
    {
        public double _radius { get; private set; }

        public Circle(double x, double y, double radius, string color = "Black", bool isVisible = true) : base(x, y, color, isVisible)
        {
            _radius = radius;
        }

        public Circle(string color = "Black", bool isVisible = true) : this(0.0, 0.0, 1.0, color, isVisible) { }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Радиус: {_radius}");
        }
    }
}
