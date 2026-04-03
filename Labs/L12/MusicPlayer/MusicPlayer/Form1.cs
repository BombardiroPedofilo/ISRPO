using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private AudioPlayer player = new AudioPlayer();

        private List<MusicTrack> tracks = new List<MusicTrack>();
        private int currentIndex = -1;
        private bool isPaused = false;

        private Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            LoadTracks();

            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
            dataGridView1.ReadOnly = false;
        }

        private void LoadTracks()
        {
            tracks = db.GetAllTracks();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tracks;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].Visible = false;

                if (dataGridView1.Columns.Contains("DisplayName"))
                    dataGridView1.Columns["DisplayName"].Visible = false;

                dataGridView1.Columns["Title"].HeaderText = "Название";
                dataGridView1.Columns["Artist"].HeaderText = "Исполнитель";
                dataGridView1.Columns["Album"].HeaderText = "Альбом";
                dataGridView1.Columns["Genre"].HeaderText = "Жанр";
                dataGridView1.Columns["Duration"].HeaderText = "Длительность";
                dataGridView1.Columns["FileSize"].HeaderText = "Размер";
                dataGridView1.Columns["PlayCount"].HeaderText = "Прослушивания";
                dataGridView1.Columns["DateAdded"].HeaderText = "Дата";
            }
        }

        private void PlayTrack(int index)
        {
            if (index < 0 || index >= tracks.Count) return;

            currentIndex = index;
            var track = tracks[index];

            try
            {
                player.Stop(); // ВАЖНО

                byte[] data = db.GetFileData(track.Id);
                player.Play(data);

                db.IncrementPlayCount(track.Id);
                track.PlayCount++;

                UpdateTrackInfo(track);

                trackBarProgress.Value = 0;
                isPaused = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void UpdateTrackInfo(MusicTrack track)
        {
            labelTitleValue.Text = track.Title;
            labelArtistValue.Text = track.Artist;
            labelDurationValue.Text = track.Duration?.ToString(@"mm\:ss");
            labelPlaysValue.Text = track.PlayCount.ToString();
            labelDateValue.Text = track.DateAdded.ToString("dd.MM.yyyy");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            double total = player.GetTotalSeconds();
            double current = player.GetCurrentSeconds();

            if (total > 0)
            {
                trackBarProgress.Maximum = (int)total;

                int value = (int)current;
                if (value <= trackBarProgress.Maximum)
                    trackBarProgress.Value = value;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            currentIndex = dataGridView1.CurrentRow.Index;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (tracks.Count == 0) return;

            if (currentIndex == -1)
                currentIndex = 0;

            if (isPaused)
            {
                player.Resume();
                isPaused = false;
            }
            else
            {
                PlayTrack(currentIndex);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Pause();
            isPaused = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < tracks.Count - 1)
                PlayTrack(currentIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
                PlayTrack(currentIndex - 1);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (tracks.Count > 0)
                PlayTrack(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (tracks.Count > 0)
                PlayTrack(tracks.Count - 1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlayTrack(e.RowIndex);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            float volume = trackBarVolume.Value / 100f;
            player.SetVolume(volume);
            labelVolume.Text = "Громкость: " + trackBarVolume.Value + "%";
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            player.SetPosition(trackBarProgress.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "MP3 files (*.mp3)|*.mp3";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(dlg.FileName);
                    byte[] data = File.ReadAllBytes(dlg.FileName);

                    var track = new MusicTrack
                    {
                        Title = Path.GetFileNameWithoutExtension(dlg.FileName),
                        Artist = "Unknown",
                        Album = "",
                        Genre = "Неизвестно",
                        Duration = TimeSpan.FromSeconds(180),
                        FileSize = (int)fileInfo.Length
                    };

                    db.AddTrack(track, data);
                    LoadTracks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var track = tracks[e.RowIndex];

            try
            {
                db.UpdateTrack(track);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var track = dataGridView1.CurrentRow.DataBoundItem as MusicTrack;
            if (track == null) return;

            if (db.DeleteTrack(track.Id))
            {
                LoadTracks();
                currentIndex = -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LoadTracks();
                return;
            }

            dataGridView1.DataSource = db.Search(query);
        }

        private void l5_Click(object sender, EventArgs e)
        {

        }
    }
}