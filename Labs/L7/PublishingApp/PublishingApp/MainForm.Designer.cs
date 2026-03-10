namespace PublishingApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;

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
            dataGridViewBooks = new DataGridView();
            buttonOrder = new Button();
            buttonRefresh = new Button();
            buttonExit = new Button();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(14, 58);
            dataGridViewBooks.Margin = new Padding(4, 3, 4, 3);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(887, 404);
            dataGridViewBooks.TabIndex = 0;
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = SystemColors.Control;
            buttonOrder.ForeColor = Color.Black;
            buttonOrder.Location = new Point(14, 479);
            buttonOrder.Margin = new Padding(4, 3, 4, 3);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(175, 46);
            buttonOrder.TabIndex = 1;
            buttonOrder.Text = "Оформить предзаказ";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(196, 479);
            buttonRefresh.Margin = new Padding(4, 3, 4, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 46);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Обновить список";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.Control;
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(761, 479);
            buttonExit.Margin = new Padding(4, 3, 4, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(140, 46);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 14F);
            labelTitle.Location = new Point(14, 10);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(273, 24);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Каталог книг для предзаказа";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 539);
            Controls.Add(labelTitle);
            Controls.Add(buttonExit);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonOrder);
            Controls.Add(dataGridViewBooks);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Издательство - Предзаказы";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}