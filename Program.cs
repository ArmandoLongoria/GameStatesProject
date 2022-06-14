using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            MatchData data = new MatchData(100, 5);
            PlayerProfile player = new PlayerProfile("KillzAllDay", 105264, 1, 300, 240);
            Console.WriteLine(data);
            Console.WriteLine(player);
            player.UpdateStats(data);
            Console.WriteLine(player);
            Console.ReadKey();
        }
    }
}
