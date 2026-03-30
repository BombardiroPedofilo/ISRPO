namespace AlarmClock
{
    partial class AlarmForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.Label labelAlarm; // 🔥 добавили

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.labelAlarm = new System.Windows.Forms.Label(); // 🔥
            this.btnSnooze = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAlarm.SuspendLayout();
            this.SuspendLayout();

            // labelTime
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 42F);
            this.labelTime.Location = new System.Drawing.Point(124, 43);
            this.labelTime.Size = new System.Drawing.Size(308, 82);

            // labelDate
            this.labelDate.Location = new System.Drawing.Point(336, 9);
            this.labelDate.Size = new System.Drawing.Size(200, 20);

            // таблица
            this.dataGridView1.Location = new System.Drawing.Point(20, 215);
            this.dataGridView1.Size = new System.Drawing.Size(567, 220);

            // кнопки
            this.btnAdd.Location = new System.Drawing.Point(12, 163);
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Location = new System.Drawing.Point(240, 163);
            this.btnEdit.Size = new System.Drawing.Size(130, 23);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(457, 163);
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 🔴 ПАНЕЛЬ (ВСЕГДА ВИДИМА)
            this.panelAlarm.BackColor = System.Drawing.Color.LightGray;
            this.panelAlarm.Location = new System.Drawing.Point(0, 450);
            this.panelAlarm.Size = new System.Drawing.Size(605, 80);
            this.panelAlarm.Visible = true;

            // 🔴 НАДПИСЬ
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAlarm.Location = new System.Drawing.Point(200, 25);
            this.labelAlarm.Text = "Будильник не активен";

            // кнопка Snooze
            this.btnSnooze.Location = new System.Drawing.Point(20, 20);
            this.btnSnooze.Size = new System.Drawing.Size(120, 30);
            this.btnSnooze.Text = "Отложить 5 мин";
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);

            // кнопка Stop
            this.btnStop.Location = new System.Drawing.Point(450, 20);
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.Text = "Стоп";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // добавляем в панель
            this.panelAlarm.Controls.Add(this.labelAlarm);
            this.panelAlarm.Controls.Add(this.btnSnooze);
            this.panelAlarm.Controls.Add(this.btnStop);

            // таймер
            this.timerBlink.Interval = 500;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);

            // форма
            this.ClientSize = new System.Drawing.Size(605, 524);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelAlarm);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}