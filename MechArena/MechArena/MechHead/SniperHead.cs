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
        public SniperHead()
        {
            scaningDistance = 15;
            visionDistance = 10;
            pointCost = 3;
        }
    }
}
