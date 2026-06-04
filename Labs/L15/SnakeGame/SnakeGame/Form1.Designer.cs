namespace SnakeGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameCanvas = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.BackColor = System.Drawing.Color.White;
            this.gameCanvas.Location = new System.Drawing.Point(12, 12);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(500, 500);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            this.gameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.GameCanvas_Paint);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(12, 520);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Счёт: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 200;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.gameCanvas);
            this.Name = "Form1";
            this.Text = "Змейка";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}