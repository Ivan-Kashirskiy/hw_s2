using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMode
{
    public enum terrain {grass, mud, rock, forest};
   

    public class Field
    {
        static int feildSize = 30;
        public static int getFieldSize()
        {
            return feildSize;
        }

        public terrain[,] field;

       internal struct RandomGenParams
        {
            internal static int squareSizeMin = 4;
            internal static int squareSizeMax = 10;

            internal static int numOfSquresMin = 5;
            internal static int numOfSquresMax = 10;
        }
        
        public terrain GetTerrain(int x, int y)
        {
            return field[x, y];
        }

        public Field()
        {
            field = new terrain[feildSize, feildSize];

            for (int i = 0; i < feildSize; i++)
                for (int j = 0; j < feildSize; j++)
                    field[i, j] = terrain.grass;

            Random rnd = new Random();
            int numOfSquares = rnd.Next(RandomGenParams.numOfSquresMin, RandomGenParams.numOfSquresMax);

            for (int i = 0; i < numOfSquares; i++)
            {
                terrain terrainType = terrain.grass;
                int r = rnd.Next(1, 3);
                if (r == 1)
                    terrainType = terrain.mud;
                if (r == 2)
                    terrainType = terrain.rock;
                if (r == 3)
                    terrainType = terrain.forest;

                int squareSizeX = rnd.Next(RandomGenParams.squareSizeMin, RandomGenParams.squareSizeMax);
                int squareSizeY = rnd.Next(RandomGenParams.squareSizeMin, RandomGenParams.squareSizeMax);
                int squareX = rnd.Next(0, feildSize - squareSizeX);
                int squareY = rnd.Next(0, feildSize - squareSizeY);

                for (int x = squareX; x< squareX+ squareSizeX; x++)
                    for (int y = squareY; y < squareY + squareSizeY; y++)
                        field[x, y] = terrainType;
            }

        }

    }
}
