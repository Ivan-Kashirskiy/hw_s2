using GameMode;
using Mech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MechArena_WinForms
{
    public partial class BattleUserControl : UserControl
    {
        public BattleUserControl()
        {
            InitializeComponent();
        }

        Player curPlayer;
        Mech.Mech selectedMech;
        Mech.Mech movedMech;
        List<PictureBox> drawedMechs;
        List<PictureBox> drawedMoveImages;

        Bitmap rock; 
        Bitmap mud;
        Bitmap forest; 
        Bitmap grass; 
        enum visibility { my, visible, detected };

        void showMap()
        {
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

                    switch (Program.game1.field.GetTerrain(j, i))
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

                    BattleTable.Controls.Add(pb, j, i);
                }

            BattleTable.SendToBack();
        }
    
        void select(int x, int y)
        {
            for (int i = 0; i < curPlayer.playerMech.Count(); i++)
                if ((curPlayer.playerMech[i].getX() == x) && (curPlayer.playerMech[i].getY() == y))
                {
                    onSelect(curPlayer.playerMech[i], visibility.my);
                    return;
                }

            for (int i = 0; i < curPlayer.visibleMech.Count(); i++)
                if ((curPlayer.visibleMech[i].getX() == x) && (curPlayer.visibleMech[i].getY() == y))
                {
                    onSelect(curPlayer.visibleMech[i], visibility.visible);
                    return;
                }

            for (int i = 0; i < curPlayer.detectedMech.Count(); i++)
                if ((curPlayer.detectedMech[i].getX() == x) && (curPlayer.detectedMech[i].getY() == y))
                {
                    onSelect(curPlayer.detectedMech[i], visibility.detected);
                    return;
                }

        }

        private void mechImageClick(object sender, EventArgs e)
        {
            MainForm1 mf = (MainForm1)this.Parent.Parent;

            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {
                select(pb.Left / 16, pb.Top / 16);                
            }
        }

        private void moveImageClick(object sender, EventArgs e)
        {
            MainForm1 mf = (MainForm1)this.Parent.Parent;

            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {
                selectedMech.move(pb.Left / 16, pb.Top / 16, Program.game1.field);
                movedMech = selectedMech;

                string coord = "(" + selectedMech.getX().ToString() + " , " + selectedMech.getY().ToString() + ")";
                BattleLog.Text += selectedMech.getName() + " moved to " + coord + "\n";

                showPlayerMech(curPlayer);
                drowMoveImages();
            }
        }

        void createMoveImage(int x, int y, string imagePath)
        {
            PictureBox pb = new PictureBox();
            Bitmap myMech = new Bitmap(imagePath);

            myMech.MakeTransparent(Color.FromArgb(255, 255, 255));
            switch (Program.game1.field.GetTerrain(x, y))
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

            pb.Image = myMech;
            pb.Height = 16;
            pb.Width = 16;
            pb.Padding = new Padding(0);
            pb.Margin = new Padding(0);
            pb.Left = x * 16;
            pb.Top = y * 16;

            pb.Click += new System.EventHandler(moveImageClick);

            drawedMoveImages.Add(pb);

            this.Controls.Add(pb);
            pb.BringToFront();
        }

        bool tileIsFree(int x, int y)
        {          
            Player player1 = Program.game1.getPlayer(0);
            Player player2 = Program.game1.getPlayer(1);

            for (int i = 0; i < player1.playerMech.Count; i++)
                if ((player1.playerMech[i].getX() == x) && (player1.playerMech[i].getY() == y))
                    return false;

            for(int i = 0; i < player2.playerMech.Count; i++)
                if ((player2.playerMech[i].getX() == x) && (player2.playerMech[i].getY() == y))
                return false;

            return true;
        }

        void drowMoveImages()
        {
            clearMoveImages();
            if ((movedMech == null) || ( (selectedMech == movedMech) && (selectedMech != null) ))
                for (int i = 0; i < 30; i++)
                    for (int j = 0; j < 30; j++)
                      if ((selectedMech.can_move(j, i, Program.game1.field)) && tileIsFree(j, i))
                           createMoveImage(j, i, "Tiles\\canMove.bmp");
        }

        void clearMoveImages()
        {
            for (int i = 0; i < drawedMoveImages.Count(); i++)
                drawedMoveImages[i].Dispose();
        }

        void createMechImage(Mech.Mech mech, string imagePath)
        {
            PictureBox pb = new PictureBox();
            Bitmap myMech = new Bitmap(imagePath);

            myMech.MakeTransparent(Color.FromArgb(255, 255, 255));
            switch (Program.game1.field.GetTerrain(mech.getX(), mech.getY()))
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

            pb.Image = myMech;
            pb.Height = 16;
            pb.Width = 16;
            pb.Padding = new Padding(0);
            pb.Margin = new Padding(0);
            pb.Left = mech.getX() * 16;
            pb.Top = mech.getY() * 16;

            pb.Click += new System.EventHandler(mechImageClick);

            drawedMechs.Add(pb);

            this.Controls.Add(pb);
            pb.BringToFront();

        }

        void showPlayerMech(Player player)
        {
            player.scan(Program.game1.nextPlayer(player));

            for (int i = 0; i < drawedMechs.Count(); i++)
                drawedMechs[i].Dispose();


            for (int i = 0; i < player.playerMech.Count(); i++)
            {
                if (player.playerMech[i] == movedMech)
                    createMechImage(player.playerMech[i], "Tiles\\selectedMech.png");
                else
                    createMechImage(player.playerMech[i], "Tiles\\Mech.png");
            }

            for (int i = 0; i < player.visibleMech.Count(); i++)
            {

                if ((selectedMech != null) && ( selectedMech.canAttack(player.visibleMech[i]) ) && ((movedMech == null ) || (selectedMech == movedMech)))
                    createMechImage(player.visibleMech[i], "Tiles\\EnemyMechInRange.png");
                else
                    createMechImage(player.visibleMech[i], "Tiles\\EnemyMech.png");
            }

            for (int i = 0; i < player.detectedMech.Count(); i++)
            {
                createMechImage(player.detectedMech[i], "Tiles\\Detected.png");
            }
        }


        void onSelect(Mech.Mech selected, visibility type)
        {           
            if (type == visibility.my)
            {
                selectedMech = selected;
                MechInfoTable.Show();

                MechNameLabel.Text = selected.getName();
                OwnerLabel.Text = Program.game1.getPlayerByMech(selected).getName();
                ArmorPointsLabel.Text = selected.getCurArmor().ToString();

                HeadLabel.Text = selected.getHeadName();
                BodyLabel.Text = selected.getBodyName();
                WeaponLabel.Text = selected.getWeaponName();
                LegsLabel.Text = selected.getLegsName();

                showPlayerMech(curPlayer);
                drowMoveImages();
            }

            if (type == visibility.visible)
                if ( (selectedMech != null) && (selectedMech.canAttack(selected)) )
                {
                    selectedMech.attack(selected);
                    BattleLog.Text += selectedMech.getName() + " attacked " + selected.getName() + "\n";

                    if (selected.getCurArmor() <= 0)
                    {                      
                        BattleLog.Text += "Mech " + selected.getName() + " died \n";
                        Program.game1.getPlayerByMech(selected).playerMech.Remove(selected);

                        if (Program.game1.nextPlayer(curPlayer).playerMech.Count() == 0)
                        {
                            MainForm1 mf = (MainForm1)this.Parent.Parent;
                            mf.winerName = curPlayer.getName();

                            mf.GameWon();
                            return;
                        }
                    }

                    showPlayerMech(curPlayer);                   
                    endTurn();
                }
                else
                {
                    unselect();
                    MechInfoTable.Show();

                    MechNameLabel.Text = selected.getName();
                    OwnerLabel.Text = Program.game1.getPlayerByMech(selected).getName();
                    ArmorPointsLabel.Text = selected.getCurArmor().ToString();

                    HeadLabel.Text = selected.getHeadName();
                    BodyLabel.Text = selected.getBodyName();
                    WeaponLabel.Text = selected.getWeaponName();
                    LegsLabel.Text = selected.getLegsName();                  
                }

            if (type == visibility.detected)
            {
                unselect();
                MechInfoTable.Show();

                MechNameLabel.Text = "Unknown";
                OwnerLabel.Text = "Unknown";
                ArmorPointsLabel.Text = "Unknown";

                HeadLabel.Text = "Unknown";
                BodyLabel.Text = "Unknown";
                WeaponLabel.Text = "Unknown";
                LegsLabel.Text = "Unknown";
            }
        }

        void unselect()
        {
            selectedMech = null;
            clearMoveImages();
            MechInfoTable.Hide();
        }

        void startTurn(Player player)
        {
            TurnLabel.Text = player.getName() + "`s turn";
            MechInfoTable.Hide();
            clearMoveImages();
            movedMech = null;
            selectedMech = null;

            curPlayer = player;
            player.refreshMovePoints();
            player.scan(Program.game1.nextPlayer(player));
            
            showPlayerMech(player);
        }

        void endTurn()
        {
            startTurn( Program.game1.nextPlayer(curPlayer) );
        }

        public void startBattle()
        {
            drawedMechs = new List<PictureBox>();
            drawedMoveImages = new List<PictureBox>();

            rock = new Bitmap("Tiles\\Rock.png");
            mud = new Bitmap("Tiles\\MudTile.png");
            forest = new Bitmap("Tiles\\Forest.png");
            grass = new Bitmap("Tiles\\GrassTile.png");

            rock.SetResolution(16, 16);
            mud.SetResolution(16, 16);
            forest.SetResolution(16, 16);
            grass.SetResolution(16, 16);

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

            startTurn(Program.game1.getPlayer(0));
        }

        private void EndTurn_Click(object sender, EventArgs e)
        {
            endTurn();
        }

        private void WeaponLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BattleUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
