using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Level4 : Form
    {
        public Level4()
        {
            InitializeComponent();
            RestartGame();
        }
        private bool goUp;
        private bool goDown;
        private bool goRight;
        private bool goLeft;
        private bool gameOver;
        private string face = "up";
        private int playerHealth = 100;
        private readonly int playerSpeed = 10;
        private readonly int zombiSpeed = 3;
        private readonly Random randomNumber = new Random();
        private int score4;
        private readonly List<PictureBox> zombisList = new List<PictureBox>();

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
                healthBar1.Value = playerHealth;
            else
            {
                gameOver = true;
                Player4.Image = Properties.Resources.dead;
                timer4.Stop();
            }
            kills1.Text = "Kills: " + score4;
            if ((goUp == true) && (Player4.Top > 35))
                Player4.Top -= playerSpeed;
            if ((goDown == true) && (Player4.Top + Player4.Height < this.ClientSize.Height))
                Player4.Top += playerSpeed;
            if ((goRight == true) && (Player4.Left + Player4.Width < this.ClientSize.Width))
                Player4.Left += playerSpeed;
            if ((goLeft == true) && (Player4.Left > 0))
                Player4.Left -= playerSpeed;
            foreach (Control i in this.Controls)
            {
                if ((i is PictureBox box) && ((string)i.Tag == "zombi"))
                {
                    if (Player4.Bounds.IntersectsWith(i.Bounds))
                        playerHealth -= 4;
                    if (i.Top > Player4.Top)
                    {
                        i.Top -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel4Up;
                    }
                    if (i.Top < Player4.Top)
                    {
                        i.Top += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel4Down;
                    }
                    if (i.Left < Player4.Left)
                    {
                        i.Left += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel4Right;
                    }
                    if (i.Left > Player4.Left)
                    {
                        i.Left -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel4Left;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox box1) && ((string)j.Tag == "bullet") && (i is PictureBox box2) && ((string)i.Tag == "zombi") && (i.Bounds.IntersectsWith(j.Bounds)))
                    {
                        score4++;
                        this.Controls.Remove(j);
                        box1.Dispose();
                        this.Controls.Remove(i);
                        box2.Dispose();
                        zombisList.Remove(box2);
                        MakeZombis();
                    }
                }
            }
            if ((door4.Bounds.IntersectsWith(Player4.Bounds)) && (score4 > 4))
            {
                Level5 newLevel = new Level5();
                this.Hide();
                timer4.Stop();
                newLevel.Show();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                face = "up";
                Player4.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                face = "down";
                Player4.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                face = "right";
                Player4.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                face = "left";
                Player4.Image = Properties.Resources.left;
            }
            if (gameOver == true)
                return;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                goUp = false;
            if (e.KeyCode == Keys.S)
                goDown = false;
            if (e.KeyCode == Keys.D)
                goRight = false;
            if (e.KeyCode == Keys.A)
                goLeft = false;
            if ((e.KeyCode == Keys.Space) && (gameOver == false))
                ShootBullets(face);
            if ((e.KeyCode == Keys.Enter) && (gameOver == true))
                RestartGame();
        }

        private void MakeZombis()
        {
            PictureBox zombi = new PictureBox
            {
                Tag = "zombi",
                Image = Properties.Resources.zombiLevel4Down,
                Top = randomNumber.Next(35, 495),
                Left = randomNumber.Next(0, 880),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            zombisList.Add(zombi);
            this.Controls.Add(zombi);
            Player4.BringToFront();
        }

        private void ShootBullets(string direction)
        {
            Bullets shootBullets = new Bullets
            {
                direction = direction,
                bulletsTop = Player4.Top + (Player4.Height / 2),
                bulletsLeft = Player4.Left + (Player4.Width / 2)
            };
            shootBullets.MakeBullets(this);
        }

        private void RestartGame()
        {
            Player4.Image = Properties.Resources.up;
            for (int i1 = 0; i1 < zombisList.Count; i1++)
            {
                PictureBox i = zombisList[i1];
                this.Controls.Remove(i);
            }
            zombisList.Clear();
            for (int i = 0; i < 4; i++)
                MakeZombis();
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            playerHealth = 100;
            score4 = 0;
            timer4.Start();
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}