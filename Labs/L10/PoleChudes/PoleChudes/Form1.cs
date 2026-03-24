using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PoleChudes
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=060JI0HB\SQLEXPRESS02;Initial Catalog=PoleChudesDB;Integrated Security=True";

        string originalWord = "";
        Stack<Button> history = new Stack<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        void StartGame()
        {
            flowLetters.Controls.Clear();
            history.Clear();
            txtResult.Text = "";

            originalWord = GetRandomWord().ToUpper();

            var shuffled = originalWord.ToCharArray()
                .OrderBy(x => Guid.NewGuid())
                .ToList();

            foreach (char c in shuffled)
            {
                Button btn = new Button();
                btn.Text = c.ToString();
                btn.Width = 60;
                btn.Height = 60;
                btn.Font = new System.Drawing.Font("Segoe UI", 16);
                btn.BackColor = System.Drawing.Color.LightSkyBlue;

                btn.Click += Letter_Click;

                flowLetters.Controls.Add(btn);
            }
        }

        string GetRandomWord()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Word FROM Words ORDER BY NEWID()", conn);
                return cmd.ExecuteScalar().ToString();
            }
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            txtResult.Text += btn.Text;
            history.Push(btn);

            btn.Enabled = false;
            btn.BackColor = System.Drawing.Color.LightGray;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                Button btn = history.Pop();

                btn.Enabled = true;
                btn.BackColor = System.Drawing.Color.LightSkyBlue;

                if (txtResult.Text.Length > 0)
                    txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Normalize(txtResult.Text) == Normalize(originalWord))
                MessageBox.Show("✅ Правильно!", "Результат");
            else
                MessageBox.Show("❌ Неправильно!", "Результат");
        }

        string Normalize(string s)
        {
            return s.Replace('Ё', 'Е');
        }
    }
}