using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=060JI0Hb\SQLEXPRESS02;Initial Catalog=DailyPlannerDB;Integrated Security=True";

        int selectedNoteId = -1;
        ToolTip toolTip = new ToolTip();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;

            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker1.Value = DateTime.Now;

            LoadNotes();
        }

        // Загрузка заметок
        private void LoadNotes()
        {
            listBox1.Items.Clear();

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Notes 
                                 WHERE CAST(NoteDate AS DATE)=@date 
                                 ORDER BY NoteDate";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", selectedDate);

                SqlDataReader reader = cmd.ExecuteReader();

                bool hasNotes = false;

                while (reader.Read())
                {
                    hasNotes = true;

                    int id = (int)reader["Id"];
                    DateTime date = (DateTime)reader["NoteDate"];
                    string text = reader["NoteText"].ToString();

                    string shortText = text.Length > 60 ? text.Substring(0, 60) + "..." : text;

                    listBox1.Items.Add(new NoteItem
                    {
                        Id = id,
                        Display = $"{date:HH:mm} - {shortText}",
                        FullText = text
                    });
                }

                if (!hasNotes)
                {
                    listBox1.Items.Add("Нет заметок на этот день");
                }
            }
        }

        // Класс для хранения заметки
        class NoteItem
        {
            public int Id { get; set; }
            public string Display { get; set; }
            public string FullText { get; set; }

            public override string ToString()
            {
                return Display;
            }
        }

        // Выбор даты
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadNotes();
            ClearForm();
        }

        // Добавление
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите текст заметки!");
                return;
            }

            DateTime date = monthCalendar1.SelectionStart.Date + dateTimePicker1.Value.TimeOfDay;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Notes (NoteDate, NoteText) VALUES (@date, @text)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@text", text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Заметка успешно добавлена!");

            ClearForm();
            LoadNotes();
        }

        // Выбор заметки
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem is NoteItem item))
                return;

            selectedNoteId = item.Id;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Notes WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedNoteId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["NoteText"].ToString();
                    dateTimePicker1.Value = (DateTime)reader["NoteDate"];
                }
            }
        }

        // Редактирование
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedNoteId == -1)
            {
                MessageBox.Show("Сначала выберите заметку для редактирования!");
                return;
            }

            string text = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите текст заметки!");
                return;
            }

            DateTime date = monthCalendar1.SelectionStart.Date + dateTimePicker1.Value.TimeOfDay;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Notes 
                                 SET NoteDate=@date, NoteText=@text 
                                 WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@text", text);
                cmd.Parameters.AddWithValue("@id", selectedNoteId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Заметка успешно обновлена!");

            ClearForm();
            LoadNotes();
        }

        // Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedNoteId == -1)
            {
                MessageBox.Show("Выберите заметку для удаления!");
                return;
            }

            var result = MessageBox.Show("Удалить заметку?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Notes WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedNoteId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Заметка удалена!");

            ClearForm();
            LoadNotes();
        }

        // Очистка
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            selectedNoteId = -1;
        }

        // ToolTip для длинного текста
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);

            if (index >= 0 && listBox1.Items[index] is NoteItem item)
            {
                toolTip.SetToolTip(listBox1, item.FullText);
            }
        }
    }
}