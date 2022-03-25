using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Classic_Snake_game
{
    public partial class snake_Form1 : Form
    {
        List<Circle> snake = new List<Circle>();

        Circle food = new Circle();
        Circle food2 = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;
        public snake_Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Settings.direction != "right")
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && Settings.direction != "left")
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && Settings.direction != "down")
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && Settings.direction != "up")
            {
                goDown = true;
            }

            if(e.KeyCode == Keys.R)
            {
                restartCurrentGame.Enabled = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartButtonOnClick(object sender, EventArgs e)
        {
            if(difficultySelection.Text == "Easy")
            {
                GameTimer.Interval = 80;
            }
            if (difficultySelection.Text == "Medium")
            {
                GameTimer.Interval = 50;
            }
            if (difficultySelection.Text == "Hard")
            {
                GameTimer.Interval = 20;
            }
            if(difficultySelection.Text == "Expert")
            {
                GameTimer.Interval = 1;
            }
            if(difficultySelection.Text == "")
            {
                MessageBox.Show("Please enter a difficulty!");
                return;
            }
            RestartGame();
        }

        private void RestartGame()
        {
            maxWidth = graphicGame.Width / Settings.Width -1;
            maxHeight = graphicGame.Height / Settings.Height -1;

            snake.Clear();

            StartButton.Enabled = false;
            difficultySelection.Enabled = false;
            restartCurrentGame.Enabled = false;
            txt_HighScore.ForeColor = Color.Black;
            
            score = 0;
            txt_Score.Text = "Score: " + score;

            Circle head = new Circle { X = 15, Y = 7 };
            snake.Add(head);

            for(int i = 0; i < 5; i++)
            {
                Circle body = new Circle();
                snake.Add(body);
            }
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            food2 = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            GameTimer.Start(); 
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.direction = "left";
            }
            if (goRight)
            {
                Settings.direction = "right";
            }
            if (goUp)
            {
                Settings.direction = "up";
            }
            if (goDown)
            {
                Settings.direction = "down";
            }

            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    switch (Settings.direction)
                    {
                        case "left":
                            snake[i].X--;
                            break;
                        case "right":
                            snake[i].X++;
                            break;
                        case "up":
                            snake[i].Y--;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                    }

                    if(snake[i].X > maxWidth)
                    {
                        snake[i].X = 0;
                    }
                    if(snake[i].X < 0)
                    {
                        snake[i].X = maxWidth;
                    }
                    if(snake[i].Y < 0)
                    {
                        snake[i].Y = maxHeight;
                    }
                    if(snake[i].Y > maxHeight)
                    {
                        snake[i].Y = 0;
                    }

                    if (snake[i].X == food.X && snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    if (snake[i].X == food2.X && snake[i].Y == food2.Y)
                    {
                        EatSecondFood();
                    }

                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[j].X == snake[i].X && snake[j].Y == snake[i].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
                graphicGame.Invalidate();
            }
        }

        private void snake_Form1_Load(object sender, EventArgs e)
        {
            restartCurrentGame.Enabled = false;
        }

        private void RestartStartedGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void UpdatePictureBoxAndGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < snake.Count; i++)
            {
                if(i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.DarkBlue;
                }

                canvas.FillEllipse(snakeColor, new Rectangle
                 (
                   snake[i].X * Settings.Width,
                   snake[i].Y * Settings.Height,
                   Settings.Width, Settings.Height
                 ));
            }

            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                (
                food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width, Settings.Height

                )); 
            
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                 (
                 food2.X * Settings.Width,
                 food2.Y * Settings.Height,
                 Settings.Width, Settings.Height

                 ));
        }

        private void EatFood()
        {
            score += 1;
            txt_Score.Text = "Score: " + score;

            for (int i = 1; i < 4; i++)
            {
                Circle body = new Circle
                {
                    X = snake[snake.Count - 1].X,
                    Y = snake[snake.Count - 1].Y
                };

                snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void EatSecondFood()
        {
            food2 = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        private void GameOver()
        {
            GameTimer.Stop();
            StartButton.Enabled = true;

            if(score > highScore)
            {
                highScore = score;

                txt_HighScore.Text = "High score " + highScore;
                txt_HighScore.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
        }
    }
}
