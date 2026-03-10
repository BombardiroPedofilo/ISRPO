using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SkladApp
{
    public partial class Sklad : Form
    {
        private string connectionString = @"Data Source=TTekaPH9I\SQLEXPRESS;Initial Catalog=sklad;Integrated Security=True;Encrypt=False";
        private DataTable table;
        private SqlDataAdapter adapter;
        private int currentProductId = -1;

        public Sklad()
        {
            InitializeComponent();
            SetupDB();
            LoadData();
        }

        private void SetupDB()
        {
            table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM products", connectionString);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = commandBuilder.GetInsertCommand();
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
        }

        private void LoadData()
        {
            try
            {
                table.Clear();
                adapter.Fill(table);
                dataGridViewProducts.DataSource = table;
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0 && dataGridViewProducts.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                if (!selectedRow.IsNewRow)
                {
                    try
                    {
                        currentProductId = (int)selectedRow.Cells["id"].Value;
                        textBoxName.Text = selectedRow.Cells["name"].Value?.ToString() ?? "";
                        textBoxStillage.Text = selectedRow.Cells["stillage"].Value?.ToString() ?? "";
                        textBoxCell.Text = selectedRow.Cells["cell"].Value?.ToString() ?? "";
                        textBoxQuantity.Text = selectedRow.Cells["quantity"].Value?.ToString() ?? "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataRow newRow = table.NewRow();
            newRow["name"] = textBoxName.Text;
            newRow["stillage"] = int.Parse(textBoxStillage.Text);
            newRow["cell"] = int.Parse(textBoxCell.Text);
            newRow["quantity"] = int.Parse(textBoxQuantity.Text);

            table.Rows.Add(newRow);
            ClearForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (currentProductId == -1) return;
            if (!ValidateInput()) return;

            DataRow[] rows = table.Select($"id = {currentProductId}");
            if (rows.Length > 0)
            {
                rows[0]["name"] = textBoxName.Text;
                rows[0]["stillage"] = int.Parse(textBoxStillage.Text);
                rows[0]["cell"] = int.Parse(textBoxCell.Text);
                rows[0]["quantity"] = int.Parse(textBoxQuantity.Text);
                ClearForm();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0) return;

            foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
            {
                table.Rows[row.Index].Delete();
            }
            ClearForm();
        }

        private void buttonSaveToDb_Click(object sender, EventArgs e)
        {
            try
            {
                int changes = adapter.Update(table);
                MessageBox.Show($"Сохранено записей: {changes}");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = $"name LIKE '%{textBoxSearchName.Text}%'";
            dataGridViewProducts.DataSource = dv;
        }

        private void buttonSearchByCoords_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = $"stillage = {textBoxSearchStillage.Text} AND cell = {textBoxSearchCell.Text}";
            dataGridViewProducts.DataSource = dv;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название!");
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            currentProductId = -1;
            textBoxName.Clear();
            textBoxStillage.Clear();
            textBoxCell.Clear();
            textBoxQuantity.Clear();
        }
    }
}