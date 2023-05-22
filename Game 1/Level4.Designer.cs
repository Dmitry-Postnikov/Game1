namespace WindowsFormsApp1
{
    partial class Level4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.healthBar1 = new System.Windows.Forms.ProgressBar();
            this.kills1 = new System.Windows.Forms.Label();
            this.health1 = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Player4 = new System.Windows.Forms.PictureBox();
            this.door4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door4)).BeginInit();
            this.SuspendLayout();
            // 
            // healthBar1
            // 
            this.healthBar1.Location = new System.Drawing.Point(1011, 10);
            this.healthBar1.Name = "healthBar1";
            this.healthBar1.Size = new System.Drawing.Size(150, 20);
            this.healthBar1.TabIndex = 13;
            this.healthBar1.Value = 100;
            // 
            // kills1
            // 
            this.kills1.AutoSize = true;
            this.kills1.BackColor = System.Drawing.Color.Gainsboro;
            this.kills1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kills1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kills1.Location = new System.Drawing.Point(1176, 10);
            this.kills1.Name = "kills1";
            this.kills1.Size = new System.Drawing.Size(65, 19);
            this.kills1.TabIndex = 12;
            this.kills1.Text = "Kills: 0";
            // 
            // health1
            // 
            this.health1.AutoSize = true;
            this.health1.BackColor = System.Drawing.Color.Gainsboro;
            this.health1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.health1.Location = new System.Drawing.Point(940, 10);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(65, 19);
            this.health1.TabIndex = 11;
            this.health1.Text = "Health:";
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.BackColor = System.Drawing.Color.Gainsboro;
            this.level1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level1.Location = new System.Drawing.Point(10, 10);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(63, 19);
            this.level1.TabIndex = 10;
            this.level1.Text = "Level 4";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 20;
            this.timer4.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Player4
            // 
            this.Player4.BackColor = System.Drawing.Color.Transparent;
            this.Player4.Image = global::WindowsFormsApp1.Properties.Resources.up;
            this.Player4.Location = new System.Drawing.Point(606, 286);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(50, 100);
            this.Player4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player4.TabIndex = 15;
            this.Player4.TabStop = false;
            // 
            // door4
            // 
            this.door4.BackColor = System.Drawing.Color.Transparent;
            this.door4.Image = global::WindowsFormsApp1.Properties.Resources.door;
            this.door4.Location = new System.Drawing.Point(1130, 515);
            this.door4.Name = "door4";
            this.door4.Size = new System.Drawing.Size(124, 147);
            this.door4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.door4.TabIndex = 16;
            this.door4.TabStop = false;
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.door4);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.healthBar1);
            this.Controls.Add(this.kills1);
            this.Controls.Add(this.health1);
            this.Controls.Add(this.level1);
            this.Name = "Level4";
            this.Text = "Level4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar healthBar1;
        private System.Windows.Forms.Label kills1;
        private System.Windows.Forms.Label health1;
        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox Player4;
        private System.Windows.Forms.PictureBox door4;
    }
}