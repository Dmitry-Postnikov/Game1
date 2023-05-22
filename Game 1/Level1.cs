using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private int score1;
        private readonly List<PictureBox> zombisList = new List<PictureBox>();

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
                healthBar.Value = playerHealth;
            else
            {
                gameOver = true;
                Player1.Image = Properties.Resources.dead;
                timer1.Stop();
            }
            kills.Text = "Kills: " + score1;
            if ((goUp == true) && (Player1.Top > 35))
                Player1.Top -= playerSpeed;
            if ((goDown == true) && (Player1.Top + Player1.Height < this.ClientSize.Height))
                Player1.Top += playerSpeed;
            if ((goRight == true) && (Player1.Left + Player1.Width < this.ClientSize.Width))
                Player1.Left += playerSpeed;
            if ((goLeft == true) && (Player1.Left > 0))
                Player1.Left -= playerSpeed;
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox box && (string)i.Tag == "zombi")
                {
                    if (Player1.Bounds.IntersectsWith(i.Bounds))
                        playerHealth -= 1;
                    if (i.Top > Player1.Top)
                    {
                        i.Top -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel1Up;
                    }
                    if (i.Top < Player1.Top)
                    {
                        i.Top += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel1Down;
                    }
                    if (i.Left < Player1.Left)
                    {
                        i.Left += zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel1Right;
                    }
                    if (i.Left > Player1.Left)
                    {
                        i.Left -= zombiSpeed;
                        box.Image = Properties.Resources.zombiLevel1Left;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox box1) && ((string)j.Tag == "bullet") && (i is PictureBox box2) && ((string)i.Tag == "zombi") && (i.Bounds.IntersectsWith(j.Bounds)))
                    {
                        score1++;
                        this.Controls.Remove(j);
                        box1.Dispose();
                        this.Controls.Remove(i);
                        box2.Dispose();
                        zombisList.Remove(box2);
                        MakeZombis();
                    }
                }
            }
            if ((door1.Bounds.IntersectsWith(Player1.Bounds)) && (score1 > 9))
            {
                Level2 newLevel = new Level2();
                this.Hide();
                timer1.Stop();
                newLevel.Show();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                face = "up";
                Player1.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                face = "down";
                Player1.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                face = "right";
                Player1.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                face = "left";
                Player1.Image = Properties.Resources.left;
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
                Image = Properties.Resources.zombiLevel1Down,
                Top = randomNumber.Next(35, 495),
                Left = randomNumber.Next(0, 880),
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            zombisList.Add(zombi);
            this.Controls.Add(zombi);
            Player1.BringToFront();
        }

        private void ShootBullets(string direction)
        {
            Bullets shootBullets = new Bullets
            {
                direction = direction,
                bulletsTop = Player1.Top + (Player1.Height / 2),
                bulletsLeft = Player1.Left + (Player1.Width / 2)
            };
            shootBullets.MakeBullets(this);
        }

        private void RestartGame()
        {
            Player1.Image = Properties.Resources.up;
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
            goRight = false;
            goLeft = false;
            gameOver = false;
            playerHealth = 100;
            score1 = 0;
            timer1.Start();
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}