using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Army_branches;
using Project_abstract_factory_pattern.Russian_Army_;
using Project_abstract_factory_pattern.Ukrainian_army_;

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
                    russians.Army_defeated(new Russian_army(), armies[1]);
                }
                else
                {
                    ukrainians.Army_defeated(new Ukrainian_army(), armies[0]);
                    russians.Army_won(new Russian_army(), armies[1]);
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
    //Army branches

    /*abstract class Paratroopers
    {
        abstract public void defeating_artilery();
        abstract public void destroyed_by_tanks();

        public string victory = "Enemy artilery was destroyed!";
        public string defeat = "Your paratroopers were defeated!";
    }*/
    //abstract class Tanks
    //{
    //    abstract public void defeating_paratroopers();
    //    abstract public void destroyed_by_artilery();

    //    public string victory = "Enemy paratroopers were destroyed!";
    //    public string defeat = "Your tanks were defeated!";
    //}
    //abstract class Artilery
    //{
    //    abstract public void defeating_panzers();
    //    abstract public void destroyed_by_paratroopers();

    //    public string victory = "Enemy tanks were destroyed!";
    //    public string defeat = "Your artilery was defeated!";
    //}

    //Ukrainian army

    //class Ukrainian_paratroopers:Paratroopers
    //{
    //    public override void defeating_artilery()
    //    {
    //        Console.WriteLine(victory);
    //    }

    //    public override void destroyed_by_tanks()
    //    {
    //        Console.WriteLine(defeat);
    //    }
    //}
    //class Ukrainian_Tanks:Tanks
    //{
    //    public override void defeating_paratroopers()
    //    {
    //        Console.WriteLine(victory);
    //    }

    //    public override void destroyed_by_artilery()
    //    {
    //        Console.WriteLine(defeat);
    //    }
    //}
    //class Ukrainian_Artilery:Artilery
    //{
    //    public override void defeating_panzers()
    //    {
    //        Console.WriteLine(victory);
    //    }

    //    public override void destroyed_by_paratroopers()
    //    {
    //        Console.WriteLine(defeat);
    //    }
    //}
    
    //Russian army

    //class Russian_paratroopers:Paratroopers
    //{
    //    public override void defeating_artilery()
    //    {
    //        Console.WriteLine(victory);
    //    }

    //    public override void destroyed_by_tanks()
    //    {
    //        Console.WriteLine(defeat);
    //    }
    //}
    //class Russian_Tanks : Tanks
    //{
    //    public override void defeating_paratroopers()
    //    {
    //        Console.WriteLine(victory);
    //    }

    //    public override void destroyed_by_artilery()
    //    {
    //        Console.WriteLine(defeat);
    //    }
    //}
    //class Russian_Artilery : Artilery
    //{
    //    public override void defeating_panzers()
    //    {
    //        Console.WriteLine(victory);
    //    }

    //    public override void destroyed_by_paratroopers()
    //    {
    //        Console.WriteLine(defeat);
    //    }
    //}

    //Factories

    abstract class Army_factory
    {
        public abstract Paratroopers ParatroopersVictory();
        public abstract Paratroopers ParatroopersDefeat();
        public abstract Tanks TanksVictory();
        public abstract Tanks TanksDefeat();
        public abstract Artilery ArtileryVictory();
        public abstract Artilery ArtileryDefeat();
    }
    class Ukrainian_army:Army_factory
    {
        public override Paratroopers ParatroopersVictory()
        {
            return new Ukrainian_Paratroopers();
        }
        public override Paratroopers ParatroopersDefeat()
        {
            return new Ukrainian_Paratroopers();
        }
        public override Tanks TanksVictory()
        {
            return new Ukrainian_Tanks();
        }
        public override Tanks TanksDefeat()
        {
            return new Ukrainian_Tanks();
        }
        public override Artilery ArtileryVictory()
        {
            return new Ukrainian_Artilery();
        }
        public override Artilery ArtileryDefeat()
        {
            return new Ukrainian_Artilery();
        }
    }
    class Russian_army : Army_factory
    {
        public override Paratroopers ParatroopersVictory()
        {
            return new Russian_paratroopers();
        }
        public override Paratroopers ParatroopersDefeat()
        {
            return new Russian_paratroopers();
        }
        public override Tanks TanksVictory()
        {
            return new Russian_Tanks();
        }
        public override Tanks TanksDefeat()
        {
            return new Russian_Tanks();
        }
        public override Artilery ArtileryVictory()
        {
            return new Russian_Artilery();
        }
        public override Artilery ArtileryDefeat()
        {
            return new Russian_Artilery();
        }
    }
    //Client class
    class Army
    {
        private Paratroopers paratroopers;
        private Tanks tanks;
        private Artilery artilery;

        public void Army_won(Army_factory factory, char army_branch)
        {
            switch (army_branch)
            {
                case 'A':
                    {
                        artilery = factory.ArtileryVictory();
                        break;
                    }
                case 'P':
                    {
                        paratroopers = factory.ParatroopersVictory();
                        break;
                    }
                case 'T':
                    {
                        tanks = factory.TanksVictory();
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
                        break;
                    }
                case 'P':
                    {
                        paratroopers = factory.ParatroopersDefeat();
                        break;
                    }
                case 'T':
                    {
                        tanks = factory.TanksDefeat();
                        break;
                    }
            }
        }
        public void Victory()
        {
            artilery.
        }

    }
}
