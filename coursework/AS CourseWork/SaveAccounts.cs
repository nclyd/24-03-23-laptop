using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AS_CourseWork
{
    class SaveAccounts
    {
        public static void AppendPlayer(Player player)
        {
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();

            sw = File.Open("Players.bin", FileMode.Append);
            bf.Serialize(sw, player);
            sw.Close();
            sw.Dispose();

        }

        public static List<Player> FetchPlayer()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            List<Player> players = new List<Player>();

            sr = File.OpenRead("Players.bin");

            while(sr.Position < sr.Length)
            {
                players.Add((Player)bf.Deserialize(sr));
            }
            sr.Close();
            sr.Dispose();

            return players;
        }
       
    }
}
