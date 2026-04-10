using System;
using System.Data;
using System.Windows.Forms;

namespace NumberApp
{
    public partial class MainForm : Form
    {
        private HistoryStorage storage;
        private string currentSourceNumber;
        private int currentSourceBase;
        private string currentTargetNumber;
        private int currentTargetBase;

        public MainForm()
        {
            InitializeComponent();
            storage = new HistoryStorage();
            InitializeCustomSettings();
            RefreshHistoryGrid();
        }

        private void InitializeCustomSettings()
        {
            // Заполнение выпадающих списков
            cmbSourceBase.Items.AddRange(new object[] { "Двоичная (2)", "Восьмеричная (8)", "Десятичная (10)", "Шестнадцатеричная (16)" });
            cmbTargetBase.Items.AddRange(new object[] { "Двоичная (2)", "Восьмеричная (8)", "Десятичная (10)", "Шестнадцатеричная (16)" });
            cmbSourceBase.SelectedIndex = 2;  // десятичная
            cmbTargetBase.SelectedIndex = 2;

            // Подписка на события
            txtSourceNumber.TextChanged += TxtSourceNumber_TextChanged;
            btnPerformConversion.Click += BtnPerformConversion_Click;
            btnStoreConversion.Click += BtnStoreConversion_Click;
        }

        private void TxtSourceNumber_TextChanged(object sender, EventArgs e)
        {
            string text = txtSourceNumber.Text;
            int baseValue = GetBaseFromCombo(cmbSourceBase);
            string allowedChars = GetAllowedSymbols(baseValue);

            string filtered = "";
            foreach (char ch in text)
            {
                if (allowedChars.Contains(ch.ToString().ToUpper()))
                    filtered += ch;
            }

            if (text != filtered)
            {
                txtSourceNumber.Text = filtered;
                txtSourceNumber.SelectionStart = txtSourceNumber.Text.Length;
                MessageBox.Show($"Недопустимый символ. Для выбранной системы допустимы: {allowedChars}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetAllowedSymbols(int baseValue)
        {
            switch (baseValue)
            {
                case 2: return "01";
                case 8: return "01234567";
                case 10: return "0123456789";
                case 16: return "0123456789ABCDEF";
                default: return "";
            }
        }

        private int GetBaseFromCombo(ComboBox cmb)
        {
            string selected = cmb.SelectedItem.ToString();
            if (selected.Contains("2")) return 2;
            if (selected.Contains("8")) return 8;
            if (selected.Contains("10")) return 10;
            if (selected.Contains("16")) return 16;
            return 10;
        }

        private void BtnPerformConversion_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtSourceNumber.Text.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Введите число для конвертации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentSourceBase = GetBaseFromCombo(cmbSourceBase);
                currentTargetBase = GetBaseFromCombo(cmbTargetBase);
                currentSourceNumber = input;

                int decimalValue = BaseConverter.ToDecimal(currentSourceNumber, currentSourceBase);
                currentTargetNumber = BaseConverter.FromDecimal(decimalValue, currentTargetBase);

                txtTargetNumber.Text = currentTargetNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка конвертации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnStoreConversion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTargetNumber))
            {
                MessageBox.Show("Сначала выполните конвертацию", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool success = storage.SaveConversion(currentSourceNumber, currentSourceBase, currentTargetNumber, currentTargetBase);
            if (success)
            {
                MessageBox.Show("Конвертация сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshHistoryGrid();
            }
        }

        private void RefreshHistoryGrid()
        {
            DataTable data = storage.LoadAllConversions();
            dgvConversions.DataSource = data;
            dgvConversions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}