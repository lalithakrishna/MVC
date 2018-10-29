using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speed;
        PictureBox[] road=new PictureBox[8];
        int score;
        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox13;
            road[2] = pictureBox5;
            road[3] = pictureBox12;
            road[4] = pictureBox8;
            road[5] = pictureBox11;
            road[6] = pictureBox4;
            road[7] = pictureBox7;
        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= 7; i++)
            {
                road[i].Top += speed;
                if (road[i].Top >= this.Height)
                {
                    road[i].Top =- road[i].Height;
                }
            }

            if (score > 100 && score <= 200)
            {
                speed = 10;
            }
            if (score > 201 && score <= 300)
            {
                speed = 12;
            }
            if (score > 301 && score <= 500)
            {
                speed = 15;
            }
            if (score > 500 )
            {
                speed = 20;
            }
            Speed_Text.Text = "Speed " + speed;
            if (Car.Bounds.IntersectsWith(EnemyCar1.Bounds) || Car.Bounds.IntersectsWith(Enemycar2.Bounds) || Car.Bounds.IntersectsWith(EnemyCar3.Bounds))
            {
                gameover();
            }

        }

        private void gameover()
        {
            Replay.Visible = true;
            label1.Visible = true;
            label1.Text = "Game Over!";
            RoadMover.Stop();
            Enemytimer1.Stop();
            Enemytimer2.Stop();
            Enemytimer3.Stop();
            RightMover.Stop();
            LeftMover.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
               RightMover.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                LeftMover.Start();
            }
        }

        private void LeftMover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X > 0)
                Car.Left -= 5;
        }

        private void RightMover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X < (this.Width-60))
                Car.Left += 5;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMover.Stop();
            LeftMover.Stop();
        }

        private void Enemytimer1_Tick(object sender, EventArgs e)
        {
            Random Rnd=new Random();
            int n = Rnd.Next(0,2);
            EnemyCar1.Top += 2;
            if (EnemyCar1.Top >= this.Height)
            {
                score += 20;
                Score_Text.Text = "Score " + score;
                EnemyCar1.Top = -(Convert.ToInt32(Math.Ceiling(n * 150.0)) + EnemyCar1.Height);
                EnemyCar1.Left = Convert.ToInt32(Math.Ceiling(n * 50.0)) + 0;
            }

        }

        private void Enemytimer2_Tick(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            int n = Rnd.Next(0,2);
            Enemycar2.Top += 4;
            if (Enemycar2.Top >= this.Height)
            {
                score += 20;
                Score_Text.Text = "Score " + score;
                Enemycar2.Top = -(Convert.ToInt32(Math.Ceiling(n * 150.0)) + Enemycar2.Height);
                Enemycar2.Left = Convert.ToInt32(Math.Ceiling(n * 20.0)) + 110;
            }
        }

        private void Enemytimer3_Tick(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            int n = Rnd.Next(0,2);
            EnemyCar3.Top += 3;
            if (EnemyCar3.Top >= this.Height)
            {
                score += 20;
                Score_Text.Text = "Score " + score;
                EnemyCar3.Top = -(Convert.ToInt32(Math.Ceiling(n * 150.0)) + EnemyCar3.Height);
                EnemyCar3.Left = Convert.ToInt32(Math.Ceiling(n * 10.0)) + 170;
            }
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e,e);
        }
    }
}
