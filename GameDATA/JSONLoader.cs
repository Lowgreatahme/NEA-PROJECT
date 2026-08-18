using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GameDATA
{
    public class JSONLoader
    {
        const string filepath = "GameDATA/JSONFiles/EnemyData.json";
        static readonly string json = File.ReadAllText(filepath);
        public static readonly JObject data = JObject.Parse(json);
        }
    
}
