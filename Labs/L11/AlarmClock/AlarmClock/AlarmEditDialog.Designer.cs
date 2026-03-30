namespace AlarmClock
{
    partial class AlarmEditDialog
    {
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Button btnOK;

        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 1;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.Location = new System.Drawing.Point(20, 90);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(104, 24);
            this.checkBoxActive.TabIndex = 2;
            this.checkBoxActive.Text = "Активен";
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.Location = new System.Drawing.Point(20, 120);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(104, 24);
            this.checkBoxRepeat.TabIndex = 3;
            this.checkBoxRepeat.Text = "Повторять ежедневно";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AlarmEditDialog
            // 
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.btnOK);
            this.Name = "AlarmEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}