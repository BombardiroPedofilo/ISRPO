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

            // время
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 20);

            // название
            this.textBox1.Location = new System.Drawing.Point(20, 60);
            this.textBox1.Size = new System.Drawing.Size(200, 23);

            // активен
            this.checkBoxActive.Text = "Активен";
            this.checkBoxActive.Location = new System.Drawing.Point(20, 90);

            // повтор
            this.checkBoxRepeat.Text = "Повторять ежедневно";
            this.checkBoxRepeat.Location = new System.Drawing.Point(20, 120);

            // кнопка
            this.btnOK.Text = "OK";
            this.btnOK.Location = new System.Drawing.Point(20, 150);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // форма
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.btnOK);

            this.Text = "Будильник";
        }
    }
}