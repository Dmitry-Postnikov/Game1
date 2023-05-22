using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Level5 : Form
    {
        public Level5()
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
        private int score5;
        private readonly List<PictureBox> zombisList = new List<PictureBox>();

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
                healthBar1.Value = playerHealth;
            else
            {
                gameOver = true;
                Player5.Image = Properties.Resources.dead;
                timer5.Stop();
            }
            kills1.Text = "Kills: " + score5;
            if ((goUp == true) && (Player5.Top > 35))
                Player5.Top -= playerSpeed;
            if ((goDown == true) && (Player5.Top + Player5.Height < this.ClientSize.Height))
                Player5.Top += playerSpeed;
            if ((goRight == true) && (Player5.Left + Player5.Width < this.ClientSize.Width))
                Player5.Left += playerSpeed;
            if ((goLeft == true) && (Player5.Left > 0))
                Player5.Left -= playerSpeed;
            foreach (Control i in this.Controls)
            {
                if ((i is PictureBox box) && ((string)i.Tag == "zombi"))
                {
                    if (Player5.Bounds.IntersectsWith(i.Bounds))
                        playerHealth -= 5;
                    if (i.Top > Player5.Top)
                    {
                        i.Top -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel5Up;
                    }
                    if (i.Top < Player5.Top)
                    {
                        i.Top += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel5Down;
                    }
                    if (i.Left < Player5.Left)
                    {
                        i.Left += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel5Right;
                    }
                    if (i.Left > Player5.Left)
                    {
                        i.Left -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel5Left;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox box1) && ((string)j.Tag == "bullet") && (i is PictureBox box2) && ((string)i.Tag == "zombi") && (i.Bounds.IntersectsWith(j.Bounds)))
                    {
                        score5++;
                        this.Controls.Remove(j);
                        box1.Dispose();
                        this.Controls.Remove(i);
                        box2.Dispose();
                        zombisList.Remove(box2);
                        MakeZombis();
                    }
                }
            }
            if ((door5.Bounds.IntersectsWith(Player5.Bounds)) && (score5 > 2))
            {
                End newLevel = new End();
                this.Hide();
                timer5.Stop();
                newLevel.Show();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                face = "up";
                Player5.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                face = "down";
                Player5.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                face = "right";
                Player5.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                face = "left";
                Player5.Image = Properties.Resources.left;
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
                Image = Properties.Resources.zombiLevel5Down,
                Top = randomNumber.Next(35, 495),
                Left = randomNumber.Next(0, 880),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            zombisList.Add(zombi);
            this.Controls.Add(zombi);
            Player5.BringToFront();
        }

        private void ShootBullets(string direction)
        {
            Bullets shootBullets = new Bullets
            {
                direction = direction,
                bulletsTop = Player5.Top + (Player5.Height / 2),
                bulletsLeft = Player5.Left + (Player5.Width / 2)
            };
            shootBullets.MakeBullets(this);
        }

        private void RestartGame()
        {
            Player5.Image = Properties.Resources.up;
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
            score5 = 0;
            timer5.Start();
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}