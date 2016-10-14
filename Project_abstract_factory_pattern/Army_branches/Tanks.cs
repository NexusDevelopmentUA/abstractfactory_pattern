using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_abstract_factory_pattern.Army_branches
{
    abstract class Tanks
    {
        abstract public void defeating_paratroopers();
        abstract public void destroyed_by_artilery();

        public string victory = "Enemy paratroopers were destroyed!";
        public string defeat = "Your tanks were defeated!";
    }
}
