using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Skeleton : AbstractUndead
    {
        public override string Scream()
        {
            return "Zzzzzzz!";
        }
        public override string Ability()
        {
            return "I can blow to the bones!!!";
        }
    } 
}
