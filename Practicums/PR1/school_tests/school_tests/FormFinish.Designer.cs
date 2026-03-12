namespace school_tests
{
    partial class FormFinish
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblResult = new Label();
            btnRestart = new CuoreUI.Controls.cuiButton();
            btnExit = new CuoreUI.Controls.cuiButton();
            circularProgress = new CuoreUI.Controls.cuiCircleProgressBar();
            lblPercent = new Label();
            dgvHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.Location = new Point(14, 39);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(346, 28);
            lblResult.TabIndex = 0;
            lblResult.Text = "Вы ответили правильно на X из Y";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.Control;
            btnRestart.CheckButton = false;
            btnRestart.Checked = false;
            btnRestart.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnRestart.CheckedForeColor = Color.FromArgb(64, 64, 64);
            btnRestart.CheckedImageTint = Color.RosyBrown;
            btnRestart.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnRestart.Content = "Пройти заново";
            btnRestart.DialogResult = DialogResult.None;
            btnRestart.Font = new Font("Trebuchet MS", 9.75F);
            btnRestart.ForeColor = Color.Black;
            btnRestart.HoverBackground = Color.IndianRed;
            btnRestart.HoverForeColor = Color.Black;
            btnRestart.HoverImageTint = Color.DimGray;
            btnRestart.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRestart.Image = null;
            btnRestart.ImageExpand = new Point(0, 0);
            btnRestart.Location = new Point(14, 469);
            btnRestart.Margin = new Padding(3, 4, 3, 4);
            btnRestart.Name = "btnRestart";
            btnRestart.NormalBackground = Color.MistyRose;
            btnRestart.NormalForeColor = Color.Black;
            btnRestart.NormalImageTint = Color.Black;
            btnRestart.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRestart.OutlineThickness = 1F;
            btnRestart.PressedBackground = Color.Maroon;
            btnRestart.PressedForeColor = Color.FromArgb(224, 224, 224);
            btnRestart.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRestart.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRestart.Rounding = new Padding(8);
            btnRestart.Size = new Size(160, 53);
            btnRestart.TabIndex = 1;
            btnRestart.TextAlignment = StringAlignment.Center;
            btnRestart.TextPadding = -1;
            btnRestart.TextSpacing = 2;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Control;
            btnExit.CheckButton = false;
            btnExit.Checked = false;
            btnExit.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExit.CheckedForeColor = Color.FromArgb(64, 64, 64);
            btnExit.CheckedImageTint = Color.RosyBrown;
            btnExit.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExit.Content = "Выход";
            btnExit.DialogResult = DialogResult.None;
            btnExit.Font = new Font("Trebuchet MS", 9.75F);
            btnExit.ForeColor = Color.Black;
            btnExit.HoverBackground = Color.IndianRed;
            btnExit.HoverForeColor = Color.Black;
            btnExit.HoverImageTint = Color.DimGray;
            btnExit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnExit.Image = null;
            btnExit.ImageExpand = new Point(0, 0);
            btnExit.Location = new Point(557, 469);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.NormalBackground = Color.MistyRose;
            btnExit.NormalForeColor = Color.Black;
            btnExit.NormalImageTint = Color.Black;
            btnExit.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnExit.OutlineThickness = 1F;
            btnExit.PressedBackground = Color.Maroon;
            btnExit.PressedForeColor = Color.FromArgb(224, 224, 224);
            btnExit.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExit.Rounding = new Padding(8);
            btnExit.Size = new Size(164, 53);
            btnExit.TabIndex = 2;
            btnExit.TextAlignment = StringAlignment.Center;
            btnExit.TextPadding = -1;
            btnExit.TextSpacing = 2;
            btnExit.Click += btnExit_Click;
            // 
            // circularProgress
            // 
            circularProgress.BackColor = Color.Transparent;
            circularProgress.BorderWidth = 12;
            circularProgress.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            circularProgress.ForeColor = Color.Black;
            circularProgress.Location = new Point(259, 90);
            circularProgress.Margin = new Padding(3, 4, 3, 4);
            circularProgress.MaximumValue = 100;
            circularProgress.MinimumSize = new Size(24, 24);
            circularProgress.MinimumValue = 0;
            circularProgress.Name = "circularProgress";
            circularProgress.NormalColor = Color.FromArgb(64, 128, 128, 128);
            circularProgress.ProgressColor = Color.DarkRed;
            circularProgress.ProgressValue = 0;
            circularProgress.RoundedEnds = true;
            circularProgress.Size = new Size(206, 209);
            circularProgress.TabIndex = 3;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 10F);
            lblPercent.Location = new Point(352, 303);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(33, 23);
            lblPercent.TabIndex = 5;
            lblPercent.Text = "0%";
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(12, 344);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(709, 100);
            dgvHistory.TabIndex = 6;
            // 
            // FormFinish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 545);
            Controls.Add(dgvHistory);
            Controls.Add(lblPercent);
            Controls.Add(circularProgress);
            Controls.Add(btnExit);
            Controls.Add(btnRestart);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormFinish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результат теста";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private CuoreUI.Controls.cuiButton btnRestart;
        private CuoreUI.Controls.cuiButton btnExit;
        private CuoreUI.Controls.cuiCircleProgressBar circularProgress; // Исправлено!
        private System.Windows.Forms.Label lblPercent;
    }
}