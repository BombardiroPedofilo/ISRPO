namespace SkladApp
{
    partial class Sklad
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
            dataGridViewProducts = new DataGridView();
            textBoxName = new TextBox();
            textBoxStillage = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxCell = new TextBox();
            textBoxSearchStillage = new TextBox();
            textBoxSearchCell = new TextBox();
            textBoxSearchName = new TextBox();
            buttonSearchByCoords = new Button();
            buttonSearchByName = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            buttonSaveToDb = new Button();
            buttonEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            buttonRefresh = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(22, 22);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(625, 359);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(119, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxStillage
            // 
            textBoxStillage.Location = new Point(119, 64);
            textBoxStillage.Name = "textBoxStillage";
            textBoxStillage.Size = new Size(100, 23);
            textBoxStillage.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(119, 122);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(100, 23);
            textBoxQuantity.TabIndex = 4;
            // 
            // textBoxCell
            // 
            textBoxCell.Location = new Point(119, 93);
            textBoxCell.Name = "textBoxCell";
            textBoxCell.Size = new Size(100, 23);
            textBoxCell.TabIndex = 3;
            // 
            // textBoxSearchStillage
            // 
            textBoxSearchStillage.Location = new Point(6, 44);
            textBoxSearchStillage.Name = "textBoxSearchStillage";
            textBoxSearchStillage.Size = new Size(100, 23);
            textBoxSearchStillage.TabIndex = 7;
            // 
            // textBoxSearchCell
            // 
            textBoxSearchCell.Location = new Point(145, 44);
            textBoxSearchCell.Name = "textBoxSearchCell";
            textBoxSearchCell.Size = new Size(100, 23);
            textBoxSearchCell.TabIndex = 6;
            // 
            // textBoxSearchName
            // 
            textBoxSearchName.Location = new Point(96, 28);
            textBoxSearchName.Name = "textBoxSearchName";
            textBoxSearchName.Size = new Size(100, 23);
            textBoxSearchName.TabIndex = 5;
            // 
            // buttonSearchByCoords
            // 
            buttonSearchByCoords.Location = new Point(278, 43);
            buttonSearchByCoords.Name = "buttonSearchByCoords";
            buttonSearchByCoords.Size = new Size(75, 23);
            buttonSearchByCoords.TabIndex = 9;
            buttonSearchByCoords.Text = "Поиск";
            buttonSearchByCoords.UseVisualStyleBackColor = true;
            buttonSearchByCoords.Click += buttonSearchByCoords_Click;
            // 
            // buttonSearchByName
            // 
            buttonSearchByName.Location = new Point(278, 27);
            buttonSearchByName.Name = "buttonSearchByName";
            buttonSearchByName.Size = new Size(75, 23);
            buttonSearchByName.TabIndex = 11;
            buttonSearchByName.Text = "Поиск";
            buttonSearchByName.UseVisualStyleBackColor = true;
            buttonSearchByName.Click += buttonSearchByName_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(37, 150);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(144, 151);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSaveToDb
            // 
            buttonSaveToDb.Location = new Point(245, 150);
            buttonSaveToDb.Name = "buttonSaveToDb";
            buttonSaveToDb.Size = new Size(75, 23);
            buttonSaveToDb.TabIndex = 12;
            buttonSaveToDb.Text = "Сохранить";
            buttonSaveToDb.UseVisualStyleBackColor = true;
            buttonSaveToDb.Click += buttonSaveToDb_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(245, 67);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 15;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 16;
            label2.Text = "Номер сталлажа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 18;
            label3.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 96);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 17;
            label4.Text = "Номер ячейки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 31);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 19;
            label5.Text = "Наименование";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 20;
            label6.Text = "Стеллаж";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 26);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 21;
            label7.Text = "Ячейка";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonRefresh);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxStillage);
            groupBox1.Controls.Add(textBoxCell);
            groupBox1.Controls.Add(textBoxQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(buttonSaveToDb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Location = new Point(692, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 196);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(245, 22);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 19;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxSearchName);
            groupBox2.Controls.Add(buttonSearchByName);
            groupBox2.Location = new Point(692, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 89);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск по названию";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxSearchStillage);
            groupBox3.Controls.Add(textBoxSearchCell);
            groupBox3.Controls.Add(buttonSearchByCoords);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(692, 309);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(367, 89);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поиск по координатам";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewProducts);
            groupBox4.Location = new Point(12, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(673, 385);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Товар";
            // 
            // Sklad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 461);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Sklad";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private TextBox textBoxName;
        private TextBox textBoxStillage;
        private TextBox textBoxQuantity;
        private TextBox textBoxCell;
        private TextBox textBoxSearchStillage;
        private TextBox textBoxSearchCell;
        private TextBox textBoxSearchName;
        private Button button1;
        private Button buttonSearchByCoords;
        private Button buttonSearchByName;
        private Button button4;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonSaveToDb;
        private Button buttonEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonRefresh;
    }
}
