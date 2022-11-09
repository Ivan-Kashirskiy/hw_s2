using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class MechLeg : MechPart
    {
        protected int speedOnGrass;
        protected int speedOnRock;
        protected int speedOnMud;
        protected int speedOnForest;


        internal int getSpeedOnTerrain(GameMode.terrain terrainType)
        {
            if (terrainType == GameMode.terrain.grass)
                return speedOnGrass;
            if (terrainType == GameMode.terrain.rock)
                return speedOnRock;
            if (terrainType == GameMode.terrain.mud)
                return speedOnMud;
            if (terrainType == GameMode.terrain.forest)
                return speedOnForest;

            return 0;
        }
    }
}
