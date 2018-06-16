using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Vurdalac:AbstractUndead
    {
        public override string Scream()
        {
            return "Uawha!";
        }
        public override string Ability()
        {
            return "I can eat liver!!!";
        }
    }
}
