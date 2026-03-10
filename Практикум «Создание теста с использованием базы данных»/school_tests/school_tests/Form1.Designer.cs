namespace school_tests
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            txtFirstName = new CuoreUI.Controls.cuiTextBox();
            txtLastName = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F);
            label1.Location = new Point(4, 142);
            label1.Name = "label1";
            label1.Size = new Size(38, 18);
            label1.TabIndex = 0;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F);
            label2.Location = new Point(4, 190);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 1;
            label2.Text = "Фамилия:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-81, -63);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 255);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = SystemColors.ButtonFace;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.FromArgb(64, 64, 64);
            cuiButton1.CheckedImageTint = Color.RosyBrown;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Пройти тест";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Trebuchet MS", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.IndianRed;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(4, 237);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.MistyRose;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.Maroon;
            cuiButton1.PressedForeColor = Color.FromArgb(224, 224, 224);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(230, 36);
            cuiButton1.TabIndex = 6;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += btnStart_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BackgroundColor = Color.Gainsboro;
            txtFirstName.Content = "";
            txtFirstName.FocusBackgroundColor = Color.WhiteSmoke;
            txtFirstName.FocusImageTint = Color.White;
            txtFirstName.FocusOutlineColor = Color.IndianRed;
            txtFirstName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.FromArgb(64, 64, 64);
            txtFirstName.Image = null;
            txtFirstName.ImageExpand = new Point(0, 0);
            txtFirstName.ImageOffset = new Point(0, 0);
            txtFirstName.Location = new Point(73, 142);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.NormalImageTint = Color.White;
            txtFirstName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtFirstName.Padding = new Padding(16, 7, 16, 0);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceholderColor = Color.White;
            txtFirstName.PlaceholderText = "Введите имя";
            txtFirstName.Rounding = new Padding(8);
            txtFirstName.Size = new Size(154, 31);
            txtFirstName.TabIndex = 8;
            txtFirstName.TextOffset = new Size(0, 0);
            txtFirstName.UnderlinedStyle = true;
            // 
            // txtLastName
            // 
            txtLastName.BackgroundColor = Color.Gainsboro;
            txtLastName.Content = "";
            txtLastName.FocusBackgroundColor = Color.WhiteSmoke;
            txtLastName.FocusImageTint = Color.White;
            txtLastName.FocusOutlineColor = Color.IndianRed;
            txtLastName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.FromArgb(64, 64, 64);
            txtLastName.Image = null;
            txtLastName.ImageExpand = new Point(0, 0);
            txtLastName.ImageOffset = new Point(0, 0);
            txtLastName.Location = new Point(73, 190);
            txtLastName.Margin = new Padding(4);
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.NormalImageTint = Color.White;
            txtLastName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtLastName.Padding = new Padding(16, 7, 16, 0);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = Color.White;
            txtLastName.PlaceholderText = "Введите фамилию";
            txtLastName.Rounding = new Padding(8);
            txtLastName.Size = new Size(154, 31);
            txtLastName.TabIndex = 9;
            txtLastName.TextOffset = new Size(0, 0);
            txtLastName.UnderlinedStyle = true;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(238, 283);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(cuiButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Trebuchet MS", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начало теста";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiTextBox txtFirstName;
        private CuoreUI.Controls.cuiTextBox txtLastName;
    }
}