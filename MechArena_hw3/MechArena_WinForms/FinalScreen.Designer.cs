namespace MechArena_WinForms
{
    partial class FinalScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalScreen));
            this.button1 = new System.Windows.Forms.Button();
            this.Winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(338, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "End game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Winner
            // 
            this.Winner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Winner.AutoSize = true;
            this.Winner.BackColor = System.Drawing.Color.Transparent;
            this.Winner.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Winner.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Winner.Location = new System.Drawing.Point(375, 151);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(90, 37);
            this.Winner.TabIndex = 1;
            this.Winner.Text = "label1";            
            // 
            // FinalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.button1);
            this.Name = "FinalScreen";
            this.Size = new System.Drawing.Size(864, 480);        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label Winner;
    }
}
