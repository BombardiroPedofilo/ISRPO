using System;
using System.Windows.Forms;
using PublishingApp.Models;

namespace PublishingApp
{
    public partial class MainForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public MainForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                var books = db.GetBooks();
                dataGridViewBooks.DataSource = books;
                dataGridViewBooks.Columns["Id"].Visible = false;
                dataGridViewBooks.Columns["AuthorId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки книг: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите книгу для предзаказа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewBooks.SelectedRows[0];
            var book = new Book
            {
                Id = (int)selectedRow.Cells["Id"].Value,
                Title = selectedRow.Cells["Title"].Value.ToString(),
                AuthorName = selectedRow.Cells["AuthorName"].Value.ToString(),
                Price = 500 // Базовая цена
            };

            var orderForm = new FormOrder(book);
            orderForm.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}