using GameCORE.Armament;
using GameCORE.Characters;
using GameCORE.Combat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace GameDATA
{
    public class JSONLoader
    {
        public List<Enemy> LoadEnemies(string path)
        {
            string json = File.ReadAllText(path);
            List<Enemy> enemies = JsonConvert.DeserializeObject<List<Enemy>>(json);
            return enemies;
        }
    }
}
