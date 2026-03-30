namespace PoleChudes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLetters;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.flowLetters = new System.Windows.Forms.FlowLayoutPanel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNewGame.Location = new System.Drawing.Point(100, 350);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(150, 50);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUndo.Location = new System.Drawing.Point(325, 350);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(150, 50);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCheck.Location = new System.Drawing.Point(550, 350);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 50);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // flowLetters
            // 
            this.flowLetters.Location = new System.Drawing.Point(100, 150);
            this.flowLetters.Name = "flowLetters";
            this.flowLetters.Size = new System.Drawing.Size(600, 150);
            this.flowLetters.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtResult.Location = new System.Drawing.Point(200, 80);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(400, 47);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitle.Location = new System.Drawing.Point(280, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Поле чудеz";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.flowLetters);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поле чудес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}