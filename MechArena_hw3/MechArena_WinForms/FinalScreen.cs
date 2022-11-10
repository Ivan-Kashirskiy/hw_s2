using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MechArena_WinForms
{
    public partial class FinalScreen : UserControl
    {
        public FinalScreen()
        {
            InitializeComponent();
            Winner.Left = (this.ClientSize.Width - Winner.Width) / 2;          

            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
        }

        public void setWinerName(string name)
        {         
            Winner.Text = name+" won!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm1 mf = (MainForm1)Parent.Parent;
            mf.Close();
        }
    }
}
