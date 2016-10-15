using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_abstract_factory_pattern.Army_branches;

namespace Project_abstract_factory_pattern.Ukrainian_army_
{
    class Ukrainian_Artilery : Artilery
    {
        public override void defeating_tanks()
        {
            Console.WriteLine(victory);
        }
        public override void destroyed_by_paratroopers()
        {
            Console.WriteLine(defeat);
        }
    }
}
