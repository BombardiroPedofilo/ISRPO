namespace PublishingApp
{
    partial class FormOrder
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCustomerInfo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.ComboBox comboBoxOffice;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxOffice;

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
            labelBookTitle = new Label();
            labelAuthor = new Label();
            labelPrice = new Label();
            labelCustomerInfo = new Label();
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            labelOffice = new Label();
            comboBoxOffice = new ComboBox();
            buttonCreateOrder = new Button();
            buttonCancel = new Button();
            groupBoxBook = new GroupBox();
            groupBoxCustomer = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxOffice = new GroupBox();
            groupBoxBook.SuspendLayout();
            groupBoxCustomer.SuspendLayout();
            groupBoxOffice.SuspendLayout();
            SuspendLayout();
            // 
            // labelBookTitle
            // 
            labelBookTitle.AutoSize = true;
            labelBookTitle.Font = new Font("Microsoft Sans Serif", 10F);
            labelBookTitle.Location = new Point(8, 39);
            labelBookTitle.Margin = new Padding(5, 0, 5, 0);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.RightToLeft = RightToLeft.No;
            labelBookTitle.Size = new Size(63, 20);
            labelBookTitle.TabIndex = 0;
            labelBookTitle.Text = "Книга:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(8, 84);
            labelAuthor.Margin = new Padding(5, 0, 5, 0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(54, 20);
            labelAuthor.TabIndex = 1;
            labelAuthor.Text = "Автор:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 10F);
            labelPrice.ForeColor = Color.Black;
            labelPrice.Location = new Point(8, 131);
            labelPrice.Margin = new Padding(5, 0, 5, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.RightToLeft = RightToLeft.No;
            labelPrice.Size = new Size(57, 20);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена:";
            // 
            // labelCustomerInfo
            // 
            labelCustomerInfo.AutoSize = true;
            labelCustomerInfo.Location = new Point(8, 39);
            labelCustomerInfo.Margin = new Padding(5, 0, 5, 0);
            labelCustomerInfo.Name = "labelCustomerInfo";
            labelCustomerInfo.Size = new Size(177, 20);
            labelCustomerInfo.TabIndex = 3;
            labelCustomerInfo.Text = "Информация о клиенте:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(154, 77);
            textBoxName.Margin = new Padding(5, 4, 5, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = " ";
            textBoxName.Size = new Size(398, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(154, 123);
            textBoxAddress.Margin = new Padding(5, 4, 5, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.PlaceholderText = " ";
            textBoxAddress.Size = new Size(398, 27);
            textBoxAddress.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(154, 169);
            textBoxPhone.Margin = new Padding(5, 4, 5, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.PlaceholderText = " ";
            textBoxPhone.Size = new Size(398, 27);
            textBoxPhone.TabIndex = 6;
            // 
            // labelOffice
            // 
            labelOffice.AutoSize = true;
            labelOffice.Location = new Point(8, 39);
            labelOffice.Margin = new Padding(5, 0, 5, 0);
            labelOffice.Name = "labelOffice";
            labelOffice.Size = new Size(176, 20);
            labelOffice.TabIndex = 8;
            labelOffice.Text = "Выберите офис выдачи:";
            // 
            // comboBoxOffice
            // 
            comboBoxOffice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffice.FormattingEnabled = true;
            comboBoxOffice.Location = new Point(11, 77);
            comboBoxOffice.Margin = new Padding(5, 4, 5, 4);
            comboBoxOffice.Name = "comboBoxOffice";
            comboBoxOffice.Size = new Size(398, 28);
            comboBoxOffice.TabIndex = 9;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.BackColor = SystemColors.Control;
            buttonCreateOrder.ForeColor = Color.Black;
            buttonCreateOrder.Location = new Point(16, 644);
            buttonCreateOrder.Margin = new Padding(5, 4, 5, 4);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(494, 61);
            buttonCreateOrder.TabIndex = 10;
            buttonCreateOrder.Text = "Оформить заказ";
            buttonCreateOrder.UseVisualStyleBackColor = false;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.Control;
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Location = new Point(511, 644);
            buttonCancel.Margin = new Padding(5, 4, 5, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(67, 61);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // groupBoxBook
            // 
            groupBoxBook.Controls.Add(labelBookTitle);
            groupBoxBook.Controls.Add(labelAuthor);
            groupBoxBook.Controls.Add(labelPrice);
            groupBoxBook.Location = new Point(16, 19);
            groupBoxBook.Margin = new Padding(5, 4, 5, 4);
            groupBoxBook.Name = "groupBoxBook";
            groupBoxBook.Padding = new Padding(5, 4, 5, 4);
            groupBoxBook.Size = new Size(562, 184);
            groupBoxBook.TabIndex = 12;
            groupBoxBook.TabStop = false;
            groupBoxBook.Text = "Информация о книге";
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(label4);
            groupBoxCustomer.Controls.Add(label2);
            groupBoxCustomer.Controls.Add(label1);
            groupBoxCustomer.Controls.Add(labelCustomerInfo);
            groupBoxCustomer.Controls.Add(textBoxName);
            groupBoxCustomer.Controls.Add(textBoxAddress);
            groupBoxCustomer.Controls.Add(textBoxPhone);
            groupBoxCustomer.Location = new Point(16, 212);
            groupBoxCustomer.Margin = new Padding(5, 4, 5, 4);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Padding = new Padding(5, 4, 5, 4);
            groupBoxCustomer.Size = new Size(562, 221);
            groupBoxCustomer.TabIndex = 13;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Данные клиента";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 175);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "Телефон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 123);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 9;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 77);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "ФИО";
            // 
            // groupBoxOffice
            // 
            groupBoxOffice.Controls.Add(labelOffice);
            groupBoxOffice.Controls.Add(comboBoxOffice);
            groupBoxOffice.Location = new Point(16, 499);
            groupBoxOffice.Margin = new Padding(5, 4, 5, 4);
            groupBoxOffice.Name = "groupBoxOffice";
            groupBoxOffice.Padding = new Padding(5, 4, 5, 4);
            groupBoxOffice.Size = new Size(562, 137);
            groupBoxOffice.TabIndex = 14;
            groupBoxOffice.TabStop = false;
            groupBoxOffice.Text = "Офис выдачи";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 731);
            Controls.Add(groupBoxOffice);
            Controls.Add(groupBoxCustomer);
            Controls.Add(groupBoxBook);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreateOrder);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оформление предзаказа";
            groupBoxBook.ResumeLayout(false);
            groupBoxBook.PerformLayout();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            groupBoxOffice.ResumeLayout(false);
            groupBoxOffice.PerformLayout();
            ResumeLayout(false);

        }
        private Label label4;
        private Label label2;
        private Label label1;
    }
}