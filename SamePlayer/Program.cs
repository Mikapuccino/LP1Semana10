using System;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            Player ana1 = new Player(PlayerType.Tank, "Ana");
            Player paulo = new Player(PlayerType.Slayer, "Paulo");
            Player ana2 = new Player(PlayerType.Tank, "Ana");

            setOfPlayers.Add(ana1);
            setOfPlayers.Add(paulo);
            setOfPlayers.Add(ana2);

            foreach (Player p in setOfPlayers)
                Console.WriteLine($"{p.Name} is a {p.Type}");
        }
    }
}
