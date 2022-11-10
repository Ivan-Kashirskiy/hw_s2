using Mech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class SniperHead : MechHead
    {
        static internal int pointCost = 3;
        public SniperHead()
        {
            scaningDistance = 15;
            visionDistance = 10;
            name = "Visor";
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }
    }
}
