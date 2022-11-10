using Mech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class RadarHead : MechHead
    {

        static internal int pointCost = 3;
        public RadarHead()
        {
            scaningDistance = 18;
            visionDistance = 8;
            name = "Radar";
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }

    }
}
