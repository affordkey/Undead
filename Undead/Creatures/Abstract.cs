using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public abstract class Abstract
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int Power { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
        public Abstract()
        {
            Name = this.ToString().Split('.').Last();
            Random random = new Random();
            this.Health = 50 + random.Next(50);
            this.Mana = 60+ random.Next(40);
            this.Power = 10+random.Next(90);
            Rank = Helpers.RandomRank.GetRandomRank();
        }
        public virtual string Scream()
        {
            return Name;
        }
        public virtual string Ability()
        {
            return "BaseAbility";
        }
    }
}
