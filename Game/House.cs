using System.Drawing;

namespace CityDefense.Game
{
    class House : Transform, IGameObject
    {
        public bool IsBreak { get; private set; } = false;

        public House(int x, int y, int sx, int sy)
        {
            SetPosition(new Vector(x, y));
            SetSize(new Vector(sx, sy));
        }
        public void Break() => IsBreak = true;
        public void Draw(Graphics g) => g.DrawImage(IsBreak ? Resources.GetFrame("HouseBreak") : Resources.GetFrame("House"),
        Position.X, Position.Y, Size.X, Size.Y);
    }
}