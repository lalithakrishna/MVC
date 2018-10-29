using MyGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        private List<Circle>snake=new List<Circle>();
        private Circle food=new Circle();
        public Form1()
        {
            InitializeComponent();

            //set settings to default
            new Settings();

            //set game speed and start timer
            GameTimer.Interval = 10000/Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            //start new game
            StartGame();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //check for game over 
            if (Settings.GameOver == true)
            {
                //check if enter is pressed
                if (Inputs.keyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Inputs.keyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Inputs.keyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Inputs.keyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Inputs.keyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }
            pbCanvas.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            snake[i].x++;
                            break;
                        case Direction.Left:
                            snake[i].x--;
                            break;
                        case Direction.Up:
                            snake[i].y--;
                            break;
                        case Direction.Down:
                            snake[i].y++;
                            break;
                    }

                    //get maximum x and y pos
                    int maxXPos = pbCanvas.Size.Width / Settings.width;
                    int maxYPos = pbCanvas.Size.Height / Settings.height;

                    //detect collisions with game borders
                    if (snake[i].x < 0 || snake[i].y < 0 || snake[i].x > maxXPos || snake[i].y > maxYPos)
                    {
                        Die();
                    }

                    //detect collision with body
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x && snake[i].y == snake[j].y)
                        {
                            Die();
                        }
                    }

                    //detect collision with food
                    if (snake[0].x == food.x && snake[0].y == food.y)
                    {
                        Eat();
                    }

                }
                else
                {
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }
            }
        }

        private void Eat()
        {
            //add circle to the body
            Circle food=new Circle();
            food.x = snake[snake.Count-1].x;
            food.y = snake[snake.Count-1].y;
            snake.Add(food);

            //update score
            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();

            Generatefood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void StartGame()
        {
            lblGameover.Visible = false;
            //set settings to default
            new Settings();

            //cretae new player object
            snake.Clear();
            Circle head=new Circle();
            head.x = 10;
            head.y = 5;
            snake.Add(head);

            labelScore.Text = Settings.Score.ToString();
            Generatefood();
        }
        
        //Place random food in game
        private void Generatefood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.width;
            int maxYPos= pbCanvas.Size.Height / Settings.height;

            Random random=new Random();
            food=new Circle();
            food.x = random.Next(0, maxXPos);
            food.y = random.Next(0, maxYPos);
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
             if (Settings.GameOver != true)
            {
                //set snake colour 
                Brush snakecolour;

                //Draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakecolour = Brushes.Black; //for head
                    }
                    else
                    {
                        snakecolour = Brushes.Green; // rest of the body
                    }

                    //draw snake
                    canvas.FillEllipse(snakecolour,
                        new Rectangle(snake[i].x * Settings.width,
                                      snake[i].y * Settings.height,
                                      Settings.width, Settings.height));
                    //draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.x * Settings.width,
                                      food.y * Settings.height,
                                      Settings.width, Settings.height));
                }
            }
            else
            {
                string gameover = "Game Over\n Your final Score is: " + Settings.Score + "\nPress Enter to try again!";
                lblGameover.Text = gameover;
                lblGameover.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           Inputs.changeState(e.KeyCode,true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Inputs.changeState(e.KeyCode,false);
        }
    }
}
