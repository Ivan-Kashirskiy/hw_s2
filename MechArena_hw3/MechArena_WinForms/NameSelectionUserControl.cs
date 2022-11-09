﻿using System;
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

        public void selectName()
        {


        }



        bool checkNames(string name1, string name2)
        {
            if (name1.Count() == 0)
            {
                MainForm myParent = (MainForm)this.Parent.Parent;
                myParent.showError("Enter first player name");
                return false;
            }

            if (name2.Count() == 0)
            {
                MainForm myParent = (MainForm)this.Parent.Parent;
                myParent.showError("Enter second player name");
                return false;
            }

            if (name1.Count() > 15)
            {
                MainForm myParent = (MainForm)this.Parent.Parent;
                myParent.showError("First player`s name is too lond");
                return false;
            }

            if (name2.Count() > 15)
            {
                MainForm myParent = (MainForm)this.Parent.Parent;
                myParent.showError("Second player`s name is too lond");
                return false;
            }


            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainForm myParent = (MainForm)this.Parent.Parent;


            if (checkNames(textBox1.Text, textBox2.Text) )
                myParent.selectNames(textBox1.Text, textBox2.Text);
        }
    }
}
