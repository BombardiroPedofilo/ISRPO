using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using PublishingApp.Models;

namespace PublishingApp
{
    public partial class FormReceipt : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private Order order;

        public FormReceipt(int orderId)
        {
            InitializeComponent();
            LoadOrderDetails(orderId);
        }

        private void LoadOrderDetails(int orderId)
        {
            try
            {
                order = db.GetOrderDetails(orderId);

                if (order != null)
                {
                    labelOrderNumber.Text = $"Заказ №{order.Id}";
                    labelBookTitle.Text = order.BookTitle;
                    labelCustomerName.Text = order.CustomerName;
                    labelOffice.Text = order.OfficeName;
                    labelOrderDate.Text = order.OrderDate.ToString("dd.MM.yyyy HH:mm");
                    labelPrice.Text = $"{order.Price} руб.";
                }
                else
                {
                    MessageBox.Show("Заказ не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFileDialog.FileName = $"Чек_заказа_{order.Id}.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string receiptText = $"ЧЕК ПРЕДЗАКАЗА\n" +
                                       $"================\n" +
                                       $"Номер заказа: {order.Id}\n" +
                                       $"Книга: {order.BookTitle}\n" +
                                       $"Клиент: {order.CustomerName}\n" +
                                       $"Офис выдачи: {order.OfficeName}\n" +
                                       $"Дата оформления: {order.OrderDate:dd.MM.yyyy HH:mm}\n" +
                                       $"Сумма: {order.Price} руб.\n" +
                                       $"================\n" +
                                       $"Спасибо за предзаказ!";

                    System.IO.File.WriteAllText(saveFileDialog.FileName, receiptText);
                    MessageBox.Show("Чек сохранен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}