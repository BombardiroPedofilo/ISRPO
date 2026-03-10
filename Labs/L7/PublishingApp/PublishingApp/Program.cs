using System;
using System.Windows.Forms;

namespace PublishingApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Тест подключения к БД
            using (var db = new DatabaseHelper())
            {
                if (!db.TestConnection())
                {
                    MessageBox.Show("Не удалось подключиться к базе данных. Проверьте настройки подключения.",
                        "Ошибка подключения",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            Application.Run(new MainForm());
        }
    }
}