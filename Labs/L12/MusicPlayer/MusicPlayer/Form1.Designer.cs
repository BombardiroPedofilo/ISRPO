using System.Windows.Forms;

namespace MusicPlayer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridView1;
        private Button btnPlay;
        private Button btnPause;
        private Button btnNext;
        private Button btnPrev;
        private Button btnFirst;
        private Button btnLast;

        private TrackBar trackBarVolume;
        private TrackBar trackBarProgress;

        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox textBoxSearch;

        private GroupBox groupBoxInfo;
        private Label labelTitleValue;
        private Label labelArtistValue;
        private Label labelDurationValue;
        private Label labelPlaysValue;
        private Label labelDateValue;
        private System.Windows.Forms.Label labelVolume;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.labelTitleValue = new System.Windows.Forms.Label();
            this.labelArtistValue = new System.Windows.Forms.Label();
            this.labelDurationValue = new System.Windows.Forms.Label();
            this.labelPlaysValue = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(309, 468);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 40);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "▶";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(389, 468);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 40);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "⏸";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(469, 468);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "▶";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(229, 468);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 40);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "◀";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(149, 468);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 40);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "◀◀";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(549, 468);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 40);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "▶▶";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(920, 115);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(104, 56);
            this.trackBarVolume.TabIndex = 12;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Location = new System.Drawing.Point(12, 408);
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(900, 56);
            this.trackBarProgress.TabIndex = 1;
            this.trackBarProgress.Scroll += new System.EventHandler(this.trackBarProgress_Scroll);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(927, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1080, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(830, 468);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(700, 470);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(120, 22);
            this.textBoxSearch.TabIndex = 8;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.l1);
            this.groupBoxInfo.Controls.Add(this.l2);
            this.groupBoxInfo.Controls.Add(this.l3);
            this.groupBoxInfo.Controls.Add(this.l4);
            this.groupBoxInfo.Controls.Add(this.l5);
            this.groupBoxInfo.Controls.Add(this.labelTitleValue);
            this.groupBoxInfo.Controls.Add(this.labelArtistValue);
            this.groupBoxInfo.Controls.Add(this.labelDurationValue);
            this.groupBoxInfo.Controls.Add(this.labelPlaysValue);
            this.groupBoxInfo.Controls.Add(this.labelDateValue);
            this.groupBoxInfo.Location = new System.Drawing.Point(920, 182);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(280, 212);
            this.groupBoxInfo.TabIndex = 14;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация о треке";
            // 
            // l1
            // 
            this.l1.Location = new System.Drawing.Point(6, 25);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(100, 23);
            this.l1.TabIndex = 0;
            this.l1.Text = "Название";
            // 
            // l2
            // 
            this.l2.Location = new System.Drawing.Point(4, 58);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(100, 23);
            this.l2.TabIndex = 1;
            this.l2.Text = "Исполнитель";
            // 
            // l3
            // 
            this.l3.Location = new System.Drawing.Point(6, 85);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(100, 23);
            this.l3.TabIndex = 2;
            this.l3.Text = "Длительность";
            // 
            // l4
            // 
            this.l4.Location = new System.Drawing.Point(6, 115);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(118, 23);
            this.l4.TabIndex = 3;
            this.l4.Text = "Прослушиваний";
            // 
            // l5
            // 
            this.l5.Location = new System.Drawing.Point(6, 145);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(122, 23);
            this.l5.TabIndex = 4;
            this.l5.Text = "Дата добавления";
            this.l5.Click += new System.EventHandler(this.l5_Click);
            // 
            // labelTitleValue
            // 
            this.labelTitleValue.Location = new System.Drawing.Point(130, 25);
            this.labelTitleValue.Name = "labelTitleValue";
            this.labelTitleValue.Size = new System.Drawing.Size(100, 23);
            this.labelTitleValue.TabIndex = 5;
            // 
            // labelArtistValue
            // 
            this.labelArtistValue.Location = new System.Drawing.Point(130, 55);
            this.labelArtistValue.Name = "labelArtistValue";
            this.labelArtistValue.Size = new System.Drawing.Size(100, 23);
            this.labelArtistValue.TabIndex = 6;
            // 
            // labelDurationValue
            // 
            this.labelDurationValue.Location = new System.Drawing.Point(130, 85);
            this.labelDurationValue.Name = "labelDurationValue";
            this.labelDurationValue.Size = new System.Drawing.Size(100, 23);
            this.labelDurationValue.TabIndex = 7;
            // 
            // labelPlaysValue
            // 
            this.labelPlaysValue.Location = new System.Drawing.Point(130, 115);
            this.labelPlaysValue.Name = "labelPlaysValue";
            this.labelPlaysValue.Size = new System.Drawing.Size(100, 23);
            this.labelPlaysValue.TabIndex = 8;
            // 
            // labelDateValue
            // 
            this.labelDateValue.Location = new System.Drawing.Point(130, 145);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(100, 23);
            this.labelDateValue.TabIndex = 9;
            // 
            // labelVolume
            // 
            this.labelVolume.Location = new System.Drawing.Point(920, 160);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(150, 23);
            this.labelVolume.TabIndex = 15;
            this.labelVolume.Text = "Громкость: 50%";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1220, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trackBarProgress);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Name = "MainForm";
            this.Text = "Музыкальный плеер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Label l5;
    }
}