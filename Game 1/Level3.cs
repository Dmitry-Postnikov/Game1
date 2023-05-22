using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Level3 : Form
    {
        public Level3()
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
        private int score3;
        private readonly List<PictureBox> zombisList = new List<PictureBox>();

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
                healthBar1.Value = playerHealth;
            else
            {
                gameOver = true;
                Player3.Image = Properties.Resources.dead;
                timer3.Stop();
            }
            kills1.Text = "Kills: " + score3;
            if ((goUp == true) && (Player3.Top > 35))
                Player3.Top -= playerSpeed;
            if ((goDown == true) && (Player3.Top + Player3.Height < this.ClientSize.Height))
                Player3.Top += playerSpeed;
            if ((goRight == true) && (Player3.Left + Player3.Width < this.ClientSize.Width))
                Player3.Left += playerSpeed;
            if ((goLeft == true) && (Player3.Left > 0))
                Player3.Left -= playerSpeed;
            foreach (Control i in this.Controls)
            {
                if ((i is PictureBox box) && ((string)i.Tag == "zombi"))
                {
                    if (Player3.Bounds.IntersectsWith(i.Bounds))
                        playerHealth -= 3;
                    if (i.Top > Player3.Top)
                    {
                        i.Top -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel3Up;
                    }
                    if (i.Top < Player3.Top)
                    {
                        i.Top += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel3Down;
                    }
                    if (i.Left < Player3.Left)
                    {
                        i.Left += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel3Right;
                    }
                    if (i.Left > Player3.Left)
                    {
                        i.Left -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel3Left;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox box1) && ((string)j.Tag == "bullet") && (i is PictureBox box2) && ((string)i.Tag == "zombi") && (i.Bounds.IntersectsWith(j.Bounds)))
                    {
                        score3++;
                        this.Controls.Remove(j);
                        box1.Dispose();
                        this.Controls.Remove(i);
                        box2.Dispose();
                        zombisList.Remove(box2);
                        MakeZombis();
                    }
                }
            }
            if ((door3.Bounds.IntersectsWith(Player3.Bounds)) && (score3 > 6))
            {
                Level4 newLevel = new Level4();
                this.Hide();
                timer3.Stop();
                newLevel.Show();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                face = "up";
                Player3.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                face = "down";
                Player3.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                face = "right";
                Player3.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                face = "left";
                Player3.Image = Properties.Resources.left;
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
                Image = Properties.Resources.zombiLevel3Down,
                Top = randomNumber.Next(35, 495),
                Left = randomNumber.Next(0, 880),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            zombisList.Add(zombi);
            this.Controls.Add(zombi);
            Player3.BringToFront();
        }

        private void ShootBullets(string direction)
        {
            Bullets shootBullets = new Bullets
            {
                direction = direction,
                bulletsTop = Player3.Top + (Player3.Height / 2),
                bulletsLeft = Player3.Left + (Player3.Width / 2)
            };
            shootBullets.MakeBullets(this);
        }

        private void RestartGame()
        {
            Player3.Image = Properties.Resources.up;
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
            score3 = 0;
            timer3.Start();
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}