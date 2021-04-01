
namespace PrimeNumbersWithUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CalculatePrimesWithinARangeBtn = new System.Windows.Forms.Button();
            this.ListOfPrimesListBox = new System.Windows.Forms.ListBox();
            this.SinglePrimeTxtBox = new System.Windows.Forms.TextBox();
            this.CalculateASinglePrimeBtn = new System.Windows.Forms.Button();
            this.SinglePrimeNumberResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsTheNumberAPrimeLabel = new System.Windows.Forms.Label();
            this.MainPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel1
            // 
            this.MainPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanel1.Controls.Add(this.textBox3);
            this.MainPanel1.Controls.Add(this.textBox2);
            this.MainPanel1.Controls.Add(this.CalculatePrimesWithinARangeBtn);
            this.MainPanel1.Controls.Add(this.ListOfPrimesListBox);
            this.MainPanel1.Controls.Add(this.SinglePrimeTxtBox);
            this.MainPanel1.Controls.Add(this.CalculateASinglePrimeBtn);
            this.MainPanel1.Controls.Add(this.SinglePrimeNumberResultLabel);
            this.MainPanel1.Controls.Add(this.label2);
            this.MainPanel1.Controls.Add(this.IsTheNumberAPrimeLabel);
            this.MainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel1.Location = new System.Drawing.Point(0, 0);
            this.MainPanel1.Name = "MainPanel1";
            this.MainPanel1.Size = new System.Drawing.Size(1085, 558);
            this.MainPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(470, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(470, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // CalculatePrimesWithinARangeBtn
            // 
            this.CalculatePrimesWithinARangeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CalculatePrimesWithinARangeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatePrimesWithinARangeBtn.Location = new System.Drawing.Point(625, 247);
            this.CalculatePrimesWithinARangeBtn.Name = "CalculatePrimesWithinARangeBtn";
            this.CalculatePrimesWithinARangeBtn.Size = new System.Drawing.Size(105, 40);
            this.CalculatePrimesWithinARangeBtn.TabIndex = 6;
            this.CalculatePrimesWithinARangeBtn.Text = "Calculate";
            this.CalculatePrimesWithinARangeBtn.UseVisualStyleBackColor = false;
            this.CalculatePrimesWithinARangeBtn.Click += new System.EventHandler(this.CalculatePrimesWithinARangeBtn_Click);
            // 
            // ListOfPrimesListBox
            // 
            this.ListOfPrimesListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListOfPrimesListBox.FormattingEnabled = true;
            this.ListOfPrimesListBox.Location = new System.Drawing.Point(771, 224);
            this.ListOfPrimesListBox.Name = "ListOfPrimesListBox";
            this.ListOfPrimesListBox.Size = new System.Drawing.Size(66, 95);
            this.ListOfPrimesListBox.TabIndex = 5;
            this.ListOfPrimesListBox.Visible = false;
            // 
            // SinglePrimeTxtBox
            // 
            this.SinglePrimeTxtBox.Location = new System.Drawing.Point(470, 138);
            this.SinglePrimeTxtBox.Name = "SinglePrimeTxtBox";
            this.SinglePrimeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SinglePrimeTxtBox.TabIndex = 4;
            // 
            // CalculateASinglePrimeBtn
            // 
            this.CalculateASinglePrimeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CalculateASinglePrimeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CalculateASinglePrimeBtn.FlatAppearance.BorderSize = 2;
            this.CalculateASinglePrimeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateASinglePrimeBtn.ForeColor = System.Drawing.Color.Black;
            this.CalculateASinglePrimeBtn.Location = new System.Drawing.Point(625, 125);
            this.CalculateASinglePrimeBtn.Name = "CalculateASinglePrimeBtn";
            this.CalculateASinglePrimeBtn.Size = new System.Drawing.Size(105, 40);
            this.CalculateASinglePrimeBtn.TabIndex = 3;
            this.CalculateASinglePrimeBtn.Text = "Calculate";
            this.CalculateASinglePrimeBtn.UseVisualStyleBackColor = false;
            this.CalculateASinglePrimeBtn.Click += new System.EventHandler(this.CalculateASinglePrimeBtn_Click);
            // 
            // SinglePrimeNumberResultLabel
            // 
            this.SinglePrimeNumberResultLabel.AutoSize = true;
            this.SinglePrimeNumberResultLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.SinglePrimeNumberResultLabel.Location = new System.Drawing.Point(766, 132);
            this.SinglePrimeNumberResultLabel.Name = "SinglePrimeNumberResultLabel";
            this.SinglePrimeNumberResultLabel.Size = new System.Drawing.Size(71, 26);
            this.SinglePrimeNumberResultLabel.TabIndex = 2;
            this.SinglePrimeNumberResultLabel.Text = "label3";
            this.SinglePrimeNumberResultLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get all the primes between a certain range";
            // 
            // IsTheNumberAPrimeLabel
            // 
            this.IsTheNumberAPrimeLabel.AutoSize = true;
            this.IsTheNumberAPrimeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsTheNumberAPrimeLabel.Location = new System.Drawing.Point(12, 132);
            this.IsTheNumberAPrimeLabel.Name = "IsTheNumberAPrimeLabel";
            this.IsTheNumberAPrimeLabel.Size = new System.Drawing.Size(427, 26);
            this.IsTheNumberAPrimeLabel.TabIndex = 0;
            this.IsTheNumberAPrimeLabel.Text = "Enter a number to see if it\'s a prime or not.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 558);
            this.Controls.Add(this.MainPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainPanel1.ResumeLayout(false);
            this.MainPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel1;
        private System.Windows.Forms.Label SinglePrimeNumberResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IsTheNumberAPrimeLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CalculatePrimesWithinARangeBtn;
        private System.Windows.Forms.ListBox ListOfPrimesListBox;
        private System.Windows.Forms.TextBox SinglePrimeTxtBox;
        private System.Windows.Forms.Button CalculateASinglePrimeBtn;
    }
}

