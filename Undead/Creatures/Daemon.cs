using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Daemon:Abstract
    {
        public override string Scream()
        {
            return "Aarrarraaa!";
        }
        public override string Ability()
        {
            return "I can desire any wish you have, but you should give me your soul!!!";
        }
    }
}
