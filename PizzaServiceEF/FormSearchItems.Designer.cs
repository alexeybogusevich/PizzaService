namespace PizzaServiceEF
{
    partial class FormSearchItems
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
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Location = new System.Drawing.Point(116, 28);
            this.textBoxIngredients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(255, 26);
            this.textBoxIngredients.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(116, 121);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(255, 26);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrice_KeyDown);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(19, 31);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 18);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Інгредієнт";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 124);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(94, 18);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Ціна до грн.";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(19, 78);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(79, 18);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Категорія";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(46)))), ((int)(((byte)(199)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(116, 163);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(255, 33);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Піца",
            "Напій",
            "Десерт",
            "Сайди"});
            this.comboBoxCategory.Location = new System.Drawing.Point(116, 75);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(255, 26);
            this.comboBoxCategory.TabIndex = 7;
            // 
            // FormSearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxIngredients);
            this.Font = new System.Drawing.Font("Arial", 11.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormSearchItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Критерії пошуку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}