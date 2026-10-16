using GameCORE.Armament;
using GameCORE.Characters;
using GameCORE.Combat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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
