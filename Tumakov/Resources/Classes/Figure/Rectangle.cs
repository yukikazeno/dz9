namespace Tumakov
{
    internal class Rectangle : Point, IAreaCalculable
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double x, double y, double width, double height, string color, bool isVisible = true)
        : base(x, y, color, isVisible)
        {
            Width = width > 0 ? width : 1.0;
            Height = height > 0 ? height : 1.0;
        }

        public Rectangle(double x, double y, double width, double height) : base(x, y, "Black", true)
        {
            Width = width > 0 ? width : 1.0;
            Height = height > 0 ? height : 1.0;
        }

        public Rectangle(double width, double height) : this(0.0, 0.0, width, height, "Black", true) { }

        public Rectangle() : this(0.0, 0.0, 1.0, 1.0) { }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Ширина: {Width}, Высота: {Height}");
        }
    }
}
