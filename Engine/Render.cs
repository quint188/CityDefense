using System.Drawing;
using CityDefense.Engine;

namespace CityDefense
{
    class Render
    {        
        static Vector resolution;
        static IScene scene;
        public static void SetResolution(int x, int y) => resolution = new Vector(x, y);
        public static void SetScene(IScene customScene) => scene = customScene;
        public static Image DrawFrame()
        {
            using (var bitmap = new Bitmap(resolution.X, resolution.Y))
            using (var g = Graphics.FromImage(bitmap))
            {
                scene.DrawBack(g, resolution.X, resolution.Y);
                scene.DrawObjects(g);
                if (GameOver.isGameOver)
                    GameOver.DrawGameOverScreen(g);
                return new Bitmap(bitmap);
            }
        }
        public static Vector Resolution => resolution;
    }
}