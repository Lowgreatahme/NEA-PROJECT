using GameCORE.Characters;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;

namespace GameDATA
{
    public class JSONLoader
    {
        public List<Enemy> LoadEnemies(string path)
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Enemy>>(json);
        }
    }
}
