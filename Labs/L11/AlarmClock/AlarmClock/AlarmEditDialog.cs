using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlarmClock
{
    public partial class AlarmEditDialog : Form
    {
        public Alarm Alarm { get; private set; }

        public AlarmEditDialog(Alarm alarm = null)
        {
            InitializeComponent();

            if (alarm != null)
            {
                Alarm = alarm;
                dateTimePicker1.Value = DateTime.Today.Add(alarm.Time);
                textBox1.Text = alarm.Label;
                checkBoxActive.Checked = alarm.IsActive;
                checkBoxRepeat.Checked = alarm.RepeatDaily;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Alarm == null)
                Alarm = new Alarm();

            Alarm.Time = dateTimePicker1.Value.TimeOfDay;
            Alarm.Label = textBox1.Text;
            Alarm.IsActive = checkBoxActive.Checked;
            Alarm.RepeatDaily = checkBoxRepeat.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}