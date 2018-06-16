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
        public static void PrintInfo(Abstract creature)
        {
            Console.WriteLine("Name: {0},\nRank: {1},\nHealth: {2},\nMana: {3},\nPower: {4},\nScream: {5},\nAbility: {6};",
                creature.Name, creature.Rank, creature.Health,
                creature.Mana, creature.Power, creature.Scream(),
                creature.Ability());
        }
        static void Main(string[] args)
        {
            List<Abstract> creatures = new List<Abstract>();
            for (int i = 0; i < 8; i++)
            {
                foreach (var type in CreaturesList.CreatureList)
                {
                    creatures.Add((Abstract)Activator.CreateInstance(type));
                    creatures.Add((Abstract)Activator.CreateInstance(type));
                }
            }
            foreach (var creature in creatures)
                PrintInfo(creature);
            Console.ReadKey();
        }

    }
}