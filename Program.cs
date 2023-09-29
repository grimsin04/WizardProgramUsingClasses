using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Wizard_Madness
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " you have ran out of spells to cast!");
            }
            
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Shadow Wizard From the Shadow Government", "Petrolium");
            
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.Meditate();
            
            Wizard wizard02 = new Wizard("Chief Sosa", "Gasoline Extractum");

            wizard02.CastSpell();
            wizard02.CastSpell();
            wizard02.Meditate();
            wizard02.CastSpell();
            wizard02.CastSpell();
            wizard02.Meditate();
            

            Console.WriteLine("There are a total of " + Wizard.Count + " wizards in this foresaken land!");

            Console.ReadKey();
        }
    }
}