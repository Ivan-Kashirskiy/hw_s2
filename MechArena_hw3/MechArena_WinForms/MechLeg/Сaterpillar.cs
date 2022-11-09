using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Сaterpillar : MechLeg
    {
        static internal int pointCost = 4;
        public Сaterpillar()
        {
            speedOnGrass = 5;
            speedOnRock = 3;
            speedOnMud = 4;
            speedOnForest = 2;
           // pointCost = 4;
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }

    }
}
