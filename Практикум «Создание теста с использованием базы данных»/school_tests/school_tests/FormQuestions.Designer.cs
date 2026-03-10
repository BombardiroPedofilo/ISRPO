namespace school_tests
{
    partial class FormQuestions
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
            components = new System.ComponentModel.Container();
            lblTimer = new Label();
            lblProgress = new Label();
            lblQuestion = new Label();
            btnNext = new CuoreUI.Controls.cuiButton();
            btnPrevious = new CuoreUI.Controls.cuiButton();
            radioOption1 = new CuoreUI.Controls.cuiButtonGroup();
            radioOption2 = new CuoreUI.Controls.cuiButtonGroup();
            radioOption3 = new CuoreUI.Controls.cuiButtonGroup();
            radioOption4 = new CuoreUI.Controls.cuiButtonGroup();
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            cuiFormRounder2 = new CuoreUI.Components.cuiFormRounder();
            cuiTooltipHover1 = new CuoreUI.Components.cuiTooltipHover(components);
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimer.Location = new Point(20, 20);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(143, 19);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "Осталось времени:";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(20, 60);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(87, 15);
            lblProgress.TabIndex = 1;
            lblProgress.Text = "Вопрос 1 из 15";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 12F);
            lblQuestion.Location = new Point(20, 100);
            lblQuestion.MaximumSize = new Size(440, 60);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(71, 21);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Вопрос...";
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ButtonFace;
            btnNext.CheckButton = false;
            btnNext.Checked = false;
            btnNext.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnNext.CheckedForeColor = Color.FromArgb(64, 64, 64);
            btnNext.CheckedImageTint = Color.RosyBrown;
            btnNext.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnNext.Content = "Далее";
            btnNext.DialogResult = DialogResult.None;
            btnNext.Font = new Font("Trebuchet MS", 9.75F);
            btnNext.ForeColor = Color.Black;
            btnNext.HoverBackground = Color.IndianRed;
            btnNext.HoverForeColor = Color.Black;
            btnNext.HoverImageTint = Color.DimGray;
            btnNext.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnNext.Image = null;
            btnNext.ImageExpand = new Point(0, 0);
            btnNext.Location = new Point(175, 304);
            btnNext.Name = "btnNext";
            btnNext.NormalBackground = Color.MistyRose;
            btnNext.NormalForeColor = Color.Black;
            btnNext.NormalImageTint = Color.Black;
            btnNext.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnNext.OutlineThickness = 1F;
            btnNext.Padding = new Padding(12);
            btnNext.PressedBackground = Color.Maroon;
            btnNext.PressedForeColor = Color.FromArgb(224, 224, 224);
            btnNext.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnNext.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnNext.Rounding = new Padding(8);
            btnNext.Size = new Size(123, 37);
            btnNext.TabIndex = 9;
            btnNext.TextAlignment = StringAlignment.Center;
            btnNext.TextPadding = 12;
            btnNext.TextSpacing = 2;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.ButtonFace;
            btnPrevious.CheckButton = false;
            btnPrevious.Checked = false;
            btnPrevious.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnPrevious.CheckedForeColor = Color.FromArgb(64, 64, 64);
            btnPrevious.CheckedImageTint = Color.RosyBrown;
            btnPrevious.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnPrevious.Content = "Назад";
            btnPrevious.DialogResult = DialogResult.None;
            btnPrevious.Font = new Font("Trebuchet MS", 9.75F);
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.HoverBackground = Color.IndianRed;
            btnPrevious.HoverForeColor = Color.Black;
            btnPrevious.HoverImageTint = Color.DimGray;
            btnPrevious.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnPrevious.Image = null;
            btnPrevious.ImageExpand = new Point(0, 0);
            btnPrevious.Location = new Point(20, 304);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.NormalBackground = Color.MistyRose;
            btnPrevious.NormalForeColor = Color.Black;
            btnPrevious.NormalImageTint = Color.Black;
            btnPrevious.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnPrevious.OutlineThickness = 1F;
            btnPrevious.Padding = new Padding(12);
            btnPrevious.PressedBackground = Color.Maroon;
            btnPrevious.PressedForeColor = Color.FromArgb(224, 224, 224);
            btnPrevious.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnPrevious.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnPrevious.Rounding = new Padding(8);
            btnPrevious.Size = new Size(123, 37);
            btnPrevious.TabIndex = 10;
            btnPrevious.TextAlignment = StringAlignment.Center;
            btnPrevious.TextPadding = 12;
            btnPrevious.TextSpacing = 2;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // radioOption1
            // 
            radioOption1.Checked = false;
            radioOption1.CheckedBackground = Color.DarkRed;
            radioOption1.CheckedForeColor = Color.White;
            radioOption1.CheckedImageTint = Color.White;
            radioOption1.CheckedOutline = Color.DarkRed;
            radioOption1.Content = "Вариант1";
            radioOption1.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioOption1.ForeColor = Color.Black;
            radioOption1.Group = 1;
            radioOption1.HoverBackground = Color.RosyBrown;
            radioOption1.HoverForeColor = Color.Black;
            radioOption1.HoverImageTint = Color.DimGray;
            radioOption1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            radioOption1.Image = null;
            radioOption1.ImageExpand = new Point(0, 0);
            radioOption1.Location = new Point(20, 145);
            radioOption1.Name = "radioOption1";
            radioOption1.NormalBackground = Color.White;
            radioOption1.NormalForeColor = Color.Black;
            radioOption1.NormalImageTint = Color.Black;
            radioOption1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption1.OutlineThickness = 1F;
            radioOption1.Padding = new Padding(12);
            radioOption1.PressedBackground = Color.Maroon;
            radioOption1.PressedForeColor = Color.FromArgb(32, 32, 32);
            radioOption1.PressedImageTint = Color.FromArgb(32, 32, 32);
            radioOption1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption1.Rounding = new Padding(8);
            radioOption1.Size = new Size(440, 30);
            radioOption1.TabIndex = 11;
            radioOption1.TextAlignment = StringAlignment.Center;
            radioOption1.TextPadding = 12;
            radioOption1.TextSpacing = 2;
            // 
            // radioOption2
            // 
            radioOption2.Checked = false;
            radioOption2.CheckedBackground = Color.DarkRed;
            radioOption2.CheckedForeColor = Color.White;
            radioOption2.CheckedImageTint = Color.White;
            radioOption2.CheckedOutline = Color.DarkRed;
            radioOption2.Content = "Вариант2";
            radioOption2.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioOption2.ForeColor = Color.Black;
            radioOption2.Group = 1;
            radioOption2.HoverBackground = Color.RosyBrown;
            radioOption2.HoverForeColor = Color.Black;
            radioOption2.HoverImageTint = Color.DimGray;
            radioOption2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            radioOption2.Image = null;
            radioOption2.ImageExpand = new Point(0, 0);
            radioOption2.Location = new Point(20, 185);
            radioOption2.Name = "radioOption2";
            radioOption2.NormalBackground = Color.White;
            radioOption2.NormalForeColor = Color.Black;
            radioOption2.NormalImageTint = Color.Black;
            radioOption2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption2.OutlineThickness = 1F;
            radioOption2.Padding = new Padding(12);
            radioOption2.PressedBackground = Color.Maroon;
            radioOption2.PressedForeColor = Color.FromArgb(32, 32, 32);
            radioOption2.PressedImageTint = Color.FromArgb(32, 32, 32);
            radioOption2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption2.Rounding = new Padding(8);
            radioOption2.Size = new Size(440, 30);
            radioOption2.TabIndex = 12;
            radioOption2.TextAlignment = StringAlignment.Center;
            radioOption2.TextPadding = 12;
            radioOption2.TextSpacing = 2;
            // 
            // radioOption3
            // 
            radioOption3.Checked = false;
            radioOption3.CheckedBackground = Color.DarkRed;
            radioOption3.CheckedForeColor = Color.White;
            radioOption3.CheckedImageTint = Color.White;
            radioOption3.CheckedOutline = Color.DarkRed;
            radioOption3.Content = "Вариант3";
            radioOption3.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioOption3.ForeColor = Color.Black;
            radioOption3.Group = 1;
            radioOption3.HoverBackground = Color.RosyBrown;
            radioOption3.HoverForeColor = Color.Black;
            radioOption3.HoverImageTint = Color.DimGray;
            radioOption3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            radioOption3.Image = null;
            radioOption3.ImageExpand = new Point(0, 0);
            radioOption3.Location = new Point(20, 225);
            radioOption3.Name = "radioOption3";
            radioOption3.NormalBackground = Color.White;
            radioOption3.NormalForeColor = Color.Black;
            radioOption3.NormalImageTint = Color.Black;
            radioOption3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption3.OutlineThickness = 1F;
            radioOption3.Padding = new Padding(12);
            radioOption3.PressedBackground = Color.Maroon;
            radioOption3.PressedForeColor = Color.FromArgb(32, 32, 32);
            radioOption3.PressedImageTint = Color.FromArgb(32, 32, 32);
            radioOption3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption3.Rounding = new Padding(8);
            radioOption3.Size = new Size(440, 30);
            radioOption3.TabIndex = 13;
            radioOption3.TextAlignment = StringAlignment.Center;
            radioOption3.TextPadding = 12;
            radioOption3.TextSpacing = 2;
            // 
            // radioOption4
            // 
            radioOption4.Checked = false;
            radioOption4.CheckedBackground = Color.DarkRed;
            radioOption4.CheckedForeColor = Color.White;
            radioOption4.CheckedImageTint = Color.White;
            radioOption4.CheckedOutline = Color.DarkRed;
            radioOption4.Content = "Вариант4";
            radioOption4.Font = new Font("Microsoft Sans Serif", 9.75F);
            radioOption4.ForeColor = Color.Black;
            radioOption4.Group = 1;
            radioOption4.HoverBackground = Color.RosyBrown;
            radioOption4.HoverForeColor = Color.Black;
            radioOption4.HoverImageTint = Color.DimGray;
            radioOption4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            radioOption4.Image = null;
            radioOption4.ImageExpand = new Point(0, 0);
            radioOption4.Location = new Point(20, 265);
            radioOption4.Name = "radioOption4";
            radioOption4.NormalBackground = Color.White;
            radioOption4.NormalForeColor = Color.Black;
            radioOption4.NormalImageTint = Color.Black;
            radioOption4.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption4.OutlineThickness = 1F;
            radioOption4.Padding = new Padding(12);
            radioOption4.PressedBackground = Color.Maroon;
            radioOption4.PressedForeColor = Color.FromArgb(32, 32, 32);
            radioOption4.PressedImageTint = Color.FromArgb(32, 32, 32);
            radioOption4.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            radioOption4.Rounding = new Padding(8);
            radioOption4.Size = new Size(440, 30);
            radioOption4.TabIndex = 14;
            radioOption4.TextAlignment = StringAlignment.Center;
            radioOption4.TextPadding = 12;
            radioOption4.TextSpacing = 2;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 8;
            cuiFormRounder1.TargetForm = null;
            // 
            // cuiFormRounder2
            // 
            cuiFormRounder2.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder2.Rounding = 20;
            cuiFormRounder2.TargetForm = null;
            // 
            // cuiTooltipHover1
            // 
            cuiTooltipHover1.BackColor = Color.Black;
            cuiTooltipHover1.Content = "Перейти Далее";
            cuiTooltipHover1.ForeColor = SystemColors.ButtonFace;
            cuiTooltipHover1.TargetControl = null;
            cuiTooltipHover1.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            cuiTooltipHover1.TooltipPositionOffset = new Size(0, 0);
            // 
            // FormQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(radioOption4);
            Controls.Add(radioOption3);
            Controls.Add(radioOption2);
            Controls.Add(radioOption1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(lblQuestion);
            Controls.Add(lblProgress);
            Controls.Add(lblTimer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormQuestions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Прохождение теста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblQuestion;
        private CuoreUI.Controls.cuiButton btnNext;
        private CuoreUI.Controls.cuiButton btnPrevious;
        private CuoreUI.Controls.cuiButtonGroup radioOption1;
        private CuoreUI.Controls.cuiButtonGroup radioOption2;
        private CuoreUI.Controls.cuiButtonGroup radioOption3;
        private CuoreUI.Controls.cuiButtonGroup radioOption4;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder2;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover1;
    }
}