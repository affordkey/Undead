using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Vampire : Abstract
    {
        public override string Scream()
        {
            return "Aaaaaaaa!";
        }
        public override string Ability()
        {
            return "I can suck blood and transform to bat!!!";
        }
    }
}
