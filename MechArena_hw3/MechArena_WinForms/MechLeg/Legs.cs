﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Legs : MechLeg
    {
        static internal int pointCost = 5;
        public Legs()
        {
            speedOnGrass = 4;
            speedOnRock = 4;
            speedOnMud = 4;
            speedOnForest = 4;
            name = "Legs";
        }


        internal static int GetPointCost()
        {
            return pointCost;
        }
    }
}
