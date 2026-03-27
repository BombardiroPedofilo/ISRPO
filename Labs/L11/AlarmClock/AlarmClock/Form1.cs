using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class AlarmForm : Form
    {
        private Timer timer;
        private Database db = new Database();
        private SoundPlayer player = new SoundPlayer();
        private List<Alarm> alarms;
        private bool blinking = false;

        public AlarmForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            player.SoundLocation = Application.StartupPath + @"\alarm.wav";

            LoadAlarms();
        }

        private void LoadAlarms()
        {
            alarms = db.GetAlarms();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alarms;

            // красиво отображаем TimeSpan
            dataGridView1.Columns["Time"].HeaderText = "Время";
            dataGridView1.Columns["IsActive"].HeaderText = "Активен";
            dataGridView1.Columns["RepeatDaily"].HeaderText = "Каждый день";
            dataGridView1.Columns["CreatedDate"].HeaderText = "Создан";

            dataGridView1.Columns["Id"].Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDate.Text = DateTime.Now.ToShortDateString();

            CheckAlarms();
        }

        private void CheckAlarms()
        {
            var now = DateTime.Now.TimeOfDay;

            foreach (var alarm in alarms.Where(a => a.IsActive))
            {
                if (Math.Abs((alarm.Time - now).TotalSeconds) < 1)
                {
                    TriggerAlarm(alarm);
                }
            }
        }

        private void TriggerAlarm(Alarm alarm)
        {
            panelAlarm.Visible = true;
            timerBlink.Start();
            player.Load();
            player.PlayLooping();

            if (!alarm.RepeatDaily)
            {
                alarm.IsActive = false;
                db.UpdateAlarm(alarm);
                LoadAlarms();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dlg = new AlarmEditDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                db.AddAlarm(dlg.Alarm);
                LoadAlarms();
                MessageBox.Show("Будильник добавлен!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var alarm = (Alarm)dataGridView1.CurrentRow.DataBoundItem;

            var dlg = new AlarmEditDialog(alarm);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                db.UpdateAlarm(dlg.Alarm);
                LoadAlarms();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var alarm = (Alarm)dataGridView1.CurrentRow.DataBoundItem;
            db.DeleteAlarm(alarm.Id);
            LoadAlarms();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopAlarm();
        }

        private void btnSnooze_Click(object sender, EventArgs e)
        {
            var alarm = alarms.FirstOrDefault(a => a.IsActive);

            if (alarm != null)
            {
                alarm.Time = alarm.Time.Add(TimeSpan.FromMinutes(5));
                db.UpdateAlarm(alarm);
                LoadAlarms();
            }

            StopAlarm();
        }

        private void StopAlarm()
        {
            panelAlarm.Visible = false;
            timerBlink.Stop();
            player.Stop();
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            blinking = !blinking;

            panelAlarm.BackColor = blinking
                ? System.Drawing.Color.Red
                : System.Drawing.Color.Yellow;
        }
    }
}