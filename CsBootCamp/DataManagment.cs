using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace _22PMbootcamp
{
    public static class DataManagment
    {
        public static void SavePlayerData(Player p)
        {
            string jsP = JsonSerializer.Serialize(p);
            Console.WriteLine("Serializing {0}", jsP);
            string fileName = "e:\\vgd\\Marcus\\playerdata\\Pmplayer.txt";
            File.WriteAllText(fileName, jsP);
            Console.WriteLine("Player data saved");
        }

        public static Player LoadPlayerData(Player p)
        {
            string fileName = "e:\\vgd\\Marcus\\playerdata\\Pmplayer.txt";
            string jsP = File.ReadAllText(fileName);
            Player x = JsonSerializer.Deserialize<Player>(jsP);
            Console.WriteLine("Player data restored.");
            return x;
        }
    }
}
