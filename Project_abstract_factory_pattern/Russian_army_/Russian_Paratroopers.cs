using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Army_branches;

namespace Project_abstract_factory_pattern.Russian_Army_
{
    class Russian_Paratroopers : Paratroopers
    {
        public override void defeating_artilery()
        {
            Console.WriteLine(victory);
        }

        public override void destroyed_by_tanks()
        {
            Console.WriteLine(defeat);
        }
    }
}
