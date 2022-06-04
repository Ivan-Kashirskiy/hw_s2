using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Wheels : MechLeg
    {
        public Wheels()
        {
            speedOnGrass = 7;
            speedOnRock = 4;
            speedOnMud = 2;
            speedOnForest = 2;
            pointCost = 3;
        }

    }
}
