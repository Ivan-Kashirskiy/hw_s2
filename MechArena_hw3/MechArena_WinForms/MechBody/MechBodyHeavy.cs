using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech 
{
    internal class MechBodyHeavy : MechBody
    {
        static internal int pointCost = 10;
        public MechBodyHeavy()
        {
            armor = 5;
            maxHull = 500;
            //pointCost = 10;
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }

    }
}
