using Mech;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public int cost()
        {
            return head.pointCost + body.pointCost + leg.pointCost + weapon.pointCost;
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

        public static Mech startMechConstraction()
        {
            Mech newMech = new Mech();
            Console.WriteLine("Mech Constraction starts");
            newMech.movePoints = 100;

            //select body
            Console.WriteLine("Select body type");
            Console.WriteLine("1 - Heavy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Light");
            int armorType = Convert.ToInt32(Console.ReadLine());

            switch (armorType)
            {
                case 1:
                    newMech.body = new MechBodyHeavy();
                    break;
                case 2:
                    newMech.body = new MechBodyMedium();
                    break;
                case 3:
                    newMech.body = new MechBodyLight();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

            //select leg
            Console.WriteLine("Select leg type");
            Console.WriteLine("1 - Legs");
            Console.WriteLine("2 - Whells");
            Console.WriteLine("3 - Caterpillar");
            int legType = Convert.ToInt32(Console.ReadLine());

            switch (legType)
            {
                case 1:
                    newMech.leg = new Legs();
                    break;
                case 2:
                    newMech.leg = new Wheels();
                    break;
                case 3:
                    newMech.leg = new Сaterpillar();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

            //select head
            Console.WriteLine("Select head type");
            Console.WriteLine("1 - Radar");
            Console.WriteLine("2 - Sniper");
            int headType = Convert.ToInt32(Console.ReadLine());

            switch (headType)
            {
                case 1:
                    newMech.head = new RadarHead();
                    break;
                case 2:
                    newMech.head = new SniperHead();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

            //select weapon
            Console.WriteLine("Select weapon type");
            Console.WriteLine("1 - Laser");
            Console.WriteLine("2 - AutoCanon");
            Console.WriteLine("3 - Mortar");

            int weaponType = Convert.ToInt32(Console.ReadLine());

            switch (weaponType)
            {
                case 1:
                    newMech.weapon = new Laser();
                    break;
                case 2:
                    newMech.weapon = new AutoCanon();
                    break;
                case 3:
                    newMech.weapon = new Mortar();
                    break;              
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }

            return newMech;
        }

    }
}
