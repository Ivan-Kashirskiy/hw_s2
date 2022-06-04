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
        public RadarHead()
        {
            scaningDistance = 18;
            visionDistance = 8;
            pointCost = 3;
        }

    }
}
