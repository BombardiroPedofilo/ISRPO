namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxFrom = new ComboBox();
            label1 = new Label();
            comboBoxTo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxAmount = new TextBox();
            labelResult = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.Font = new Font("Times New Roman", 12F);
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(228, 39);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(151, 30);
            comboBoxFrom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 1;
            label1.Text = "Исходная валюта";
            // 
            // comboBoxTo
            // 
            comboBoxTo.Font = new Font("Times New Roman", 12F);
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(227, 91);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(151, 30);
            comboBoxTo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(44, 93);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 3;
            label2.Text = "Целевая валюта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(45, 150);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 4;
            label3.Text = "Ввод суммы";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Times New Roman", 12F);
            textBoxAmount.Location = new Point(229, 148);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(149, 30);
            textBoxAmount.TabIndex = 5;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Times New Roman", 12F);
            labelResult.Location = new Point(241, 230);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 22);
            labelResult.TabIndex = 6;
            labelResult.Text = "label4";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxTo);
            groupBox1.Controls.Add(comboBoxFrom);
            groupBox1.Controls.Add(textBoxAmount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 194);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор валют и ввод суммы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(59, 227);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 8;
            label4.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 282);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "Конвертер валют";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFrom;
        private Label label1;
        private ComboBox comboBoxTo;
        private Label label2;
        private Label label3;
        private TextBox textBoxAmount;
        private Label labelResult;
        private GroupBox groupBox1;
        private Label label4;
    }
}
