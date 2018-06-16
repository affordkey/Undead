using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Zombie: Abstract
    {
        public Zombie()
        {
            Name = "Zombie";
            Rank = Helpers.RandomRank.GetRandomRank();
        }
        public override string Scream()
        {
            return "Uuuuuuu!!!!";
        }
        public override string Ability()
        {
            return "I can eat some brains!!!)))";
        }
    }
}
