using System;
using System.Drawing;

namespace CityDefense.Game
{
    class Plane : Transform, IGameObject
    {
        int speed;        
        public Plane(int x, int y, int sx, int sy, int speed, int offsetSpeed)
        {
            Random random = new Random();
            SetPosition(new Vector(x, y + random.Next(-sy,sy)));
            SetSize(new Vector(sx, sy));            
            this.speed = speed + random.Next(-offsetSpeed,offsetSpeed);            
        }
        public void Draw(Graphics g)
        {
            AddPosition(new Vector(speed, 0));

            speed = (Position.X > Render.Resolution.X - Size.X || Position.X < 0) ? -speed : speed;

            var frame = speed > 0 ? Resources.GetFrame("PlaneRight") : Resources.GetFrame("PlaneLeft");

            g.DrawImage(frame, Position.X, Position.Y, Size.X, Size.Y);
        }
    }
}