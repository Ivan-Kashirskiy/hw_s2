namespace MechArena_WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.battleUserControl1 = new MechArena_WinForms.BattleUserControl();
            this.mechBuildingUserControl1 = new MechArena_WinForms.MechBuildingUserControl();
            this.nameSelectionUserControl1 = new MechArena_WinForms.NameSelectionUserControl();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Controls.Add(this.battleUserControl1);
            this.MainPanel.Controls.Add(this.mechBuildingUserControl1);
            this.MainPanel.Controls.Add(this.nameSelectionUserControl1);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(884, 497);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // battleUserControl1
            // 
            this.battleUserControl1.Location = new System.Drawing.Point(0, 0);
            this.battleUserControl1.Name = "battleUserControl1";
            this.battleUserControl1.Size = new System.Drawing.Size(864, 480);
            this.battleUserControl1.TabIndex = 2;
            // 
            // mechBuildingUserControl1
            // 
            this.mechBuildingUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mechBuildingUserControl1.BackgroundImage")));
            this.mechBuildingUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mechBuildingUserControl1.Location = new System.Drawing.Point(0, 0);
            this.mechBuildingUserControl1.Name = "mechBuildingUserControl1";
            this.mechBuildingUserControl1.Size = new System.Drawing.Size(864, 480);
            this.mechBuildingUserControl1.TabIndex = 1;
            // 
            // nameSelectionUserControl1
            // 
            this.nameSelectionUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameSelectionUserControl1.BackgroundImage")));
            this.nameSelectionUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameSelectionUserControl1.Location = new System.Drawing.Point(0, 0);
            this.nameSelectionUserControl1.Name = "nameSelectionUserControl1";
            this.nameSelectionUserControl1.Size = new System.Drawing.Size(864, 480);
            this.nameSelectionUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 482);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.Text = "Mech Arena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel MainPanel;
        private NameSelectionUserControl nameSelectionUserControl;
        private MechBuildingUserControl mechBuildingUserControl;
        private NameSelectionUserControl nameSelectionUserControl1;
        private MechBuildingUserControl mechBuildingUserControl1;
        private BattleUserControl battleUserControl1;
    }
}