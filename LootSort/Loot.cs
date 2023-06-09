using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot: IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        public int CompareTo(Loot other)
        {
            if (other == null) return 1;

            if ((this.Kind != other.Kind) && (this.Value != other.Value))
            {
                string firstKind = this.Kind.ToString();
                string secondKind = other.Kind.ToString();
                return firstKind.CompareTo(secondKind);
            }

            else if ((this.Kind == other.Kind) && (this.Value != other.Value))
            {
                return (int)(other.Value - this.Value);
            }
            
            else return this.Description.CompareTo(other.Description);
        }

        public override int GetHashCode()
        {
            return this.Kind.GetHashCode() ^ 
            this.Value.GetHashCode() ^ 
            this.Description.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            Loot otherLoot = obj as Loot;
            
            if (otherLoot == null)
            {
                return false;
            }
            else
            {
                return (otherLoot.Kind == this.Kind) &&
                (otherLoot.Value == this.Value) &&
                (otherLoot.Description == this.Description);
            }
        }
    }
}