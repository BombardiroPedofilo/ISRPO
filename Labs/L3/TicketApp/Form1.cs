using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class MainForm : Form
    {
        private Random random;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Генерация 6-значного номера
            string ticket = random.Next(0, 1000000).ToString("D6");
            lblTicket.Text = ticket;

            // Проверка на счастливый билет
            int sumFirstThree = (ticket[0] - '0') + (ticket[1] - '0') + (ticket[2] - '0');
            int sumLastThree = (ticket[3] - '0') + (ticket[4] - '0') + (ticket[5] - '0');

            bool isLucky = sumFirstThree == sumLastThree;

            // Отображение результата
            if (isLucky)
            {
                lblResult.Text = "Счастливый билет!";
                lblResult.ForeColor = Color.Green;
                lblTicket.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Обычный билет";
                lblResult.ForeColor = Color.Red;
                lblTicket.ForeColor = Color.Red;
            }
        }
    }
}
