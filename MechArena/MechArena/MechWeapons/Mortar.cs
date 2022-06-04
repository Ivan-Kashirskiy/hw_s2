using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Mortar : MechWeapon
    {
        public Mortar()
        {
            type = WeaponType.Heavy;
            damage = 150;
            armorPenetration = 3;
            distance = 20;
            pointCost = 10;
        }

    }
}
