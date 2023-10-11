using System;

namespace CityDefense.Engine
{
    class Time
    {
        private static int frames = 0;
        private static int interval;

        public static void SetInterval(int value) => interval = value;
        public static void Frame_Tick(object sender, EventArgs e) => frames++;
        public static double GetSeconds() => frames * interval / 1000;
        public static int DeltaTime => interval;
    }
}