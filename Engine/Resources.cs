using System.Collections.Generic;
using System.Drawing;
using System.Media;
using CityDefense.Engine;

namespace CityDefense
{
    class Resources
    {
        static Dictionary<string, Image> frames = new Dictionary<string, Image>();
        static Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>();
        static public void InitializationResources() => (frames, sounds) = (FileSystem.LoadFrames("Res.int"), FileSystem.LoadSound("Sound.int"));
        static public Image GetFrame(string key) => frames[key];
        static public SoundPlayer GetSound(string key) => sounds[key];
    }
}