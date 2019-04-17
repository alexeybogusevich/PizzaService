namespace PizzaServiceEF
{
    partial class FormOrderHeader
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
            this.components = new System.ComponentModel.Container();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.labelHouse = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.labelApp = new System.Windows.Forms.Label();
            this.textBoxApp = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(122, 135);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(195, 22);
            this.textBoxStreet.TabIndex = 1;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(122, 98);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(195, 22);
            this.textBoxCity.TabIndex = 4;
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(70, 101);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(46, 16);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "Місто";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreet.Location = new System.Drawing.Point(65, 138);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(51, 16);
            this.labelStreet.TabIndex = 10;
            this.labelStreet.Text = "Вулиця";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPayment.Location = new System.Drawing.Point(36, 235);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(80, 16);
            this.labelPayment.TabIndex = 11;
            this.labelPayment.Text = "Тип оплати";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.BackColor = System.Drawing.Color.White;
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Готівка",
            "Карткою кур\'єру",
            "Карткою онлайн"});
            this.comboBoxPayment.Location = new System.Drawing.Point(123, 232);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(129, 24);
            this.comboBoxPayment.TabIndex = 12;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHouse.Location = new System.Drawing.Point(83, 175);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(33, 16);
            this.labelHouse.TabIndex = 13;
            this.labelHouse.Text = "Буд.";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHouse.Location = new System.Drawing.Point(122, 172);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(54, 22);
            this.textBoxHouse.TabIndex = 14;
            // 
            // labelApp
            // 
            this.labelApp.AutoSize = true;
            this.labelApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApp.Location = new System.Drawing.Point(231, 175);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(27, 16);
            this.labelApp.TabIndex = 15;
            this.labelApp.Text = "Кв.";
            // 
            // textBoxApp
            // 
            this.textBoxApp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxApp.Location = new System.Drawing.Point(264, 172);
            this.textBoxApp.Name = "textBoxApp";
            this.textBoxApp.Size = new System.Drawing.Size(53, 22);
            this.textBoxApp.TabIndex = 16;
            this.textBoxApp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxApp_KeyDown);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.Location = new System.Drawing.Point(93, 31);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(159, 24);
            this.labelOrder.TabIndex = 17;
            this.labelOrder.Text = "Замовлення №";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.White;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(97, 286);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(181, 34);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormOrderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.textBoxApp);
            this.Controls.Add(this.labelApp);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.labelHouse);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreet);
            this.Name = "FormOrderHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замовлення ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrderHeader_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label labelApp;
        private System.Windows.Forms.TextBox textBoxApp;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Button buttonOK;
    }
}