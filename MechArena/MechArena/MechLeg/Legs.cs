using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Legs : MechLeg
    {
        public Legs()
        {
            speedOnGrass = 4;
            speedOnRock = 4;
            speedOnMud = 4;
            speedOnForest = 3;
            pointCost = 5;
        }

    }
}
