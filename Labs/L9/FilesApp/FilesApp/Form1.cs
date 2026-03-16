using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace FilesApp
{
    public partial class SimbolsCount : Form
    {
        // === НАСТРОЙКА ПОДКЛЮЧЕНИЯ К БАЗЕ ДАННЫХ ===
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=FileHistoryDB;Integrated Security=True";

        public SimbolsCount()
        {
            InitializeComponent();
            // При запуске проверяем/создаём базу данных и таблицу
            EnsureDatabaseAndTable();
        }

        // Проверка наличия базы данных и таблицы; создание при необходимости
        private void EnsureDatabaseAndTable()
        {
            try
            {
                // Подключаемся к master, чтобы проверить существование базы FileHistoryDB
                using (var masterConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
                {
                    masterConnection.Open();
                    string checkDbQuery = "SELECT database_id FROM sys.databases WHERE Name = 'FileHistoryDB'";
                    using (var cmd = new SqlCommand(checkDbQuery, masterConnection))
                    {
                        var dbId = cmd.ExecuteScalar();
                        if (dbId == null) // базы нет – создаём
                        {
                            string createDbQuery = "CREATE DATABASE FileHistoryDB";
                            using (var createCmd = new SqlCommand(createDbQuery, masterConnection))
                            {
                                createCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                // Теперь подключаемся к созданной базе и создаём таблицу, если её нет
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkTableQuery = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='FileOperations' AND xtype='U')
                        BEGIN
                            CREATE TABLE FileOperations (
                                Id INT PRIMARY KEY IDENTITY(1,1),
                                FilePath NVARCHAR(500),
                                Content NVARCHAR(MAX),
                                SymbolCount INT,
                                OperationType NVARCHAR(50),
                                OperationDate DATETIME DEFAULT GETDATE()
                            )
                        END";
                    using (var cmd = new SqlCommand(checkTableQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Если ошибка – покажем предупреждение, но программа продолжит работу
                MessageBox.Show($"Ошибка при инициализации базы данных: {ex.Message}\nПроверьте строку подключения.",
                                "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Сохранение операции в БД (только вставка)
        private void SaveToDatabase(string filePath, string content, int symbolCount, string operationType)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO FileOperations (FilePath, Content, SymbolCount, OperationType)
                        VALUES (@FilePath, @Content, @SymbolCount, @OperationType)";
                    using (var cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FilePath", filePath ?? "Без пути");
                        cmd.Parameters.AddWithValue("@Content", content ?? "");
                        cmd.Parameters.AddWithValue("@SymbolCount", symbolCount);
                        cmd.Parameters.AddWithValue("@OperationType", operationType);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Ошибки записи в БД не мешают основной работе – просто логируем
                System.Diagnostics.Debug.WriteLine($"Ошибка при сохранении в БД: {ex.Message}");
            }
        }

        // Открытие файла
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = openFileDialog.FileName;
                    try
                    {
                        string content = File.ReadAllText(openFileDialog.FileName);
                        txtText.Text = content;
                        UpdateSymbolCount(); // подсчёт символов
                        SaveToDatabase(openFileDialog.FileName, content, txtText.Text.Length, "Open");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Подсчёт символов по кнопке
        private void btnCountUp_Click(object sender, EventArgs e)
        {
            UpdateSymbolCount();
        }

        private void UpdateSymbolCount()
        {
            txtCount.Text = txtText.Text.Length.ToString();
        }

        // Сохранение файла
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        txtPath.Text = saveFileDialog.FileName;
                    else
                        return;
                }
            }

            try
            {
                File.WriteAllText(txtPath.Text, txtText.Text);
                SaveToDatabase(txtPath.Text, txtText.Text, txtText.Text.Length, "Save");
                MessageBox.Show("Файл успешно сохранён.", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Очистка полей
        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtText.Clear();
            txtCount.Clear();
            txtPath.Clear();
            txtText.ResetText();
        }

        // Выход (закрытие формы)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // вызовет OnFormClosing
        }

        // Подтверждение выхода
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?",
                                                   "Подтверждение выхода",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
            else
                base.OnFormClosing(e);
        }
    }
}