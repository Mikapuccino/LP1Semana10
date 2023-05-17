using System;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(Tank, "Ana");
            setOfPlayers.Add(Slayer, "Paulo");
            setOfPlayers.Add(Tank, "Ana");

            foreach (Player p in setOfPlayers)
                Console.WriteLine($"{p.Name} is a {p.Type}");
        }
    }
}
