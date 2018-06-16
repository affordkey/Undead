using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    abstract class Abstract
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int Power { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
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
