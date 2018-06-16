using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Zombie: AbstractUndead
    {
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
