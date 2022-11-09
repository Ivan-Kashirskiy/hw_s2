using GameMode;
using Mech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MechArena_WinForms
{
    public partial class MechBuildingUserControl : UserControl
    {

        public MechBuildingUserControl()
        {
            InitializeComponent();
            HeadComboBox.SelectedIndex = 0;
            LegsComboBox.SelectedIndex = 0;
            WeaponComboBox.SelectedIndex = 0;
            BodyComboBox.SelectedIndex = 0;
        }

        internal Player curPlayer;

        int mechPoint = 100;

        int refreshPointsCost()
        {
            int points = 0;

            switch (HeadComboBox.SelectedIndex)
            {
                case 0:
                    points = points + RadarHead.GetPointCost();
                break;


                case 1:
                    points = points + SniperHead.GetPointCost();
                break;

                default:
                    points = points - 1;
                    break;
            }

            
            switch (BodyComboBox.SelectedIndex)
            {
                case 0:
                    points = points + MechBodyHeavy.GetPointCost();
                break;

                case 1:
                    points = points + MechBodyLight.GetPointCost();
                break;

                case 2:
                    points = points + MechBodyMedium.GetPointCost();
                break;


                default:
                    points = points - 1;
                    break;
            }


            switch (WeaponComboBox.SelectedIndex)
            {
                case 0:
                    points = points + Laser.GetPointCost();
                break;

                case 1:
                    points = points + Mortar.GetPointCost();
                break;

                case 2:
                    points = points + AutoCanon.GetPointCost();
                break;


                default:
                    points = points - 1;
                    break;
            }

            
            switch (LegsComboBox.SelectedIndex)
            {
                case 0:
                    points = points + Legs.GetPointCost();
                break;

                case 1:
                    points = points + Wheels.GetPointCost();
                break;

                case 2:
                    points = points + Сaterpillar.GetPointCost();
                break;


                default:
                    points = points - 1;
                break;
            }

            //points = 5;
            MechCost.Text = points.ToString();
            return points;
        }


        private void LegsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPointsCost();
        }

        private void HeadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPointsCost();
        }

        private void BodyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPointsCost();
        }

        private void WeaponComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPointsCost();
        }

        private void refreshMechPoints()
        {
            MechPointsLeft.Text = mechPoint.ToString();
        }

        private void refreshMechList()
        {
            MechList.Items.Clear();

            for (int i = 0; i < curPlayer.playerMech.Count; i++)
                MechList.Items.Add( curPlayer.playerMech[i].getName() );

        }

        private void BuildMech_Click(object sender, EventArgs e)
        {
            Mech.Mech newMech = Mech.Mech.startMechConstraction(HeadComboBox.SelectedIndex, BodyComboBox.SelectedIndex, WeaponComboBox.SelectedIndex, LegsComboBox.SelectedIndex, MechNameTexBox.Text);

            if (newMech.Cost() <= mechPoint)
            {
                curPlayer.playerMech.Add(newMech);
                mechPoint -= newMech.Cost();
                refreshMechPoints();
                refreshMechList();
            }
            else
            {
                MainForm myParent = (MainForm)this.Parent.Parent;
                myParent.showError("Not enough point");
            }

        }

        void startMechConstraction(Player player)
        {
            MechNameTexBox.Text = "";
            curPlayer = player;
            mechPoint = 100;
            refreshMechPoints();
            refreshMechList();
            refreshPointsCost();
        }


        private void FinishBuilding_Click(object sender, EventArgs e)
        {
            if ( Program.game1.getGameType() == GameType.PvP )
            {
                if ( curPlayer == Program.game1.getPlayer(0) )
                {
                    startMechConstraction( Program.game1.getPlayer(1) );
                }
                else 
                {
                    MainForm myParent = (MainForm)this.Parent.Parent;
                    myParent.battleBegin();
                }
            }

        }

        private void MechPointsLeft_Click(object sender, EventArgs e)
        {

        }

        private void MechBuildingUserControl_Load(object sender, EventArgs e)
        {
            startMechConstraction(Program.game1.getPlayer(0));
        }



    }
}
