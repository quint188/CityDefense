using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Media;
using System.Linq;

namespace CityDefense.Engine
{
    class FileSystem
    {
        public static Dictionary<string, Image> LoadFrames(string path)
        {
            return File.ReadAllLines(path)
             .Select(line => line.Split('|'))
             .ToDictionary(parts => parts[0], parts => Image.FromFile(parts[1]));
        }
        public static Dictionary<string, SoundPlayer> LoadSound(string path)
        {
            return File.ReadAllLines(path)
              .Select(line => line.Split('|'))
              .ToDictionary(parts => parts[0], parts => new SoundPlayer(parts[1]));
        }
    }
}