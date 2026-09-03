using GameCORE.Characters;
using GameDATA;
using Newtonsoft.Json.Linq;
using static GameDATA.JSONLoader;
using static System.Runtime.InteropServices.JavaScript.JSType;



JSONLoader Loader  = new JSONLoader();
List<Enemy> enemyList = Loader.LoadEnemies("EnemyData.json");

foreach  (Enemy enemy in enemyList)
{
    Console.WriteLine(enemy.Name);
    Console.WriteLine(enemy.IsBoss);
    Console.WriteLine();
}