using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class MechBodyLight : MechBody
    {
        static internal int pointCost = 5;
        public MechBodyLight()
        {
            armor = 1;
            maxHull = 300;
            pointCost = 5;
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }

    }
}
