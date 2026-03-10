namespace PublishingApp
{
    partial class FormReceipt
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.Button buttonSaveToFile;

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
            labelOrderNumber = new Label();
            labelBookTitle = new Label();
            labelCustomerName = new Label();
            labelOffice = new Label();
            labelOrderDate = new Label();
            labelPrice = new Label();
            buttonClose = new Button();
            groupBoxReceipt = new GroupBox();
            buttonSaveToFile = new Button();
            groupBoxReceipt.SuspendLayout();
            SuspendLayout();
            // 
            // labelOrderNumber
            // 
            labelOrderNumber.AutoSize = true;
            labelOrderNumber.Font = new Font("Microsoft Sans Serif", 14F);
            labelOrderNumber.Location = new Point(7, 35);
            labelOrderNumber.Margin = new Padding(4, 0, 4, 0);
            labelOrderNumber.Name = "labelOrderNumber";
            labelOrderNumber.Size = new Size(92, 24);
            labelOrderNumber.TabIndex = 0;
            labelOrderNumber.Text = "Заказ №:";
            // 
            // labelBookTitle
            // 
            labelBookTitle.AutoSize = true;
            labelBookTitle.Location = new Point(7, 81);
            labelBookTitle.Margin = new Padding(4, 0, 4, 0);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(45, 15);
            labelBookTitle.TabIndex = 1;
            labelBookTitle.Text = "Книга: ";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(7, 115);
            labelCustomerName.Margin = new Padding(4, 0, 4, 0);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(52, 15);
            labelCustomerName.TabIndex = 2;
            labelCustomerName.Text = "Клиент: ";
            // 
            // labelOffice
            // 
            labelOffice.AutoSize = true;
            labelOffice.Location = new Point(7, 150);
            labelOffice.Margin = new Padding(4, 0, 4, 0);
            labelOffice.Name = "labelOffice";
            labelOffice.Size = new Size(88, 15);
            labelOffice.TabIndex = 3;
            labelOffice.Text = "Офис выдачи: ";
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Location = new Point(7, 185);
            labelOrderDate.Margin = new Padding(4, 0, 4, 0);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(75, 15);
            labelOrderDate.TabIndex = 4;
            labelOrderDate.Text = "Дата заказа: ";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 12F);
            labelPrice.ForeColor = Color.Black;
            labelPrice.Location = new Point(7, 219);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(56, 20);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Цена: ";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.Control;
            buttonClose.ForeColor = Color.Black;
            buttonClose.Location = new Point(245, 325);
            buttonClose.Margin = new Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(140, 46);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // groupBoxReceipt
            // 
            groupBoxReceipt.Controls.Add(labelOrderNumber);
            groupBoxReceipt.Controls.Add(labelBookTitle);
            groupBoxReceipt.Controls.Add(labelCustomerName);
            groupBoxReceipt.Controls.Add(labelOffice);
            groupBoxReceipt.Controls.Add(labelOrderDate);
            groupBoxReceipt.Controls.Add(labelPrice);
            groupBoxReceipt.Location = new Point(14, 14);
            groupBoxReceipt.Margin = new Padding(4, 3, 4, 3);
            groupBoxReceipt.Name = "groupBoxReceipt";
            groupBoxReceipt.Padding = new Padding(4, 3, 4, 3);
            groupBoxReceipt.Size = new Size(434, 288);
            groupBoxReceipt.TabIndex = 8;
            groupBoxReceipt.TabStop = false;
            groupBoxReceipt.Text = "Детали заказа";
            // 
            // buttonSaveToFile
            // 
            buttonSaveToFile.BackColor = SystemColors.Control;
            buttonSaveToFile.ForeColor = Color.Black;
            buttonSaveToFile.Location = new Point(97, 325);
            buttonSaveToFile.Margin = new Padding(4, 3, 4, 3);
            buttonSaveToFile.Name = "buttonSaveToFile";
            buttonSaveToFile.Size = new Size(140, 46);
            buttonSaveToFile.TabIndex = 9;
            buttonSaveToFile.Text = "Сохранить чек";
            buttonSaveToFile.UseVisualStyleBackColor = false;
            buttonSaveToFile.Click += buttonSaveToFile_Click;
            // 
            // FormReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 383);
            Controls.Add(buttonSaveToFile);
            Controls.Add(groupBoxReceipt);
            Controls.Add(buttonClose);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Чек предзаказа";
            groupBoxReceipt.ResumeLayout(false);
            groupBoxReceipt.PerformLayout();
            ResumeLayout(false);

        }
    }
}