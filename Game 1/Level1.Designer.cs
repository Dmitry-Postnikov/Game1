using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.health = new System.Windows.Forms.Label();
            this.kills = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.door1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).BeginInit();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.Location = new System.Drawing.Point(940, 10);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(65, 19);
            this.health.TabIndex = 1;
            this.health.Text = "Health:";
            // 
            // kills
            // 
            this.kills.AutoSize = true;
            this.kills.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kills.Location = new System.Drawing.Point(1176, 10);
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(65, 19);
            this.kills.TabIndex = 2;
            this.kills.Text = "Kills: 0";
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level1.Location = new System.Drawing.Point(10, 10);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(63, 19);
            this.level1.TabIndex = 3;
            this.level1.Text = "Level 1";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(1011, 10);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(150, 20);
            this.healthBar.TabIndex = 4;
            this.healthBar.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Image = ((System.Drawing.Image)(resources.GetObject("Player1.Image")));
            this.Player1.Location = new System.Drawing.Point(584, 287);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(50, 100);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.Transparent;
            this.door1.Image = global::WindowsFormsApp1.Properties.Resources.door;
            this.door1.Location = new System.Drawing.Point(1130, 515);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(124, 147);
            this.door1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.door1.TabIndex = 15;
            this.door1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.door1);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.kills);
            this.Controls.Add(this.health);
            this.Controls.Add(this.Player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label kills;
        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Timer timer1;
        private PictureBox door1;
    }
}

