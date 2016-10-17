using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Army_branches;
using Project_abstract_factory_pattern.Ukrainian_army_;
namespace Project_abstract_factory_pattern.Factories
{
    class Ukrainian_army : Army_factory
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
}
