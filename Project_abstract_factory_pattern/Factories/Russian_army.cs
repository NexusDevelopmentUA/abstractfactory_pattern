using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Russian_Army_;
using Project_abstract_factory_pattern.Army_branches;

namespace Project_abstract_factory_pattern.Factories
{
    class Russian_army : Army_factory
    {
        public override Paratroopers ParatroopersVictory()
        {
            return new Russian_Paratroopers();
        }
        public override Paratroopers ParatroopersDefeat()
        {
            return new Russian_Paratroopers();
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
}
