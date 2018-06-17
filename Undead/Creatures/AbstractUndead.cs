using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public abstract class AbstractUndead
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int Power { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
        public AbstractUndead()
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
        public string InfoInString()
        {
            return String.Format("Name: {0},\nRank: {1},\nHealth: {2},\nMana: {3},\nPower: {4},\nScream: {5},\nAbility: {6};",
                Name, Rank, Health,
                Mana, Power, Scream(),
                Ability());
        }
    }
}
