using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undead.Creatures;
using Undead.Helpers;

namespace Undead
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractUndead> creatures = new List<AbstractUndead>();
            for (int i = 0; i < 8; i++)
            {
                foreach (var type in CreaturesList.CreatureList)
                {
                    creatures.Add((AbstractUndead)Activator.CreateInstance(type));
                    creatures.Add((AbstractUndead)Activator.CreateInstance(type));
                }
            }
            foreach (var creature in creatures)
                Console.WriteLine(creature.InfoInString());
            Console.ReadKey();
        }

    }
}