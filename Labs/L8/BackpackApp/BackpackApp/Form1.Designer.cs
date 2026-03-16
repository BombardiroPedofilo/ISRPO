namespace BackpackApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button btnShowSource;
        //private System.Windows.Forms.Button btnSolve;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            label1 = new Label();
            cuiControlBlur1 = new CuoreUI.Components.cuiControlBlur(components);
            btnShowSource = new CuoreUI.Controls.cuiButton();
            btnSolve = new CuoreUI.Controls.cuiButton();
            txtMaxWeight = new CuoreUI.Controls.cuiTextBox();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(13, 48);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(419, 230);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 300);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 1;
            label1.Text = "Максимальный вес рюкзака";
            // 
            // cuiControlBlur1
            // 
            cuiControlBlur1.BlurAmount = 1.5F;
            cuiControlBlur1.TargetControl = null;
            // 
            // btnShowSource
            // 
            btnShowSource.BackColor = Color.Transparent;
            btnShowSource.CheckButton = false;
            btnShowSource.Checked = false;
            btnShowSource.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnShowSource.CheckedForeColor = Color.White;
            btnShowSource.CheckedImageTint = Color.White;
            btnShowSource.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnShowSource.Content = "Показать исходные данные";
            btnShowSource.DialogResult = DialogResult.None;
            btnShowSource.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnShowSource.ForeColor = Color.Black;
            btnShowSource.HoverBackground = Color.FromArgb(255, 255, 128);
            btnShowSource.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnShowSource.HoverImageTint = Color.FromArgb(64, 64, 64);
            btnShowSource.HoverOutline = Color.FromArgb(192, 192, 0);
            btnShowSource.Image = null;
            btnShowSource.ImageExpand = new Point(0, 0);
            btnShowSource.Location = new Point(13, 340);
            btnShowSource.Name = "btnShowSource";
            btnShowSource.NormalBackground = Color.FromArgb(255, 255, 192);
            btnShowSource.NormalForeColor = Color.Black;
            btnShowSource.NormalImageTint = Color.Black;
            btnShowSource.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowSource.OutlineThickness = 1F;
            btnShowSource.Padding = new Padding(12);
            btnShowSource.PressedBackground = Color.Yellow;
            btnShowSource.PressedForeColor = Color.Black;
            btnShowSource.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnShowSource.PressedOutline = Color.Olive;
            btnShowSource.Rounding = new Padding(15);
            btnShowSource.Size = new Size(200, 49);
            btnShowSource.TabIndex = 5;
            btnShowSource.TextAlignment = StringAlignment.Center;
            btnShowSource.TextPadding = 12;
            btnShowSource.TextSpacing = 2;
            btnShowSource.Click += btnShowSource_Click;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = Color.Transparent;
            btnSolve.CheckButton = false;
            btnSolve.Checked = false;
            btnSolve.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSolve.CheckedForeColor = Color.White;
            btnSolve.CheckedImageTint = Color.White;
            btnSolve.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSolve.Content = "Решить";
            btnSolve.DialogResult = DialogResult.None;
            btnSolve.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSolve.ForeColor = Color.Black;
            btnSolve.HoverBackground = Color.FromArgb(255, 255, 128);
            btnSolve.HoverForeColor = Color.FromArgb(64, 64, 64);
            btnSolve.HoverImageTint = Color.FromArgb(64, 64, 64);
            btnSolve.HoverOutline = Color.FromArgb(192, 192, 0);
            btnSolve.Image = null;
            btnSolve.ImageExpand = new Point(0, 0);
            btnSolve.Location = new Point(219, 340);
            btnSolve.Name = "btnSolve";
            btnSolve.NormalBackground = Color.FromArgb(255, 255, 192);
            btnSolve.NormalForeColor = Color.Black;
            btnSolve.NormalImageTint = Color.Black;
            btnSolve.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSolve.OutlineThickness = 1F;
            btnSolve.Padding = new Padding(12);
            btnSolve.PressedBackground = Color.Yellow;
            btnSolve.PressedForeColor = Color.Black;
            btnSolve.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnSolve.PressedOutline = Color.Olive;
            btnSolve.Rounding = new Padding(15);
            btnSolve.Size = new Size(213, 49);
            btnSolve.TabIndex = 6;
            btnSolve.TextAlignment = StringAlignment.Center;
            btnSolve.TextPadding = 12;
            btnSolve.TextSpacing = 2;
            btnSolve.Click += btnSolve_Click;
            // 
            // txtMaxWeight
            // 
            txtMaxWeight.BackgroundColor = Color.White;
            txtMaxWeight.Content = "";
            txtMaxWeight.FocusBackgroundColor = Color.WhiteSmoke;
            txtMaxWeight.FocusImageTint = Color.White;
            txtMaxWeight.FocusOutlineColor = Color.Yellow;
            txtMaxWeight.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxWeight.ForeColor = Color.Black;
            txtMaxWeight.Image = null;
            txtMaxWeight.ImageExpand = new Point(0, 0);
            txtMaxWeight.ImageOffset = new Point(0, 0);
            txtMaxWeight.Location = new Point(185, 294);
            txtMaxWeight.Margin = new Padding(4);
            txtMaxWeight.Multiline = false;
            txtMaxWeight.Name = "txtMaxWeight";
            txtMaxWeight.NormalImageTint = Color.White;
            txtMaxWeight.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtMaxWeight.Padding = new Padding(16, 6, 16, 0);
            txtMaxWeight.PasswordChar = false;
            txtMaxWeight.PlaceholderColor = Color.LightGray;
            txtMaxWeight.PlaceholderText = "Введите значение";
            txtMaxWeight.Rounding = new Padding(15);
            txtMaxWeight.Size = new Size(149, 28);
            txtMaxWeight.TabIndex = 7;
            txtMaxWeight.TextOffset = new Size(0, 0);
            txtMaxWeight.UnderlinedStyle = true;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(470, 65);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(175, 173);
            cuiPictureBox1.TabIndex = 8;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Задачка\\ о\\ рюкзаке";
            cuiLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(259, 0);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(189, 42);
            cuiLabel1.TabIndex = 9;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.BackgroundImage = (Image)resources.GetObject("cuiPictureBox2.BackgroundImage");
            cuiPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox2.Content = null;
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(433, 249);
            cuiPictureBox2.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Empty;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(8);
            cuiPictureBox2.Size = new Size(83, 73);
            cuiPictureBox2.TabIndex = 12;
            // 
            // cuiPictureBox3
            // 
            cuiPictureBox3.BackgroundImage = (Image)resources.GetObject("cuiPictureBox3.BackgroundImage");
            cuiPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox3.Content = null;
            cuiPictureBox3.ImageTint = Color.White;
            cuiPictureBox3.Location = new Point(508, 249);
            cuiPictureBox3.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox3.Name = "cuiPictureBox3";
            cuiPictureBox3.OutlineThickness = 1F;
            cuiPictureBox3.PanelOutlineColor = Color.Empty;
            cuiPictureBox3.Rotation = 0;
            cuiPictureBox3.Rounding = new Padding(8);
            cuiPictureBox3.Size = new Size(83, 73);
            cuiPictureBox3.TabIndex = 13;
            // 
            // cuiPictureBox4
            // 
            cuiPictureBox4.BackgroundImage = (Image)resources.GetObject("cuiPictureBox4.BackgroundImage");
            cuiPictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox4.Content = null;
            cuiPictureBox4.ImageTint = Color.White;
            cuiPictureBox4.Location = new Point(584, 249);
            cuiPictureBox4.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox4.Name = "cuiPictureBox4";
            cuiPictureBox4.OutlineThickness = 1F;
            cuiPictureBox4.PanelOutlineColor = Color.Empty;
            cuiPictureBox4.Rotation = 0;
            cuiPictureBox4.Rounding = new Padding(8);
            cuiPictureBox4.Size = new Size(83, 73);
            cuiPictureBox4.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 400);
            Controls.Add(cuiPictureBox4);
            Controls.Add(cuiPictureBox3);
            Controls.Add(cuiPictureBox2);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiPictureBox1);
            Controls.Add(txtMaxWeight);
            Controls.Add(btnSolve);
            Controls.Add(btnShowSource);
            Controls.Add(label1);
            Controls.Add(listView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задача о рюкзаке";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private CuoreUI.Components.cuiControlBlur cuiControlBlur1;
        private CuoreUI.Controls.cuiButton btnShowSource;
        private CuoreUI.Controls.cuiButton btnSolve;
        private CuoreUI.Controls.cuiTextBox txtMaxWeight;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
    }
}