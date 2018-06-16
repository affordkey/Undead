using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undead.Helpers
{
    public static class RandomRank
    {
        public static List<string> Ranks = new List<string>
        {
            "Cadet",
            "Private",
            "Corporal",
            "Sergeant",
            "Warrant Officer",
            "Second Lieutenant",
            "First Lieutenant",
            "Captain",
            "Major",
            "Lieutenant Colonel",
            "Colonel",
            "Brigadier General",
            "Major General",
            "Lieutenant General",
            "General of Army"
        };
        public static string GetRandomRank()
        {
            Random random = new Random();
            return Ranks[random.Next(Ranks.Count)];
        }
    }
}
