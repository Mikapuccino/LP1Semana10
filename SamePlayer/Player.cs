using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamePlayer
{
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public Player(PlayerType type, string name)
        {
            Type = type;
            Name = name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Type.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            Player otherPlayer = obj as Player;
            
            if (otherPlayer == null)
            {
                return false;
            }
            else
            {
                return (otherPlayer.Name == this.Name) &&
                (otherPlayer.Type == this.Type);
            }
        }
    }
}