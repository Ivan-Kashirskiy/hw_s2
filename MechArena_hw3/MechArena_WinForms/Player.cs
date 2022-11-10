using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMode
{
    internal class Player
    {
        int maxActionPoints;
        int actionPoints;

        string name;
        
        public void setName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }


        public List<Mech.Mech> playerMech;
        public List<Mech.Mech> visibleMech;
        public List<Mech.Mech> detectedMech;

        bool isAi;
        public static Player newPlayer()
        {
            Player newPlayer = new Player();
            newPlayer.playerMech = new List<Mech.Mech>(0);
            newPlayer.visibleMech = new List<Mech.Mech>(0);
            newPlayer.detectedMech = new List<Mech.Mech>(0);

            newPlayer.maxActionPoints = 20;
            newPlayer.isAi = false;

            return newPlayer;
        }

        public static Player newAiPlayer()
        {
            Player newPlayer = new Player();
            newPlayer.playerMech = new List<Mech.Mech>(0);
            newPlayer.visibleMech = new List<Mech.Mech>(0);
            newPlayer.detectedMech = new List<Mech.Mech>(0);

            newPlayer.maxActionPoints = 20;
            newPlayer.isAi = true;

            return newPlayer;
        }

        public void scan(Player enemyPlayer)
        {
            visibleMech.Clear(); //= new List<Mech.Mech>(0);
            detectedMech.Clear();// = new List<Mech.Mech>(0);

            for (int i = 0; i < playerMech.Count(); i++)
            {
                playerMech[i].scan(enemyPlayer.playerMech, visibleMech, detectedMech);
            }

        }



        public void printField(Field grid)
        {
            Console.WriteLine("Player " + getName() );
            int fs = 30;
            char[,] fieldChar = new char[fs, fs];

            for (int i = 0; i < fs; i++)
                for (int j = 0; j < fs; j++)
                {
                    if (grid.field[i, j] == terrain.grass)
                        fieldChar[i, j] = 'g';

                    if (grid.field[i, j] == terrain.mud)
                        fieldChar[i, j] = 'm';

                    if (grid.field[i, j] == terrain.forest)
                        fieldChar[i, j] = 'f';

                    if (grid.field[i, j] == terrain.rock)
                        fieldChar[i, j] = 'r';
                }

            foreach (Mech.Mech mech in playerMech)
            {
                fieldChar[mech.getX(), mech.getY()] = 'A';
            }

            foreach (Mech.Mech mech in visibleMech)
            {
                fieldChar[mech.getX(), mech.getY()] = 'V';
            }

            foreach (Mech.Mech mech in detectedMech)
            {
                fieldChar[mech.getX(), mech.getY()] = 'D';
            }


            for (int i = 0; i < fs; i++)
            {
                for (int j = 0; j < fs; j++)
                    Console.Write(fieldChar[i, j]);

                Console.WriteLine();
            }
        }


        public void prinrMech()
        {
            int i = 0;
            foreach (Mech.Mech mech in playerMech)
            {
                Console.WriteLine("Id:"+ i + " Coordinates " + mech.getY() + " " + mech.getX());
                i++;
            }

        } 

        public void refreshMovePoints()
        {           
            for (int i = 0; i < playerMech.Count(); i++)
                playerMech[i].refreshMovePoints();
        }

        public void makeTurn(Field grid, Player enemyPlayer)
        {
            scan(enemyPlayer);
        }


    }

}


