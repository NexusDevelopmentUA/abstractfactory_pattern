using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Army_branches;
using Project_abstract_factory_pattern.Factories;

namespace Project_abstract_factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Army ukrainians = new Army();
            Army russians = new Army();
            
            char[] armies = new char[2];

            Console.WriteLine("Ukrainian general, choose your armies branch to move! Type A for artilery, T for tanks and P for paratroopers.");
            armies[0] = Char.Parse(Console.ReadLine());
            Console.WriteLine("Russian general, choose your armies branch to move! Type A for artilery, T for tanks and P for paratroopers.");
            armies[1] = Char.Parse(Console.ReadLine());

            try
            {
                if ((armies[0] == 'A' && armies[1] == 'T') || (armies[0] == 'T' && armies[1] == 'P') || (armies[0] == 'P' && armies[1] == 'A'))
                {
                    ukrainians.Army_won(new Ukrainian_army(), armies[0]);
                    Console.WriteLine("Report from Ukrainian HQ: " + ukrainians.Victory());
                    russians.Army_defeated(new Russian_army(), armies[1]);
                    Console.WriteLine("Report from Russian HQ: " + russians.Defeat());
                }
                else
                {
                    ukrainians.Army_defeated(new Ukrainian_army(), armies[0]);
                    Console.WriteLine("Report from Ukrainian HQ: " + ukrainians.Defeat());
                    russians.Army_won(new Russian_army(), armies[1]);
                    Console.WriteLine("Report from Russian HQ: " + russians.Victory());
                }
                
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    //Client class
    class Army
    {
        private Paratroopers paratroopers;
        private Tanks tanks;
        private Artilery artilery;
        private string output;

        public void Army_won(Army_factory factory, char army_branch)
        {
            switch (army_branch)
            {
                case 'A':
                    {
                        artilery = factory.ArtileryVictory();
                        output = artilery.victory;
                        break;
                    }
                case 'P':
                    {
                        paratroopers = factory.ParatroopersVictory();
                        output = paratroopers.victory;
                        break;
                    }
                case 'T':
                    {
                        tanks = factory.TanksVictory();
                        output = tanks.victory;
                        break;
                    }
            }
        }

        public void Army_defeated(Army_factory factory, char army_branch)
        {
            switch (army_branch)
            {
                case 'A':
                    {
                        artilery = factory.ArtileryDefeat();
                        output = artilery.defeat;
                        break;
                    }
                case 'P':
                    {
                        paratroopers = factory.ParatroopersDefeat();
                        output = paratroopers.defeat;
                        break;
                    }
                case 'T':
                    {
                        tanks = factory.TanksDefeat();
                        output = tanks.defeat;
                        break;
                    }
            }
        }

        public string Victory()
        {
            return output;
        }
        
        public string Defeat()
        {
            return output;
        }

    }
}
