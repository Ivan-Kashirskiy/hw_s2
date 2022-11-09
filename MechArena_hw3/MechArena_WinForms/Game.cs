using MechArena_WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMode
{
    enum GameType {PvP, PvE};
    internal class Game
    {
        Player[] player;
        GameType type;

        public Player getPlayer(int id)
        {
            if (id == 1)
                return player[0];
            else
                return player[1];
        }


        void buildMechs(Player player)
        {
            int mechBuildPoints = 100;
            bool constractionEnded = false;



           /* while (!constractionEnded)
            {
                Console.WriteLine("Do you want:");
                Console.WriteLine("1 - build new mech");
                Console.WriteLine("2 - end constraction");

                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 2)
                {
                    constractionEnded = true;
                }
                
                if (input == 1)
                {
                    Mech.Mech newMech = Mech.Mech.startMechConstraction();
                    {
                        Console.WriteLine("Mech cost: " + newMech.cost());
                        if (mechBuildPoints - newMech.cost() > 0)
                        {
                            mechBuildPoints = mechBuildPoints - newMech.cost();
                            player.playerMech.Add(newMech);
                        }
                        else
                        {
                            Console.WriteLine("Not enough build points");
                        }
                    }

                    Console.WriteLine("Bulld points = " + mechBuildPoints);
                }
            }


            Console.WriteLine("Constraction ended.");*/
        }
        public Field field;

        public void startGame()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            /*Console.WriteLine("Player 1, Enter Your name" );
            player[0].setName( Console.ReadLine() );

            buildMechs(player[0]);

            Console.WriteLine("Player 2, Enter Your name");
            player[1].setName(Console.ReadLine());
            buildMechs(player[1]);*/


            /*
            int num1 = player[0].playerMech.Count();
            int num2 = player[1].playerMech.Count();

            for (int i = 0; i < num1; i++)
            {
                player[0].playerMech[i].put( 1, Field.getFieldSize()/(num1)*i+ Field.getFieldSize() / (num1)/2);
            }

            for (int i = 0; i < num2; i++)
            {
                player[1].playerMech[i].put(Field.getFieldSize() - 2, Field.getFieldSize() / (num2) * i + Field.getFieldSize() / (num2) / 2);
            }

            bool gameEnded = false;

            while (!gameEnded)
            {
                player[0].makeTurn(field, player[1]);
                player[1].makeTurn(field, player[0]);
            }*/
        }

        public GameType getGameType()
        {
            return type;
        }

        public Game(GameType newType)
        {
            type = newType;
            player = new Player[2];
            field = new Field();

            if (type == GameType.PvP)
            {
                player[0] = Player.newPlayer();
                player[1] = Player.newPlayer();
            }
            else
            {
                player[0] = Player.newPlayer();
                player[1] = Player.newAiPlayer();
            }


            //startGame();
        }
    }
}
