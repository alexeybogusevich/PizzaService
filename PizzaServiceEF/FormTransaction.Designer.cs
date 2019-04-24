namespace PizzaServiceEF
{
    partial class FormTransaction
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
            this.textBoxCard1 = new System.Windows.Forms.TextBox();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelTerms = new System.Windows.Forms.Label();
            this.labelCVV = new System.Windows.Forms.Label();
            this.checkBoxApprove = new System.Windows.Forms.CheckBox();
            this.textBoxCard2 = new System.Windows.Forms.TextBox();
            this.textBoxCard3 = new System.Windows.Forms.TextBox();
            this.textBoxCard4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCard1
            // 
            this.textBoxCard1.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxCard1.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCard1.Location = new System.Drawing.Point(38, 41);
            this.textBoxCard1.Name = "textBoxCard1";
            this.textBoxCard1.Size = new System.Drawing.Size(57, 32);
            this.textBoxCard1.TabIndex = 0;
            this.textBoxCard1.TextChanged += new System.EventHandler(this.textBoxCard1_TextChanged);
            this.textBoxCard1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCard_KeyDown);
            this.textBoxCard1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCard_KeyPress);
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Font = new System.Drawing.Font("Arial", 14F);
            this.textBoxCVV.Location = new System.Drawing.Point(120, 140);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.PasswordChar = '•';
            this.textBoxCVV.Size = new System.Drawing.Size(61, 29);
            this.textBoxCVV.TabIndex = 1;
            this.textBoxCVV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCVV_KeyDown);
            this.textBoxCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCVV_KeyPress);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.BackColor = System.Drawing.Color.White;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYear.Font = new System.Drawing.Font("Arial", 14F);
            this.comboBoxYear.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxYear.Location = new System.Drawing.Point(197, 91);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(61, 30);
            this.comboBoxYear.TabIndex = 2;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.BackColor = System.Drawing.Color.White;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonth.Font = new System.Drawing.Font("Arial", 14F);
            this.comboBoxMonth.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(120, 91);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(61, 30);
            this.comboBoxMonth.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(303, 182);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(123, 38);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Переказ";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Arial", 12F);
            this.labelSum.Location = new System.Drawing.Point(321, 146);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(37, 18);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "sum";
            // 
            // labelTerms
            // 
            this.labelTerms.AutoSize = true;
            this.labelTerms.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerms.Location = new System.Drawing.Point(35, 99);
            this.labelTerms.Name = "labelTerms";
            this.labelTerms.Size = new System.Drawing.Size(71, 16);
            this.labelTerms.TabIndex = 6;
            this.labelTerms.Text = "Термін дії";
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Arial", 10F);
            this.labelCVV.Location = new System.Drawing.Point(70, 148);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(36, 16);
            this.labelCVV.TabIndex = 7;
            this.labelCVV.Text = "CVV";
            // 
            // checkBoxApprove
            // 
            this.checkBoxApprove.AutoSize = true;
            this.checkBoxApprove.Font = new System.Drawing.Font("Arial", 8.5F);
            this.checkBoxApprove.Location = new System.Drawing.Point(38, 193);
            this.checkBoxApprove.Name = "checkBoxApprove";
            this.checkBoxApprove.Size = new System.Drawing.Size(259, 19);
            this.checkBoxApprove.TabIndex = 9;
            this.checkBoxApprove.Text = "Я згоден з умовами публічної пропозиції.";
            this.checkBoxApprove.UseVisualStyleBackColor = true;
            // 
            // textBoxCard2
            // 
            this.textBoxCard2.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxCard2.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCard2.Location = new System.Drawing.Point(101, 41);
            this.textBoxCard2.Name = "textBoxCard2";
            this.textBoxCard2.Size = new System.Drawing.Size(57, 32);
            this.textBoxCard2.TabIndex = 10;
            this.textBoxCard2.TextChanged += new System.EventHandler(this.textBoxCard2_TextChanged);
            this.textBoxCard2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCard2_KeyDown);
            this.textBoxCard2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCard2_KeyPress);
            // 
            // textBoxCard3
            // 
            this.textBoxCard3.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxCard3.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCard3.Location = new System.Drawing.Point(164, 41);
            this.textBoxCard3.Name = "textBoxCard3";
            this.textBoxCard3.Size = new System.Drawing.Size(57, 32);
            this.textBoxCard3.TabIndex = 11;
            this.textBoxCard3.TextChanged += new System.EventHandler(this.textBoxCard3_TextChanged);
            this.textBoxCard3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCard3_KeyDown);
            this.textBoxCard3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCard3_KeyPress);
            // 
            // textBoxCard4
            // 
            this.textBoxCard4.Font = new System.Drawing.Font("Arial", 16F);
            this.textBoxCard4.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCard4.Location = new System.Drawing.Point(227, 41);
            this.textBoxCard4.Name = "textBoxCard4";
            this.textBoxCard4.Size = new System.Drawing.Size(57, 32);
            this.textBoxCard4.TabIndex = 12;
            this.textBoxCard4.TextChanged += new System.EventHandler(this.textBoxCard4_TextChanged);
            this.textBoxCard4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCard4_KeyDown);
            this.textBoxCard4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCard4_KeyPress);
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 232);
            this.Controls.Add(this.textBoxCard4);
            this.Controls.Add(this.textBoxCard3);
            this.Controls.Add(this.textBoxCard2);
            this.Controls.Add(this.checkBoxApprove);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.labelTerms);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.textBoxCard1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Грошовий переказ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransaction_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCard1;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelTerms;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.CheckBox checkBoxApprove;
        private System.Windows.Forms.TextBox textBoxCard2;
        private System.Windows.Forms.TextBox textBoxCard3;
        private System.Windows.Forms.TextBox textBoxCard4;
    }
}