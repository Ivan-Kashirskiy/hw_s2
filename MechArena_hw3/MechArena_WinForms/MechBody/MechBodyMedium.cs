using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class MechBodyMedium : MechBody
    {
        static internal int pointCost = 7;
        public MechBodyMedium()
        {
            armor = 3;
            maxHull = 400;          
            name = "Medium armor";
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }

    }
}
