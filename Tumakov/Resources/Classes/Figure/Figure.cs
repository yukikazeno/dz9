namespace Tumakov
{
    public abstract class Figure : IFigureActions
    {
        public string Color { get; protected set; }
        public bool IsVisible { get; set; }

        protected Figure(string color = "Black", bool isVisible = true)
        {
            Color = color;
            IsVisible = isVisible;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor; 
        }

        public void ChangeColor(int r, int g, int b) 
        { 
            Color = $"RGB({r}, {g}, {b})"; 
        }

        public bool GetVisibility() 
        { 
            return IsVisible; 
        }

        public abstract void MoveHorizontal(double dx);
        public abstract void MoveVertical(double dy);

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Цвет: {Color}, Видимость: {(IsVisible ? "Да" : "Нет")}");
        }
    }
}
