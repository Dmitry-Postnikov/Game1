using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Bullets
    {
        public string direction;
        public int bulletsTop;
        public int bulletsLeft;
        private readonly int speed = 15;
        private Timer bulletsTimer = new Timer();
        private PictureBox bullets = new PictureBox();

        public void MakeBullets(Form form)
        {
            bullets.BackColor = Color.DarkBlue;
            bullets.Size = new Size(7, 7);
            bullets.Tag = "bullet";
            bullets.Top = bulletsTop;
            bullets.Left = bulletsLeft;
            bullets.BringToFront();
            form.Controls.Add(bullets);
            bulletsTimer.Interval = speed;
            bulletsTimer.Tick += new EventHandler(BulletsTimerEvent);
            bulletsTimer.Start();
        }

        private void BulletsTimerEvent(object sender, EventArgs e)
        {
            if (direction == "up")
                bullets.Top -= speed;
            if (direction == "down")
                bullets.Top += speed;
            if (direction == "right")
                bullets.Left += speed;
            if (direction == "left")
                bullets.Left -= speed;
            if ((bullets.Left < 1) || (bullets.Left > 920) || (bullets.Top < 10) || (bullets.Top > 540))
            {
                bulletsTimer.Stop();
                bulletsTimer.Dispose();
                bullets.Dispose();
                bulletsTimer = null;
                bullets = null;
            }
        }
    }
}