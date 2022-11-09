using GameMode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechArena_WinForms
{
    public partial class BattleUserControl : UserControl
    {
        public BattleUserControl()
        {
            InitializeComponent();
        }

        void showMap()
        {
            Bitmap rock = new Bitmap("Tiles\\Rock.png");
            rock.SetResolution(16, 16);

            Bitmap mud = new Bitmap("Tiles\\MudTile.png");
            mud.SetResolution(16, 16);

            Bitmap forest = new Bitmap("Tiles\\Forest.png");
            forest.SetResolution(16, 16);

            Bitmap grass = new Bitmap("Tiles\\GrassTile.png");
            grass.SetResolution(16, 16);

            //BattleTable.Controls.Clear();


            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Height = 16;
                    pb.Width = 16;
                    pb.Padding = new Padding(0);
                    pb.Margin = new Padding(0);
                    pb.Left = 0;
                    pb.Top = 0;

                    switch ( Program.game1.field.GetTerrain(j, i) )
                    {   
                        case terrain.grass:
                            pb.Image = grass;
                        break;

                        case terrain.rock:
                            pb.Image = rock;
                        break;

                        case terrain.forest:
                            pb.Image = forest;
                        break;

                        case terrain.mud:
                            pb.Image = mud;
                        break;

                        default:
                        break;
                    }

                    //BattleTable.Controls.  (grass, j, i);
                    BattleTable.Controls.Add(pb, j, i);
                }

            BattleTable.SendToBack();
        }

        List<PictureBox> drawedMechs = new List<PictureBox>();

        void showPlayerMech(Player player)
        {
            List<Mech.Mech> mechs = player.playerMech;
            for (int i = 0; i < mechs.Count(); i++)
            {
                PictureBox pb = new PictureBox();
                Bitmap bm = new Bitmap("Tiles\\Mech.png");
                 bm.MakeTransparent(Color.FromArgb(255, 255, 255));

                Bitmap rock = new Bitmap("Tiles\\Rock.png");
                rock.SetResolution(16, 16);

                Bitmap mud = new Bitmap("Tiles\\MudTile.png");
                mud.SetResolution(16, 16);

                Bitmap forest = new Bitmap("Tiles\\Forest.png");
                forest.SetResolution(16, 16);

                Bitmap grass = new Bitmap("Tiles\\GrassTile.png");
                grass.SetResolution(16, 16);

                switch (Program.game1.field.GetTerrain(mechs[i].getX(), mechs[i].getY()))
                {
                    case terrain.grass:
                        pb.BackgroundImage = grass;
                        break;

                    case terrain.rock:
                        pb.BackgroundImage = rock;
                        break;

                    case terrain.forest:
                        pb.BackgroundImage = forest;
                        break;

                    case terrain.mud:
                        pb.BackgroundImage = mud;
                        break;

                }
               // pb.BackgroundImage = null;
               
                pb.Image = bm;
                pb.Height = 16;
                pb.Width = 16;
                pb.Padding = new Padding(0);
                pb.Margin = new Padding(0);
                pb.Left = mechs[i].getX() * 16;
                pb.Top = mechs[i].getY() * 16;

                drawedMechs.Add(pb);
                
                this.Controls.Add(pb);
                pb.BringToFront();              
            }



            
        }

        public void startBattle()
        {
            showMap();
            //showPlayerMech(Program.game1.getPlayer(0));
            
            int num1 = Program.game1.getPlayer(0).playerMech.Count();
            int num2 = Program.game1.getPlayer(1).playerMech.Count();

            for (int i = 0; i<num1; i++)
            {
                Program.game1.getPlayer(0).playerMech[i].put( 1, Field.getFieldSize()/(num1)* i+ Field.getFieldSize() / (num1)/2);
            }

            for (int i = 0; i<num2; i++)
            {
                Program.game1.getPlayer(1).playerMech[i].put(Field.getFieldSize() - 2, Field.getFieldSize() / (num2)* i + Field.getFieldSize() / (num2) / 2);
            }

            showPlayerMech(Program.game1.getPlayer(0));
            //showPlayerMech(Program.game1.getPlayer(0));

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EndTurn_Click(object sender, EventArgs e)
        {

        }
    }
}
