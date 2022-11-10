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
       
        public Field field;

        public void startGame()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm1());  
        }

        public GameType getGameType()
        {
            return type;
        }

        public Player nextPlayer(Player curPlayer)
        {
            if (type == GameType.PvP)
            {
                if (curPlayer == player[0])
                    return player[1];

                if (curPlayer == player[1])
                    return player[0];
            }

            return curPlayer;
        }

        public Player getPlayerByMech(Mech.Mech mech)
        {
            for (int i = 0; i < player[0].playerMech.Count(); i++)
            {
                if (player[0].playerMech[i] == mech)
                    return player[0];
            }

            for (int i = 0; i < player[1].playerMech.Count(); i++)
            {
                if (player[1].playerMech[i] == mech)
                    return player[1];
            }

            return null;
        }

       // public void GameWon(Player player)
       // {
          //  MainForm1.showFinalSrceen();
       // }

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
        }
    }
}
