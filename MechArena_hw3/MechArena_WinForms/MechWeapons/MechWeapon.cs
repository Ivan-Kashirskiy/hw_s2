using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    enum WeaponType {Light, Medium, Heavy};
    internal class MechWeapon : MechPart
    {
        internal WeaponType type;
        internal int damage;
        internal int armorPenetration;
        internal int distance;
    }

}
