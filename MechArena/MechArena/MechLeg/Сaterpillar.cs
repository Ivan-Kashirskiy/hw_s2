using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Сaterpillar : MechLeg
    {
        public Сaterpillar()
        {
            speedOnGrass = 5;
            speedOnRock = 3;
            speedOnMud = 4;
            speedOnForest = 2;
            pointCost = 4;
        }

    }
}
