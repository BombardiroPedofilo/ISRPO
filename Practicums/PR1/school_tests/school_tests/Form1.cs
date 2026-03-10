using System;
using System.Windows.Forms;

namespace school_tests
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Проверка заполнения имени и фамилии
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя и фамилию.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Сохраняем пользователя в БД
            int userId = DatabaseHelper.AddUser(txtFirstName.Text.Trim(), txtLastName.Text.Trim());

            // Открываем форму с вопросами
            FormQuestions formQuestions = new FormQuestions(userId);
            formQuestions.Show();
            this.Hide(); // скрываем стартовую форму
        }

        // Можно добавить обработку закрытия, если нужно
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Если пользователь закрывает стартовую форму, спрашиваем подтверждение
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            base.OnFormClosing(e);
        }
    }
}