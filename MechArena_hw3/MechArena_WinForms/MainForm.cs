using GameMode;

namespace MechArena_WinForms
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            
        }

        public void showError(string mes)
        {
                MessageBox.Show(
                    mes,
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void showControlNameSelection()
        {
            nameSelectionUserControl1.Show();
            mechBuildingUserControl1.Hide();
            battleUserControl2.Hide();
            finalScreen1.Hide();
        }


        public void showControlmechBuilding()
        {
            if  ( (nameSelectionUserControl1 != null) && (nameSelectionUserControl1 != null) )
            {
                nameSelectionUserControl1.Hide();
                mechBuildingUserControl1.Show();
                battleUserControl2.Hide();
                finalScreen1.Hide();
            }
        }

        public void showControlBattle()
        {
                nameSelectionUserControl1.Hide();
                mechBuildingUserControl1.Hide();
                battleUserControl2.Show();
                finalScreen1.Hide();
        }

        public string winerName;

        public void showFinalSrceen()
        {
            nameSelectionUserControl1.Hide();
            mechBuildingUserControl1.Hide();
            battleUserControl2.Hide();
            finalScreen1.Show();
        }

        public void selectNames(string name1, string name2)
        {
            Program.game1.getPlayer(0).setName( name1 );
            Program.game1.getPlayer(1).setName( name2 );

           // mechBuildingUserControl1.curPlayer = Program.game1.getPlayer(0);
            this.showControlmechBuilding();
        }

        public void battleBegin()
        {
            showControlBattle();
            battleUserControl2.startBattle();
        }

        private void NameSelection_Load(object sender, EventArgs e)
        {
            //nameSelectionUserControl.Show();
            //mechBuildingUserControl.Hide();
        }

        public void GameWon()
        {
            finalScreen1.setWinerName(winerName); 
            showFinalSrceen();
        }

        private void nameSelectionUserControl_Load(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            showControlNameSelection();
        }


    }
}