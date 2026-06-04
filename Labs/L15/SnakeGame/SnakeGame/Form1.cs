using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SnakeGame
{
    public enum Direction
    {
        Up, Down, Left, Right
    }

    public partial class Form1 : Form
    {
        private const int GridWidth = 25;
        private const int GridHeight = 25;
        private const int CellSize = 20;

        private List<Point> snake = new List<Point>();
        private Point food;
        private Direction currentDirection;
        private int score = 0;
        private bool isGameOver = false;
        private DateTime gameStartTime;

        // Измените строку подключения под свой SQL Server
        private string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=SnakeGameDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            snake.Clear();
            int centerX = GridWidth / 2;
            int centerY = GridHeight / 2;
            snake.Add(new Point(centerX, centerY));
            snake.Add(new Point(centerX - 1, centerY));
            snake.Add(new Point(centerX - 2, centerY));
            currentDirection = Direction.Right;
            score = 0;
            isGameOver = false;
            lblScore.Text = "Счёт: 0";
            GenerateFood();
            gameStartTime = DateTime.Now;
            gameTimer.Start();
            gameCanvas.Invalidate();
        }

        private void GenerateFood()
        {
            Random rand = new Random();
            do
            {
                food = new Point(rand.Next(0, GridWidth), rand.Next(0, GridHeight));
            } while (snake.Contains(food));
        }

        private void MoveSnake()
        {
            Point head = snake[0];
            Point newHead = head;

            switch (currentDirection)
            {
                case Direction.Up: newHead = new Point(head.X, head.Y - 1); break;
                case Direction.Down: newHead = new Point(head.X, head.Y + 1); break;
                case Direction.Left: newHead = new Point(head.X - 1, head.Y); break;
                case Direction.Right: newHead = new Point(head.X + 1, head.Y); break;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score += 10;
                lblScore.Text = $"Счёт: {score}";
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        private void CheckCollision()
        {
            Point head = snake[0];

            if (head.X < 0 || head.X >= GridWidth || head.Y < 0 || head.Y >= GridHeight)
            {
                GameOver();
                return;
            }

            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    GameOver();
                    return;
                }
            }
        }

        private void GameOver()
        {
            if (isGameOver) return;
            isGameOver = true;
            gameTimer.Stop();

            TimeSpan duration = DateTime.Now - gameStartTime;
            int seconds = (int)duration.TotalSeconds;

            string playerName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите ваше имя:",
                "Сохранение результата",
                "Игрок"
            );

            if (!string.IsNullOrWhiteSpace(playerName))
            {
                SaveResultToDB(playerName, score, seconds);
                MessageBox.Show("Результат сохранён в базу данных!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Результат не был сохранён (имя не введено).", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult result = MessageBox.Show("Хотите сыграть ещё раз?",
                "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                StartNewGame();
            else
                Close();
        }

        private void SaveResultToDB(string playerName, int score, int durationSec)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO GameResults (PlayerName, Score, GameDuration, GameDate) 
                                     VALUES (@name, @score, @duration, @date)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", playerName);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@duration", durationSec);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении в БД:\n{ex.Message}",
                    "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartNewGame()
        {
            InitializeGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver && e.KeyCode == Keys.Space)
            {
                StartNewGame();
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (currentDirection != Direction.Down)
                        currentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    if (currentDirection != Direction.Up)
                        currentDirection = Direction.Down;
                    break;
                case Keys.Left:
                    if (currentDirection != Direction.Right)
                        currentDirection = Direction.Left;
                    break;
                case Keys.Right:
                    if (currentDirection != Direction.Left)
                        currentDirection = Direction.Right;
                    break;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameOver) return;
            MoveSnake();
            CheckCollision();
            gameCanvas.Invalidate();
        }

        private void GameCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Блок рисования сетки полностью удалён (клеток не будет)

            // Еда (красный круг)
            using (Brush foodBrush = new SolidBrush(Color.Red))
            {
                g.FillEllipse(foodBrush, food.X * CellSize, food.Y * CellSize, CellSize, CellSize);
            }

            // Змейка
            using (Brush bodyBrush = new SolidBrush(Color.ForestGreen))
            using (Brush headBrush = new SolidBrush(Color.LimeGreen))
            {
                for (int i = 0; i < snake.Count; i++)
                {
                    var p = snake[i];
                    Rectangle rect = new Rectangle(p.X * CellSize, p.Y * CellSize, CellSize - 1, CellSize - 1);
                    if (i == 0)
                        g.FillRectangle(headBrush, rect);
                    else
                        g.FillRectangle(bodyBrush, rect);
                }
            }
        }
    }
}