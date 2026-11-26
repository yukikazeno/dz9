namespace Tumakov
{
    public class Point : Figure
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y, string color = "Black", bool isVisible = true)
        : base(color, isVisible)
        {
            X = x;
            Y = y;
        }

        public Point(string color = "Black", bool isVisible = true) : this(0.0, 0.0, color, isVisible){}

        public override void MoveHorizontal(double dx)
        {
            X += dx;
        }

        public override void MoveVertical(double dy)
        {
            Y += dy;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Координаты: ({X}, {Y})");
        }
    }
}
