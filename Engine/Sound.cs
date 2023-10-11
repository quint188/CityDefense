namespace CityDefense.Engine
{
    class Sound
    {
        public static void Play(string key) => Resources.GetSound(key)?.Play();
    }
}