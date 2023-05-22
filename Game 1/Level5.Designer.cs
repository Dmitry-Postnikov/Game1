namespace WindowsFormsApp1
{
    partial class Level5
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
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.door5 = new System.Windows.Forms.PictureBox();
            this.Player5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player5)).BeginInit();
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
            this.kills1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kills1.Location = new System.Drawing.Point(1176, 10);
            this.kills1.Name = "kills1";
            this.kills1.Size = new System.Drawing.Size(65, 19);
            this.kills1.TabIndex = 12;
            this.kills1.Text = "Kills: 0";
            // 
            // health1
            // 
            this.health1.AutoSize = true;
            this.health1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health1.Location = new System.Drawing.Point(940, 10);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(65, 19);
            this.health1.TabIndex = 11;
            this.health1.Text = "Health:";
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level1.Location = new System.Drawing.Point(10, 10);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(63, 19);
            this.level1.TabIndex = 10;
            this.level1.Text = "Level 5";
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 20;
            this.timer5.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // door5
            // 
            this.door5.BackColor = System.Drawing.Color.Transparent;
            this.door5.Image = global::WindowsFormsApp1.Properties.Resources.door;
            this.door5.Location = new System.Drawing.Point(1130, 515);
            this.door5.Name = "door5";
            this.door5.Size = new System.Drawing.Size(124, 147);
            this.door5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.door5.TabIndex = 14;
            this.door5.TabStop = false;
            // 
            // Player5
            // 
            this.Player5.BackColor = System.Drawing.Color.Transparent;
            this.Player5.Image = global::WindowsFormsApp1.Properties.Resources.up;
            this.Player5.Location = new System.Drawing.Point(578, 283);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(50, 100);
            this.Player5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player5.TabIndex = 15;
            this.Player5.TabStop = false;
            // 
            // Level5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Player5);
            this.Controls.Add(this.door5);
            this.Controls.Add(this.healthBar1);
            this.Controls.Add(this.kills1);
            this.Controls.Add(this.health1);
            this.Controls.Add(this.level1);
            this.Name = "Level5";
            this.Text = "Level5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.door5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox door5;
        private System.Windows.Forms.ProgressBar healthBar1;
        private System.Windows.Forms.Label kills1;
        private System.Windows.Forms.Label health1;
        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.PictureBox Player5;
    }
}