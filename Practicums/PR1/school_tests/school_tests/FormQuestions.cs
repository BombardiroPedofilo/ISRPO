using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using CuoreUI.Controls; // для удобства (можно и не добавлять, если использовать полные имена)

namespace school_tests
{
    public partial class FormQuestions : Form
    {
        private int userId;
        private DataTable questionsTable;
        private int currentIndex = 0;
        private int totalQuestions;
        private int timeLeft = 25 * 60; // 25 минут в секундах
        private System.Windows.Forms.Timer timer;

        private Dictionary<int, int?> userAnswers = new Dictionary<int, int?>(); // временное хранение

        public FormQuestions(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadQuestions();
            totalQuestions = questionsTable.Rows.Count;
            lblProgress.Text = $"Вопрос {currentIndex + 1} из {totalQuestions}";
            ShowQuestion(currentIndex);
            InitializeTimer();
        }

        private void LoadQuestions()
        {
            questionsTable = DatabaseHelper.GetQuestions();
            foreach (DataRow row in questionsTable.Rows)
            {
                int qid = Convert.ToInt32(row["Id"]);
                userAnswers[qid] = null;
            }
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateTimerDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            UpdateTimerDisplay();
            if (timeLeft <= 0)
            {
                timer.Stop();
                MessageBox.Show("Время вышло! Тест завершается.", "Время истекло");
                FinishTest();
            }
        }

        private void UpdateTimerDisplay()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lblTimer.Text = $"Осталось времени: {minutes:D2}:{seconds:D2}";
        }

        private void ShowQuestion(int index)
        {
            DataRow row = questionsTable.Rows[index];
            lblQuestion.Text = row["QuestionText"].ToString();
            // Используем Content вместо Text
            radioOption1.Content = row["Option1"].ToString();
            radioOption2.Content = row["Option2"].ToString();
            radioOption3.Content = row["Option3"].ToString();
            radioOption4.Content = row["Option4"].ToString();

            radioOption1.Checked = false;
            radioOption2.Checked = false;
            radioOption3.Checked = false;
            radioOption4.Checked = false;

            int qid = Convert.ToInt32(row["Id"]);
            if (userAnswers.ContainsKey(qid) && userAnswers[qid].HasValue)
            {
                int selected = userAnswers[qid].Value;
                switch (selected)
                {
                    case 1: radioOption1.Checked = true; break;
                    case 2: radioOption2.Checked = true; break;
                    case 3: radioOption3.Checked = true; break;
                    case 4: radioOption4.Checked = true; break;
                }
            }

            btnPrevious.Enabled = (index > 0);
            btnNext.Content = (index == totalQuestions - 1) ? "Завершить" : "Далее"; // у btnNext тоже Content, но там уже установлено в дизайнере, можно не менять
        }

        private void SaveCurrentAnswer()
        {
            int qid = Convert.ToInt32(questionsTable.Rows[currentIndex]["Id"]);
            int? selected = null;
            if (radioOption1.Checked) selected = 1;
            else if (radioOption2.Checked) selected = 2;
            else if (radioOption3.Checked) selected = 3;
            else if (radioOption4.Checked) selected = 4;

            userAnswers[qid] = selected;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();

            if (currentIndex == totalQuestions - 1)
            {
                FinishTest();
            }
            else
            {
                currentIndex++;
                lblProgress.Text = $"Вопрос {currentIndex + 1} из {totalQuestions}";
                ShowQuestion(currentIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            if (currentIndex > 0)
            {
                currentIndex--;
                lblProgress.Text = $"Вопрос {currentIndex + 1} из {totalQuestions}";
                ShowQuestion(currentIndex);
            }
        }

        private void FinishTest()
        {
            timer.Stop();

            // Вычисляем затраченное время (в секундах)
            int timeSpent = (25 * 60) - timeLeft; // если тест завершён досрочно, timeLeft > 0, иначе 0

            // Сохраняем ответы пользователя
            foreach (DataRow row in questionsTable.Rows)
            {
                int qid = Convert.ToInt32(row["Id"]);
                int correct = Convert.ToInt32(row["CorrectOption"]);
                int? selected = userAnswers[qid];
                bool isCorrect = (selected.HasValue && selected.Value == correct);
                DatabaseHelper.SaveAnswer(userId, qid, selected, isCorrect);
            }

            // Обновляем длительность теста для пользователя
            DatabaseHelper.UpdateUserDuration(userId, timeSpent);

            int correctCount = DatabaseHelper.GetCorrectAnswersCount(userId);
            int total = DatabaseHelper.GetTotalQuestionsCount();

            FormFinish formFinish = new FormFinish(userId, correctCount, total);
            formFinish.Show();
            this.Close();
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    if (timeLeft > 0 && currentIndex < totalQuestions - 1)
        //    {
        //        var result = MessageBox.Show("Вы уверены, что хотите прервать тест?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.No)
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //    base.OnFormClosing(e);
        //}
    }
}