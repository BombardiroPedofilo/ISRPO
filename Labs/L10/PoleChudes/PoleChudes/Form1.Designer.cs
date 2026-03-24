namespace PoleChudes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLetters;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.flowLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Форма
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text = "Поле чудес";

            // Заголовок
            this.lblTitle.Text = "🎯 Собери слово";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(280, 20);

            // TextBox (результат)
            this.txtResult.Location = new System.Drawing.Point(200, 80);
            this.txtResult.Size = new System.Drawing.Size(400, 40);
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18);
            this.txtResult.ReadOnly = true;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // Панель букв
            this.flowLetters.Location = new System.Drawing.Point(100, 150);
            this.flowLetters.Size = new System.Drawing.Size(600, 150);

            // Кнопка Новая игра
            this.btnNewGame.Text = "🎲 Новая игра";
            this.btnNewGame.Size = new System.Drawing.Size(150, 50);
            this.btnNewGame.Location = new System.Drawing.Point(100, 350);
            this.btnNewGame.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            // Кнопка Отмена
            this.btnUndo.Text = "↩ Отмена";
            this.btnUndo.Size = new System.Drawing.Size(150, 50);
            this.btnUndo.Location = new System.Drawing.Point(325, 350);
            this.btnUndo.BackColor = System.Drawing.Color.Khaki;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);

            // Кнопка Проверить
            this.btnCheck.Text = "✔ Проверить";
            this.btnCheck.Size = new System.Drawing.Size(150, 50);
            this.btnCheck.Location = new System.Drawing.Point(550, 350);
            this.btnCheck.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // Добавление элементов
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.flowLetters);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCheck);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}