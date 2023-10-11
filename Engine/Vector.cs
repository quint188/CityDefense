namespace CityDefense
{
    class Vector
    {
        public int X { get; }
        public int Y { get; }

        public Vector() : this(0, 0) {}

        public Vector(int x, int y) => (X, Y) = (x, y);
        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.X - b.X, a.Y - b.Y);
    }
}