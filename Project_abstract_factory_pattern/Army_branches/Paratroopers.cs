using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_abstract_factory_pattern.Army_branches
{
    abstract class Paratroopers
    {
        abstract public void defeating_artilery();
        abstract public void destroyed_by_tanks();

        public string victory = "Enemy artilery was destroyed!";
        public string defeat = "Your paratroopers were defeated!";
    }
}
