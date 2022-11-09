using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class AutoCanon : MechWeapon
    {
        static internal int pointCost = 6;
        public AutoCanon()
        {
            type = WeaponType.Medium;
            damage = 120;
            armorPenetration = 3;
            distance = 12;
            //pointCost = 6;
        }

        internal static int GetPointCost()
        {
            return pointCost;
        }

    }
}
