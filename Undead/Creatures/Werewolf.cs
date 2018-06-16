using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Werewolf:AbstractUndead
    {
        public override string Scream()
        {
            return "Auuuuuu!";
        }
        public override string Ability()
        {
            return "I can transform to big wolf from a human";
        }
    }
}
