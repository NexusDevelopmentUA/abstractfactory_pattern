using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_abstract_factory_pattern.Army_branches
{
    abstract class Artilery
    {
        abstract public void defeating_panzers();
        abstract public void destroyed_by_paratroopers();

        public string victory = "Enemy tanks were destroyed!";
        public string defeat = "Your artilery was defeated!";
    }
}
