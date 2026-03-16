namespace FilesApp
{
    partial class SimbolsCount
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblInfo1 = new Label();
            lblInfo2 = new Label();
            txtCount = new TextBox();
            txtPath = new TextBox();
            txtText = new CuoreUI.Controls.cuiTextBox();
            btnOpen = new CuoreUI.Controls.cuiButton();
            btnCountUp = new CuoreUI.Controls.cuiButton();
            btnSave = new CuoreUI.Controls.cuiButton();
            btnClear = new CuoreUI.Controls.cuiButton();
            btnExit = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Location = new Point(14, 55);
            lblInfo1.Margin = new Padding(4, 0, 4, 0);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(249, 15);
            lblInfo1.TabIndex = 5;
            lblInfo1.Text = "Введите текст или выберите файл с текстом";
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(14, 370);
            lblInfo2.Margin = new Padding(4, 0, 4, 0);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(176, 15);
            lblInfo2.TabIndex = 6;
            lblInfo2.Text = "Количество символов в тексте";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(14, 388);
            txtCount.Margin = new Padding(4, 3, 4, 3);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(116, 23);
            txtCount.TabIndex = 8;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(13, 78);
            txtPath.Margin = new Padding(4, 3, 4, 3);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(482, 23);
            txtPath.TabIndex = 9;
            // 
            // txtText
            // 
            txtText.BackgroundColor = Color.White;
            txtText.Content = "";
            txtText.FocusBackgroundColor = Color.White;
            txtText.FocusImageTint = Color.White;
            txtText.FocusOutlineColor = Color.MediumTurquoise;
            txtText.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtText.ForeColor = Color.Black;
            txtText.Image = null;
            txtText.ImageExpand = new Point(0, 0);
            txtText.ImageOffset = new Point(0, 0);
            txtText.Location = new Point(13, 108);
            txtText.Margin = new Padding(4);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.NormalImageTint = Color.White;
            txtText.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtText.Padding = new Padding(16, 6, 16, 6);
            txtText.PasswordChar = false;
            txtText.PlaceholderColor = Color.LightGray;
            txtText.PlaceholderText = "Введите свой текст";
            txtText.Rounding = new Padding(8);
            txtText.Size = new Size(482, 253);
            txtText.TabIndex = 10;
            txtText.TextOffset = new Size(0, 0);
            txtText.UnderlinedStyle = true;
            // 
            // btnOpen
            // 
            btnOpen.CheckButton = false;
            btnOpen.Checked = false;
            btnOpen.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnOpen.CheckedForeColor = Color.White;
            btnOpen.CheckedImageTint = Color.White;
            btnOpen.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnOpen.Content = "Открыть";
            btnOpen.DialogResult = DialogResult.None;
            btnOpen.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnOpen.ForeColor = Color.Black;
            btnOpen.HoverBackground = Color.MediumAquamarine;
            btnOpen.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnOpen.HoverImageTint = Color.DimGray;
            btnOpen.HoverOutline = Color.FromArgb(64, 64, 64);
            btnOpen.Image = null;
            btnOpen.ImageExpand = new Point(0, 0);
            btnOpen.Location = new Point(15, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.NormalBackground = Color.LightCyan;
            btnOpen.NormalForeColor = Color.Black;
            btnOpen.NormalImageTint = Color.Black;
            btnOpen.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnOpen.OutlineThickness = 1F;
            btnOpen.Padding = new Padding(12);
            btnOpen.PressedBackground = Color.LightSeaGreen;
            btnOpen.PressedForeColor = Color.Black;
            btnOpen.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnOpen.PressedOutline = Color.FromArgb(64, 64, 64);
            btnOpen.Rounding = new Padding(8);
            btnOpen.Size = new Size(90, 45);
            btnOpen.TabIndex = 11;
            btnOpen.TextAlignment = StringAlignment.Center;
            btnOpen.TextPadding = 12;
            btnOpen.TextSpacing = 2;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnCountUp
            // 
            btnCountUp.CheckButton = false;
            btnCountUp.Checked = false;
            btnCountUp.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCountUp.CheckedForeColor = Color.White;
            btnCountUp.CheckedImageTint = Color.White;
            btnCountUp.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCountUp.Content = "Подсчитать";
            btnCountUp.DialogResult = DialogResult.None;
            btnCountUp.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCountUp.ForeColor = Color.Black;
            btnCountUp.HoverBackground = Color.MediumAquamarine;
            btnCountUp.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnCountUp.HoverImageTint = Color.DimGray;
            btnCountUp.HoverOutline = Color.FromArgb(64, 64, 64);
            btnCountUp.Image = null;
            btnCountUp.ImageExpand = new Point(0, 0);
            btnCountUp.Location = new Point(111, 3);
            btnCountUp.Name = "btnCountUp";
            btnCountUp.NormalBackground = Color.LightCyan;
            btnCountUp.NormalForeColor = Color.Black;
            btnCountUp.NormalImageTint = Color.Black;
            btnCountUp.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCountUp.OutlineThickness = 1F;
            btnCountUp.Padding = new Padding(12);
            btnCountUp.PressedBackground = Color.LightSeaGreen;
            btnCountUp.PressedForeColor = Color.Black;
            btnCountUp.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCountUp.PressedOutline = Color.FromArgb(64, 64, 64);
            btnCountUp.Rounding = new Padding(8);
            btnCountUp.Size = new Size(90, 45);
            btnCountUp.TabIndex = 12;
            btnCountUp.TextAlignment = StringAlignment.Center;
            btnCountUp.TextPadding = 12;
            btnCountUp.TextSpacing = 2;
            btnCountUp.Click += btnCountUp_Click;
            // 
            // btnSave
            // 
            btnSave.CheckButton = false;
            btnSave.Checked = false;
            btnSave.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSave.CheckedForeColor = Color.White;
            btnSave.CheckedImageTint = Color.White;
            btnSave.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSave.Content = "Сохранить";
            btnSave.DialogResult = DialogResult.None;
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSave.ForeColor = Color.Black;
            btnSave.HoverBackground = Color.MediumAquamarine;
            btnSave.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnSave.HoverImageTint = Color.DimGray;
            btnSave.HoverOutline = Color.FromArgb(64, 64, 64);
            btnSave.Image = null;
            btnSave.ImageExpand = new Point(0, 0);
            btnSave.Location = new Point(207, 3);
            btnSave.Name = "btnSave";
            btnSave.NormalBackground = Color.LightCyan;
            btnSave.NormalForeColor = Color.Black;
            btnSave.NormalImageTint = Color.Black;
            btnSave.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSave.OutlineThickness = 1F;
            btnSave.Padding = new Padding(12);
            btnSave.PressedBackground = Color.LightSeaGreen;
            btnSave.PressedForeColor = Color.Black;
            btnSave.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnSave.PressedOutline = Color.FromArgb(64, 64, 64);
            btnSave.Rounding = new Padding(8);
            btnSave.Size = new Size(90, 45);
            btnSave.TabIndex = 13;
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.TextPadding = 12;
            btnSave.TextSpacing = 2;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.CheckButton = false;
            btnClear.Checked = false;
            btnClear.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnClear.CheckedForeColor = Color.White;
            btnClear.CheckedImageTint = Color.White;
            btnClear.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnClear.Content = "Очистить";
            btnClear.DialogResult = DialogResult.None;
            btnClear.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnClear.ForeColor = Color.Black;
            btnClear.HoverBackground = Color.MediumAquamarine;
            btnClear.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnClear.HoverImageTint = Color.DimGray;
            btnClear.HoverOutline = Color.FromArgb(64, 64, 64);
            btnClear.Image = null;
            btnClear.ImageExpand = new Point(0, 0);
            btnClear.Location = new Point(303, 3);
            btnClear.Name = "btnClear";
            btnClear.NormalBackground = Color.LightCyan;
            btnClear.NormalForeColor = Color.Black;
            btnClear.NormalImageTint = Color.Black;
            btnClear.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnClear.OutlineThickness = 1F;
            btnClear.Padding = new Padding(12);
            btnClear.PressedBackground = Color.LightSeaGreen;
            btnClear.PressedForeColor = Color.Black;
            btnClear.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnClear.PressedOutline = Color.FromArgb(64, 64, 64);
            btnClear.Rounding = new Padding(8);
            btnClear.Size = new Size(90, 45);
            btnClear.TabIndex = 14;
            btnClear.TextAlignment = StringAlignment.Center;
            btnClear.TextPadding = 12;
            btnClear.TextSpacing = 2;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.CheckButton = false;
            btnExit.Checked = false;
            btnExit.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExit.CheckedForeColor = Color.White;
            btnExit.CheckedImageTint = Color.White;
            btnExit.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExit.Content = "Выход";
            btnExit.DialogResult = DialogResult.None;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnExit.ForeColor = Color.Black;
            btnExit.HoverBackground = Color.MediumAquamarine;
            btnExit.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnExit.HoverImageTint = Color.DimGray;
            btnExit.HoverOutline = Color.FromArgb(64, 64, 64);
            btnExit.Image = null;
            btnExit.ImageExpand = new Point(0, 0);
            btnExit.Location = new Point(399, 3);
            btnExit.Name = "btnExit";
            btnExit.NormalBackground = Color.LightCyan;
            btnExit.NormalForeColor = Color.Black;
            btnExit.NormalImageTint = Color.Black;
            btnExit.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnExit.OutlineThickness = 1F;
            btnExit.Padding = new Padding(12);
            btnExit.PressedBackground = Color.LightSeaGreen;
            btnExit.PressedForeColor = Color.Black;
            btnExit.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExit.PressedOutline = Color.FromArgb(64, 64, 64);
            btnExit.Rounding = new Padding(8);
            btnExit.Size = new Size(90, 45);
            btnExit.TabIndex = 15;
            btnExit.TextAlignment = StringAlignment.Center;
            btnExit.TextPadding = 12;
            btnExit.TextSpacing = 2;
            btnExit.Click += btnExit_Click;
            // 
            // SimbolsCount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 424);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnCountUp);
            Controls.Add(btnOpen);
            Controls.Add(txtText);
            Controls.Add(txtPath);
            Controls.Add(txtCount);
            Controls.Add(lblInfo2);
            Controls.Add(lblInfo1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SimbolsCount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подсчёт символов в тексте";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtPath;
        private CuoreUI.Controls.cuiTextBox txtText;
        private CuoreUI.Controls.cuiButton btnOpen;
        private CuoreUI.Controls.cuiButton btnCountUp;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnClear;
        private CuoreUI.Controls.cuiButton btnExit;
    }
}