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
            this.btnSnooze = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 42F);
            this.labelTime.Location = new System.Drawing.Point(124, 43);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(308, 82);
            this.labelTime.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(336, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(200, 20);
            this.labelDate.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(20, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(500, 220);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 163);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelAlarm
            // 
            this.panelAlarm.BackColor = System.Drawing.Color.Gold;
            this.panelAlarm.Controls.Add(this.btnSnooze);
            this.panelAlarm.Controls.Add(this.btnStop);
            this.panelAlarm.Location = new System.Drawing.Point(1, 450);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(700, 80);
            this.panelAlarm.TabIndex = 6;
            this.panelAlarm.Visible = false;
            // 
            // btnSnooze
            // 
            this.btnSnooze.BackColor = System.Drawing.Color.Gold;
            this.btnSnooze.Location = new System.Drawing.Point(20, 20);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(75, 23);
            this.btnSnooze.TabIndex = 0;
            this.btnSnooze.Text = "Отложить 5 мин";
            this.btnSnooze.UseVisualStyleBackColor = false;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gold;
            this.btnStop.Location = new System.Drawing.Point(444, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 500;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // AlarmForm
            // 
            this.ClientSize = new System.Drawing.Size(538, 524);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelAlarm);
            this.Name = "AlarmForm";
            this.Text = "Будильник";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAlarm.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}