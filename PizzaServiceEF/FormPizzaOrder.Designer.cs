namespace PizzaServiceEF
{
    partial class FormPizzaOrder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePizza = new System.Windows.Forms.TabPage();
            this.tabPageDrinks = new System.Windows.Forms.TabPage();
            this.tabPageDesserts = new System.Windows.Forms.TabPage();
            this.tabPageSides = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePizza);
            this.tabControl1.Controls.Add(this.tabPageDrinks);
            this.tabControl1.Controls.Add(this.tabPageDesserts);
            this.tabControl1.Controls.Add(this.tabPageSides);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 388);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePizza
            // 
            this.tabPagePizza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPagePizza.Location = new System.Drawing.Point(4, 25);
            this.tabPagePizza.Name = "tabPagePizza";
            this.tabPagePizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePizza.Size = new System.Drawing.Size(912, 359);
            this.tabPagePizza.TabIndex = 0;
            this.tabPagePizza.Text = "Піца";
            this.tabPagePizza.UseVisualStyleBackColor = true;
            // 
            // tabPageDrinks
            // 
            this.tabPageDrinks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageDrinks.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrinks.Name = "tabPageDrinks";
            this.tabPageDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrinks.Size = new System.Drawing.Size(912, 385);
            this.tabPageDrinks.TabIndex = 1;
            this.tabPageDrinks.Text = "Напої";
            this.tabPageDrinks.UseVisualStyleBackColor = true;
            // 
            // tabPageDesserts
            // 
            this.tabPageDesserts.Location = new System.Drawing.Point(4, 25);
            this.tabPageDesserts.Name = "tabPageDesserts";
            this.tabPageDesserts.Size = new System.Drawing.Size(912, 385);
            this.tabPageDesserts.TabIndex = 2;
            this.tabPageDesserts.Text = "Десерти";
            this.tabPageDesserts.UseVisualStyleBackColor = true;
            // 
            // tabPageSides
            // 
            this.tabPageSides.Location = new System.Drawing.Point(4, 25);
            this.tabPageSides.Name = "tabPageSides";
            this.tabPageSides.Size = new System.Drawing.Size(912, 385);
            this.tabPageSides.TabIndex = 3;
            this.tabPageSides.Text = "Сайди";
            this.tabPageSides.UseVisualStyleBackColor = true;
            // 
            // FormPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPizzaOrder";
            this.Text = "Піца - замовити з доставкою | Domino\'s Pizza";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePizza;
        private System.Windows.Forms.TabPage tabPageDrinks;
        private System.Windows.Forms.TabPage tabPageDesserts;
        private System.Windows.Forms.TabPage tabPageSides;
    }
}