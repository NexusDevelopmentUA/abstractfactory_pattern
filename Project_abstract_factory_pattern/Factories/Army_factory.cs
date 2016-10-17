using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Army_branches;

namespace Project_abstract_factory_pattern.Factories
{
    abstract class Army_factory
    {
        public abstract Paratroopers ParatroopersVictory();
        public abstract Paratroopers ParatroopersDefeat();
        public abstract Tanks TanksVictory();
        public abstract Tanks TanksDefeat();
        public abstract Artilery ArtileryVictory();
        public abstract Artilery ArtileryDefeat();
    }
}
