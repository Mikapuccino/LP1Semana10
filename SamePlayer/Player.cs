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

        public override PlayerType GetHashCode()
        {
            return type;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj is Player)
            {
                return (obj.name == this.name) && (obj.type == this.type);
            }
        }
    }
}