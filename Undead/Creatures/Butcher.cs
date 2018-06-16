using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Creatures
{
    public class Butcher:Abstract
    {
        public override string Scream()
        {
            return "FfffffShik!";
        }
        public override string Ability()
        {
            return "I can eat meat and consist of meat and I can eat you!!!";
        }
    }
}
