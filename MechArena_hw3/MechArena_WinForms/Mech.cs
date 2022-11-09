using Mech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mech
{
    internal class Mech
    {
        string name;
        MechHead head;
        MechBody body;
        MechLeg leg;
        MechWeapon weapon;

        int actionPointsCost;

        int movePoints;
        int X;
        int Y;

        int cost = 0;

        public string getName()
        {
            return name;
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public void put(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int getMovePoints()
        {
            return movePoints;
        }

        public int getactionPointsCost()
        {
            return actionPointsCost;
        }

        public int getCurHull()
        {
            return body.curHull;
        }

        public int getMaxHull()
        {
            return body.maxHull;
        }

        public int getArmor()
        {
            return body.armor;
        }

        public int getSpeedByTerrain(GameMode.terrain terrainType)
        {
            return leg.getSpeedOnTerrain(terrainType);
        }

        public int getWeaponRange()
        {
            return weapon.distance;
        }

        public int getWeaponDamage()
        {
            return weapon.damage;
        }

        public void resiveDamage(int d)
        {
            body.curHull -= d;
        }

        public int getScaningDistance()
        {
            return head.scaningDistance;
        }

        public int getVisionDistance()
        {
            return head.visionDistance;
        }

        internal int Cost()
        {

            return cost;
        }

        protected int maxHull;
        protected int curHull;
        protected int armor;

        bool isInRange(int x1, int x2, int a1, int a2)
        {
            if ((a1 <= x1) && (x1 <= a2))
                if ((a1 <= x2) && (x2 <= a2))
                            return true;
            return false;
        }

        
        public bool move(int x, int y, GameMode.Field grid, int movePoints)
        {
            bool path_found = false;
            int fs = GameMode.Field.getFieldSize();

            bool[,] visited = new bool[fs, fs];
            for (int i = 0; i < fs; i++)
                for (int j = 0; j < fs; j++)
                    visited[i, j] = false;

            int xStart = System.Math.Min(X, x);
            int xFinish = System.Math.Max(X, x);

            int yStart = System.Math.Min(Y, y);
            int yFinish = System.Math.Max(Y, y);

            int mp = 0;

            for (int i = xStart; i < xFinish; i++)
                mp += 10 - getSpeedByTerrain(grid.field[i, Y]);

            for (int i = yStart; i < yFinish; i++)
                mp += 10 - getSpeedByTerrain(grid.field[x, i]);

            if (mp <= movePoints)
            {
                X = x;
                Y = y;

                movePoints = movePoints - mp;
                return true;               
            }
            return false;
        }

        public int distToEnotherMech(Mech mech)
        {
            return (mech.X - X) * (mech.X - X) + (mech.Y - Y) * (mech.Y - Y);
        }


        void attack(Mech enemy)
        {
            if (distToEnotherMech(enemy) > getWeaponRange() * getWeaponRange())
                enemy.resiveDamage( getWeaponDamage() );
        }


        public void scan(List<Mech> EmemyMech, List<Mech> visibleMech, List<Mech> detectedMech)
        {

            foreach (Mech enemy in EmemyMech)
            {
                if (distToEnotherMech(enemy) <= getVisionDistance() * getVisionDistance())
                    visibleMech.Add(enemy);
                else
                {
                    if (distToEnotherMech(enemy) <= getScaningDistance() * getScaningDistance())
                        detectedMech.Add(enemy);
                }
            };
        }


        public void printMechInfo()
        {
            Console.WriteLine("MechInfo:");
            Console.WriteLine("Head:  " + head.GetType());
            Console.WriteLine("Body: " + body.GetType());
            Console.WriteLine("Legs: " + leg.GetType());
            Console.WriteLine("Weapon: " + weapon.GetType());
        }

        public static Mech startMechConstraction(int HeadIndex, int BodyIndex, int WeaponIndex, int LegsIndex, string newName)
        {
            Mech newMech = new Mech();
            newMech.movePoints = 100;
            newMech.cost = 0;
            newMech.name = newName;

            switch (BodyIndex)
            {
                case 0:
                    newMech.body = new MechBodyHeavy();
                    newMech.cost += MechBodyHeavy.GetPointCost();
                    break;
                case 2:
                    newMech.body = new MechBodyMedium();
                    newMech.cost += MechBodyMedium.GetPointCost();
                    break;
                case 1:
                    newMech.body = new MechBodyLight();
                    newMech.cost += MechBodyLight.GetPointCost();
                    break;
                default:
                  
                break;
            }        

            switch (LegsIndex)
            {
                case 0:
                    newMech.leg = new Legs();
                    newMech.cost += Legs.GetPointCost();
                    break;
                case 1:
                    newMech.leg = new Wheels();
                    newMech.cost += Wheels.GetPointCost();
                    break;
                case 2:
                    newMech.leg = new Сaterpillar();
                    newMech.cost += Сaterpillar.GetPointCost();
                    break;
                default:
                    
                break;
            }

            switch (HeadIndex)
            {
                case 0:
                    newMech.head = new RadarHead();
                    newMech.cost += RadarHead.GetPointCost();
                    break;
                case 1:
                    newMech.head = new SniperHead();
                    newMech.cost += RadarHead.GetPointCost();
                    break;
                default:
                   
                break;
            }       

            switch (WeaponIndex)
            {
                case 1:
                    newMech.weapon = new Laser();
                    newMech.cost += Laser.GetPointCost();
                    break;
                case 2:
                    newMech.weapon = new AutoCanon();
                    newMech.cost += AutoCanon.GetPointCost();
                    break;
                case 3:
                    newMech.weapon = new Mortar();
                    newMech.cost += Mortar.GetPointCost();
                    break;              
                default:
                    
                break;
            }

            return newMech;
        }

    }
}
