namespace Tumakov
{
    internal interface IFigureActions
    {
        public void MoveHorizontal(double dx);
        public void MoveVertical(double dy);
        public void ChangeColor(string newColor);
        public void PrintInfo();
    }
}
