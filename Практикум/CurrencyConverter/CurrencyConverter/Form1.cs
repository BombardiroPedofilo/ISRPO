using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        // Курсы валют относительно RUB (рубля)
        private readonly Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            { "RUB", 1.0 },      // Российский рубль
            { "USD", 90.0 },     // Доллар США (примерный курс)
            { "EUR", 98.0 },     // Евро (примерный курс)
            { "CNY", 12.5 },     // Китайский юань (примерный курс)
            { "KRW", 0.065 }     // Южнокорейская вона (примерный курс)
        };

        public Form1()
        {
            InitializeComponent();
            InitializeCurrencyComboBoxes();
            SetupEventHandlers();
        }

        // Инициализация выпадающих списков валют
        private void InitializeCurrencyComboBoxes()
        {
            // Добавляем валюты в оба списка
            foreach (var currency in exchangeRates.Keys)
            {
                comboBoxFrom.Items.Add(currency);
                comboBoxTo.Items.Add(currency);
            }

            
        }

        // Настройка обработчиков событий
        private void SetupEventHandlers()
        {
            // Автоматическая конвертация при изменении данных
            textBoxAmount.TextChanged += (s, e) => ConvertCurrency();
            comboBoxFrom.SelectedIndexChanged += (s, e) => ConvertCurrency();
            comboBoxTo.SelectedIndexChanged += (s, e) => ConvertCurrency();

            // Если используете кнопку:
            // buttonConvert.Click += (s, e) => ConvertCurrency();
        }

        // Основная функция конвертации
        private void ConvertCurrency()
        {
            // Проверяем, что все поля заполнены
            if (comboBoxFrom.SelectedItem == null ||
                comboBoxTo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                labelResult.Text = "Введите данные";
                return;
            }

            // Пытаемся получить числовое значение суммы
            if (!double.TryParse(textBoxAmount.Text, out double amount))
            {
                labelResult.Text = "Некорректная сумма";
                return;
            }

            string fromCurrency = comboBoxFrom.SelectedItem.ToString();
            string toCurrency = comboBoxTo.SelectedItem.ToString();

            // Выполняем конвертацию
            double result = Convert(amount, fromCurrency, toCurrency);

            // Отображаем результат с округлением до 2 знаков
            labelResult.Text = $"{result:F2} {toCurrency}";
        }

        // Метод для расчета конвертации
        private double Convert(double amount, string fromCurrency, string toCurrency)
        {
            // Конвертируем через RUB
            double amountInRubles = amount * exchangeRates[fromCurrency];
            double result = amountInRubles / exchangeRates[toCurrency];

            return result;
        }

        // Обработчик для обмена валют местами
        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedItem != null && comboBoxTo.SelectedItem != null)
            {
                var temp = comboBoxFrom.SelectedItem;
                comboBoxFrom.SelectedItem = comboBoxTo.SelectedItem;
                comboBoxTo.SelectedItem = temp;
                ConvertCurrency();
            }
        }
    }
}