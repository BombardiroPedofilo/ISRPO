using System;
using System.Data;
using System.Windows.Forms;

namespace school_tests
{
    public partial class FormFinish : Form
    {
        private int userId;
        private int correctCount;
        private int totalQuestions;

        public FormFinish(int userId, int correctCount, int totalQuestions)
        {
            InitializeComponent();
            this.userId = userId;
            this.correctCount = correctCount;
            this.totalQuestions = totalQuestions;

            // Вычисляем процент
            double percent = (double)correctCount / totalQuestions * 100;
            int percentInt = (int)Math.Round(percent);

            // Отображаем текстовый результат
            lblResult.Text = $"Вы ответили правильно на {correctCount} из {totalQuestions} вопросов.";
            lblPercent.Text = $"{percentInt}%";

            // Устанавливаем значения прогресс-баров
            circularProgress.MaximumValue = 100;
            circularProgress.ProgressValue = percentInt;
            
            LoadHistory();

        }

        private void LoadHistory()
        {
            DataTable history = DatabaseHelper.GetUserHistory();

            // Добавляем вычисляемые столбцы
            history.Columns.Add("Percentage", typeof(string));
            history.Columns.Add("TimeSpent", typeof(string));

            foreach (DataRow row in history.Rows)
            {
                int correct = row["CorrectAnswers"] != DBNull.Value ? Convert.ToInt32(row["CorrectAnswers"]) : 0;
                int total = Convert.ToInt32(row["TotalQuestions"]);
                double percent = (double)correct / total * 100;
                row["Percentage"] = $"{percent:F1}%";

                int? duration = row["Duration"] != DBNull.Value ? Convert.ToInt32(row["Duration"]) : (int?)null;
                if (duration.HasValue)
                {
                    TimeSpan ts = TimeSpan.FromSeconds(duration.Value);
                    row["TimeSpent"] = ts.ToString(@"mm\:ss");
                }
                else
                {
                    row["TimeSpent"] = "-";
                }
            }

            dgvHistory.DataSource = history;

            // Настройка заголовков столбцов
            dgvHistory.Columns["FirstName"].HeaderText = "Имя";
            dgvHistory.Columns["LastName"].HeaderText = "Фамилия";
            dgvHistory.Columns["TestDate"].HeaderText = "Дата";
            dgvHistory.Columns["CorrectAnswers"].HeaderText = "Правильных";
            dgvHistory.Columns["TotalQuestions"].HeaderText = "Всего";
            dgvHistory.Columns["Percentage"].HeaderText = "Процент";
            dgvHistory.Columns["TimeSpent"].HeaderText = "Время";
            dgvHistory.Columns["Duration"].Visible = false; // скрываем исходный столбец

            dgvHistory.Columns["FirstName"].Width = 100;
            dgvHistory.Columns["LastName"].Width = 100;
            dgvHistory.Columns["TestDate"].Width = 120;
            dgvHistory.Columns["CorrectAnswers"].Width = 100;
            dgvHistory.Columns["TotalQuestions"].Width = 60;
            dgvHistory.Columns["Percentage"].Width = 70;
            dgvHistory.Columns["TimeSpent"].Width = 70;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Останавливаем анимацию кругового прогресс-бара
            if (circularProgress != null)
            {
                
                circularProgress.Enabled = false;

                circularProgress.Dispose();
            }

            // Вызываем базовый метод
            base.OnFormClosing(e);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show("Вы уверены, что хотите пройти тест заново?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormStart formStart = new FormStart();
                formStart.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          this.Close();

        }

        
    }
}