using System;
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
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            base.OnFormClosing(e);
        }
    }
}