using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Laser : MechWeapon
    {
        static internal int pointCost = 5;
        public Laser()
        {
            type = WeaponType.Medium;
            damage = 100;
            armorPenetration = 5;
            distance = 8;
            //pointCost = 5;
        }
        internal static int GetPointCost()
        {
            return pointCost;
        }
    }
}
