namespace NumberApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbSourceBase;
        private System.Windows.Forms.ComboBox cmbTargetBase;
        private System.Windows.Forms.TextBox txtSourceNumber;
        private System.Windows.Forms.TextBox txtTargetNumber;
        private System.Windows.Forms.Button btnPerformConversion;
        private System.Windows.Forms.Button btnStoreConversion;
        private System.Windows.Forms.DataGridView dgvConversions;
        private System.Windows.Forms.GroupBox grpConversion;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.Label lblSourceBase;
        private System.Windows.Forms.Label lblTargetBase;
        private System.Windows.Forms.Label lblSourceNumber;
        private System.Windows.Forms.Label lblTargetNumber;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbSourceBase = new System.Windows.Forms.ComboBox();
            this.cmbTargetBase = new System.Windows.Forms.ComboBox();
            this.txtSourceNumber = new System.Windows.Forms.TextBox();
            this.txtTargetNumber = new System.Windows.Forms.TextBox();
            this.btnPerformConversion = new System.Windows.Forms.Button();
            this.btnStoreConversion = new System.Windows.Forms.Button();
            this.dgvConversions = new System.Windows.Forms.DataGridView();
            this.grpConversion = new System.Windows.Forms.GroupBox();
            this.lblTargetNumber = new System.Windows.Forms.Label();
            this.lblSourceNumber = new System.Windows.Forms.Label();
            this.lblTargetBase = new System.Windows.Forms.Label();
            this.lblSourceBase = new System.Windows.Forms.Label();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversions)).BeginInit();
            this.grpConversion.SuspendLayout();
            this.grpHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSourceBase
            // 
            this.cmbSourceBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSourceBase.Location = new System.Drawing.Point(150, 32);
            this.cmbSourceBase.Name = "cmbSourceBase";
            this.cmbSourceBase.Size = new System.Drawing.Size(160, 28);
            this.cmbSourceBase.TabIndex = 4;
            // 
            // cmbTargetBase
            // 
            this.cmbTargetBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTargetBase.Location = new System.Drawing.Point(150, 65);
            this.cmbTargetBase.Name = "cmbTargetBase";
            this.cmbTargetBase.Size = new System.Drawing.Size(160, 28);
            this.cmbTargetBase.TabIndex = 5;
            // 
            // txtSourceNumber
            // 
            this.txtSourceNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSourceNumber.Location = new System.Drawing.Point(150, 98);
            this.txtSourceNumber.Name = "txtSourceNumber";
            this.txtSourceNumber.Size = new System.Drawing.Size(200, 27);
            this.txtSourceNumber.TabIndex = 6;
            // 
            // txtTargetNumber
            // 
            this.txtTargetNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTargetNumber.Location = new System.Drawing.Point(150, 167);
            this.txtTargetNumber.Name = "txtTargetNumber";
            this.txtTargetNumber.ReadOnly = true;
            this.txtTargetNumber.Size = new System.Drawing.Size(200, 27);
            this.txtTargetNumber.TabIndex = 7;
            // 
            // btnPerformConversion
            // 
            this.btnPerformConversion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPerformConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformConversion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPerformConversion.Location = new System.Drawing.Point(150, 130);
            this.btnPerformConversion.Name = "btnPerformConversion";
            this.btnPerformConversion.Size = new System.Drawing.Size(139, 28);
            this.btnPerformConversion.TabIndex = 4;
            this.btnPerformConversion.Text = "Конвертировать";
            this.btnPerformConversion.UseVisualStyleBackColor = false;
            // 
            // btnStoreConversion
            // 
            this.btnStoreConversion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStoreConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreConversion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStoreConversion.Location = new System.Drawing.Point(308, 130);
            this.btnStoreConversion.Name = "btnStoreConversion";
            this.btnStoreConversion.Size = new System.Drawing.Size(134, 28);
            this.btnStoreConversion.TabIndex = 5;
            this.btnStoreConversion.Text = "Сохранить";
            this.btnStoreConversion.UseVisualStyleBackColor = false;
            // 
            // dgvConversions
            // 
            this.dgvConversions.BackgroundColor = System.Drawing.Color.White;
            this.dgvConversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConversions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConversions.Location = new System.Drawing.Point(3, 23);
            this.dgvConversions.Name = "dgvConversions";
            this.dgvConversions.RowHeadersWidth = 51;
            this.dgvConversions.Size = new System.Drawing.Size(754, 224);
            this.dgvConversions.TabIndex = 0;
            // 
            // grpConversion
            // 
            this.grpConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpConversion.Controls.Add(this.lblTargetNumber);
            this.grpConversion.Controls.Add(this.lblSourceNumber);
            this.grpConversion.Controls.Add(this.lblTargetBase);
            this.grpConversion.Controls.Add(this.lblSourceBase);
            this.grpConversion.Controls.Add(this.cmbSourceBase);
            this.grpConversion.Controls.Add(this.cmbTargetBase);
            this.grpConversion.Controls.Add(this.txtSourceNumber);
            this.grpConversion.Controls.Add(this.txtTargetNumber);
            this.grpConversion.Controls.Add(this.btnPerformConversion);
            this.grpConversion.Controls.Add(this.btnStoreConversion);
            this.grpConversion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpConversion.Location = new System.Drawing.Point(12, 12);
            this.grpConversion.Name = "grpConversion";
            this.grpConversion.Size = new System.Drawing.Size(460, 210);
            this.grpConversion.TabIndex = 0;
            this.grpConversion.TabStop = false;
            this.grpConversion.Text = " Конвертация чисел ";
            // 
            // lblTargetNumber
            // 
            this.lblTargetNumber.AutoSize = true;
            this.lblTargetNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTargetNumber.Location = new System.Drawing.Point(15, 170);
            this.lblTargetNumber.Name = "lblTargetNumber";
            this.lblTargetNumber.Size = new System.Drawing.Size(78, 20);
            this.lblTargetNumber.TabIndex = 0;
            this.lblTargetNumber.Text = "Результат:";
            // 
            // lblSourceNumber
            // 
            this.lblSourceNumber.AutoSize = true;
            this.lblSourceNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSourceNumber.Location = new System.Drawing.Point(15, 101);
            this.lblSourceNumber.Name = "lblSourceNumber";
            this.lblSourceNumber.Size = new System.Drawing.Size(113, 20);
            this.lblSourceNumber.TabIndex = 1;
            this.lblSourceNumber.Text = "Введите число:";
            // 
            // lblTargetBase
            // 
            this.lblTargetBase.AutoSize = true;
            this.lblTargetBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTargetBase.Location = new System.Drawing.Point(15, 68);
            this.lblTargetBase.Name = "lblTargetBase";
            this.lblTargetBase.Size = new System.Drawing.Size(131, 20);
            this.lblTargetBase.TabIndex = 2;
            this.lblTargetBase.Text = "Целевая система:";
            // 
            // lblSourceBase
            // 
            this.lblSourceBase.AutoSize = true;
            this.lblSourceBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSourceBase.Location = new System.Drawing.Point(15, 35);
            this.lblSourceBase.Name = "lblSourceBase";
            this.lblSourceBase.Size = new System.Drawing.Size(139, 20);
            this.lblSourceBase.TabIndex = 3;
            this.lblSourceBase.Text = "Исходная система:";
            // 
            // grpHistory
            // 
            this.grpHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grpHistory.Controls.Add(this.dgvConversions);
            this.grpHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpHistory.Location = new System.Drawing.Point(12, 230);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(760, 250);
            this.grpHistory.TabIndex = 1;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = " История конвертаций ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(488, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поддерживаемые системы: двоичная, восьмеричная, десятиричная, шестнадцатиричная.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpConversion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер систем счисления";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversions)).EndInit();
            this.grpConversion.ResumeLayout(false);
            this.grpConversion.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
    }
}