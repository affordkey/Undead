using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undead.Creatures;

namespace Undead.Helpers
{
    public static class CreaturesList
    {
        public static List<Type> CreatureList {
            get
            {
                return new List<Type>
                {
                    typeof(Butcher),
                    typeof(Daemon),
                    typeof(ShapeShifter),
                    typeof(Skeleton),
                    typeof(Vampire),
                    typeof(Vurdalac),
                    typeof(Werewolf),
                    typeof(Zombie)
                };
            } }
    }
}
