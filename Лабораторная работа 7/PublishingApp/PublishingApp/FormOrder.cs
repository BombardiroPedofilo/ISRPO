using System;
using System.Windows.Forms;
using PublishingApp.Models;

namespace PublishingApp
{
    public partial class FormOrder : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private Book selectedBook;

        public FormOrder(Book book)
        {
            InitializeComponent();
            selectedBook = book;
            LoadOffices();
            DisplayBookInfo();
        }

        private void DisplayBookInfo()
        {
            labelBookTitle.Text = selectedBook.Title;
            labelAuthor.Text = selectedBook.AuthorName;
            labelPrice.Text = $"{selectedBook.Price} руб.";
        }

        private void LoadOffices()
        {
            try
            {
                var offices = db.GetOffices();
                comboBoxOffice.DataSource = offices;
                comboBoxOffice.DisplayMember = "FullInfo";
                comboBoxOffice.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки офисов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите ФИО клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон для связи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxOffice.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите офис получения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Создание клиента (БЕЗ EMAIL)
                var customer = new Customer
                {
                    Name = textBoxName.Text,
                    Address = textBoxAddress.Text,
                    Phone = textBoxPhone.Text
                    
                };

                int customerId = db.CreateCustomer(customer);

                if (customerId <= 0)
                {
                    MessageBox.Show("Ошибка создания клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание заказа
                var order = new Order
                {
                    BookId = selectedBook.Id,
                    CustomerId = customerId,
                    OfficeId = (int)comboBoxOffice.SelectedValue,
                    OrderDate = DateTime.Now,
                    Price = selectedBook.Price
                };

                int orderId = db.CreateOrder(order);

                if (orderId <= 0)
                {
                    MessageBox.Show("Ошибка создания заказа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Открытие формы чека
                var receiptForm = new FormReceipt(orderId);
                receiptForm.ShowDialog();  
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}