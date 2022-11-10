using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MechArena_WinForms
{
    public partial class NameSelectionUserControl : UserControl
    {
        public NameSelectionUserControl()
        {
            InitializeComponent();
        }

        bool checkNames(string name1, string name2)
        {
            if (name1.Count() == 0)
            {
                MainForm1 myParent = (MainForm1)this.Parent.Parent;
                myParent.showError("Enter first player name");
                return false;
            }

            if (name2.Count() == 0)
            {
                MainForm1 myParent = (MainForm1)this.Parent.Parent;
                myParent.showError("Enter second player name");
                return false;
            }

            if (name1.Count() > 15)
            {
                MainForm1 myParent = (MainForm1)this.Parent.Parent;
                myParent.showError("First player`s name is too lond");
                return false;
            }

            if (name2.Count() > 15)
            {
                MainForm1 myParent = (MainForm1)this.Parent.Parent;
                myParent.showError("Second player`s name is too lond");
                return false;
            }

            if (Equals(name1, name2))
            {
                MainForm1 myParent = (MainForm1)this.Parent.Parent;
                myParent.showError("Names are the same");
                return false;
            }

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainForm1 myParent = (MainForm1)this.Parent.Parent;

            if (checkNames(textBox1.Text, textBox2.Text) )
                myParent.selectNames(textBox1.Text, textBox2.Text);
        }
    }
}
