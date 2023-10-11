using System.Drawing;

namespace CityDefense.Engine
{
    class GameOver
    {
        static public bool isGameOver = false;
        static public void DrawGameOverScreen(Graphics g)=>
        g.DrawString($"GAME OVER\nTime: {Time.GetSeconds()} seconds", new Font("Stencil", 25), Brushes.Red, new PointF(Render.Resolution.X / 2 - 100, Render.Resolution.Y / 2 - 100));
    }
}