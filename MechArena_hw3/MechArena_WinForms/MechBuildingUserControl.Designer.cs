namespace MechArena_WinForms
{
    partial class MechBuildingUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechBuildingUserControl));
            this.MechPointsLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MechCost = new System.Windows.Forms.Label();
            this.FinishBuilding = new System.Windows.Forms.Button();
            this.BuildMech = new System.Windows.Forms.Button();
            this.MechList = new System.Windows.Forms.ListView();
            this.LegsComboBox = new System.Windows.Forms.ComboBox();
            this.WeaponComboBox = new System.Windows.Forms.ComboBox();
            this.BodyComboBox = new System.Windows.Forms.ComboBox();
            this.HeadComboBox = new System.Windows.Forms.ComboBox();
            this.MechNameTexBox = new System.Windows.Forms.TextBox();
            this.MechName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MechPointsLeft
            // 
            this.MechPointsLeft.AutoSize = true;
            this.MechPointsLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MechPointsLeft.Location = new System.Drawing.Point(388, 415);
            this.MechPointsLeft.Name = "MechPointsLeft";
            this.MechPointsLeft.Size = new System.Drawing.Size(19, 21);
            this.MechPointsLeft.TabIndex = 21;
            this.MechPointsLeft.Text = "0";           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mech points left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mech cost:";
            // 
            // MechCost
            // 
            this.MechCost.AutoSize = true;
            this.MechCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MechCost.Location = new System.Drawing.Point(388, 383);
            this.MechCost.Name = "MechCost";
            this.MechCost.Size = new System.Drawing.Size(19, 21);
            this.MechCost.TabIndex = 18;
            this.MechCost.Text = "0";
            // 
            // FinishBuilding
            // 
            this.FinishBuilding.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishBuilding.Location = new System.Drawing.Point(683, 415);
            this.FinishBuilding.Name = "FinishBuilding";
            this.FinishBuilding.Size = new System.Drawing.Size(168, 62);
            this.FinishBuilding.TabIndex = 17;
            this.FinishBuilding.Text = "Finish building";
            this.FinishBuilding.UseVisualStyleBackColor = true;
            this.FinishBuilding.Click += new System.EventHandler(this.FinishBuilding_Click);
            // 
            // BuildMech
            // 
            this.BuildMech.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildMech.Location = new System.Drawing.Point(116, 395);
            this.BuildMech.Name = "BuildMech";
            this.BuildMech.Size = new System.Drawing.Size(102, 41);
            this.BuildMech.TabIndex = 16;
            this.BuildMech.Text = "Build mech";
            this.BuildMech.UseVisualStyleBackColor = true;
            this.BuildMech.Click += new System.EventHandler(this.BuildMech_Click);
            // 
            // MechList
            // 
            this.MechList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MechList.HideSelection = true;
            this.MechList.LabelWrap = false;
            this.MechList.Location = new System.Drawing.Point(683, 125);
            this.MechList.Name = "MechList";
            this.MechList.Size = new System.Drawing.Size(121, 216);
            this.MechList.TabIndex = 15;
            this.MechList.UseCompatibleStateImageBehavior = false;
            // 
            // LegsComboBox
            // 
            this.LegsComboBox.FormattingEnabled = true;
            this.LegsComboBox.Items.AddRange(new object[] {
            "MechLegs",
            "Wheels",
            "Caterpillar"});
            this.LegsComboBox.Location = new System.Drawing.Point(116, 283);
            this.LegsComboBox.Name = "LegsComboBox";
            this.LegsComboBox.Size = new System.Drawing.Size(121, 23);
            this.LegsComboBox.TabIndex = 22;
            this.LegsComboBox.SelectedIndexChanged += new System.EventHandler(this.LegsComboBox_SelectedIndexChanged);
            // 
            // WeaponComboBox
            // 
            this.WeaponComboBox.FormattingEnabled = true;
            this.WeaponComboBox.Items.AddRange(new object[] {
            "Laser",
            "Mortar",
            "AutoCanon"});
            this.WeaponComboBox.Location = new System.Drawing.Point(116, 233);
            this.WeaponComboBox.Name = "WeaponComboBox";
            this.WeaponComboBox.Size = new System.Drawing.Size(121, 23);
            this.WeaponComboBox.TabIndex = 23;
            this.WeaponComboBox.SelectedIndexChanged += new System.EventHandler(this.WeaponComboBox_SelectedIndexChanged);
            // 
            // BodyComboBox
            // 
            this.BodyComboBox.FormattingEnabled = true;
            this.BodyComboBox.Items.AddRange(new object[] {
            "Heavy",
            "Light",
            "Medium"});
            this.BodyComboBox.Location = new System.Drawing.Point(116, 180);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(121, 23);
            this.BodyComboBox.TabIndex = 24;
            this.BodyComboBox.SelectedIndexChanged += new System.EventHandler(this.BodyComboBox_SelectedIndexChanged);
            // 
            // HeadComboBox
            // 
            this.HeadComboBox.FormattingEnabled = true;
            this.HeadComboBox.Items.AddRange(new object[] {
            "Radar Head",
            "Sniper Head"});
            this.HeadComboBox.Location = new System.Drawing.Point(116, 125);
            this.HeadComboBox.Name = "HeadComboBox";
            this.HeadComboBox.Size = new System.Drawing.Size(121, 23);
            this.HeadComboBox.TabIndex = 25;
            this.HeadComboBox.SelectedIndexChanged += new System.EventHandler(this.HeadComboBox_SelectedIndexChanged);
            // 
            // MechNameTexBox
            // 
            this.MechNameTexBox.Location = new System.Drawing.Point(421, 51);
            this.MechNameTexBox.Name = "MechNameTexBox";
            this.MechNameTexBox.Size = new System.Drawing.Size(100, 23);
            this.MechNameTexBox.TabIndex = 26;
            // 
            // MechName
            // 
            this.MechName.AutoSize = true;
            this.MechName.Location = new System.Drawing.Point(345, 54);
            this.MechName.Name = "MechName";
            this.MechName.Size = new System.Drawing.Size(70, 15);
            this.MechName.TabIndex = 27;
            this.MechName.Text = "Mech name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "MechList";
            // 
            // MechBuildingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MechName);
            this.Controls.Add(this.MechNameTexBox);
            this.Controls.Add(this.HeadComboBox);
            this.Controls.Add(this.BodyComboBox);
            this.Controls.Add(this.WeaponComboBox);
            this.Controls.Add(this.LegsComboBox);
            this.Controls.Add(this.MechPointsLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MechCost);
            this.Controls.Add(this.FinishBuilding);
            this.Controls.Add(this.BuildMech);
            this.Controls.Add(this.MechList);
            this.Name = "MechBuildingUserControl";
            this.Size = new System.Drawing.Size(854, 480);
            this.Load += new System.EventHandler(this.MechBuildingUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MechPointsLeft;
        private Label label2;
        private Label label1;
        private Label MechCost;
        private Button FinishBuilding;
        private Button BuildMech;
        private ListView MechList;
        private ListBox legsBox;
        private ComboBox LegsComboBox;
        private ComboBox WeaponComboBox;
        private ComboBox BodyComboBox;
        private ComboBox HeadComboBox;
        private TextBox MechNameTexBox;
        private Label MechName;
        private Label label3;
    }
}
