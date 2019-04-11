namespace PizzaServiceEF
{
    partial class FormCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.oLITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oLQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oLORDERHEADERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERHEADERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERLINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAdditional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.AllowUserToResizeColumns = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.AutoGenerateColumns = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oLITEMDataGridViewTextBoxColumn,
            this.ITEMComboBoxColumn,
            this.oLQUANTITYDataGridViewTextBoxColumn,
            this.DeleteColumn,
            this.oLORDERHEADERDataGridViewTextBoxColumn,
            this.oLIDDataGridViewTextBoxColumn,
            this.iTEMSDataGridViewTextBoxColumn,
            this.oRDERHEADERSDataGridViewTextBoxColumn});
            this.dataGridViewCart.DataSource = this.oRDERLINESBindingSource;
            this.dataGridViewCart.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersVisible = false;
            this.dataGridViewCart.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCart.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewCart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewCart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCart.RowTemplate.Height = 30;
            this.dataGridViewCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCart.Size = new System.Drawing.Size(384, 238);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellClick);
            this.dataGridViewCart.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewCart_DataError);
            // 
            // oLITEMDataGridViewTextBoxColumn
            // 
            this.oLITEMDataGridViewTextBoxColumn.DataPropertyName = "OL_ITEM";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oLITEMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.oLITEMDataGridViewTextBoxColumn.HeaderText = "OL_ITEM";
            this.oLITEMDataGridViewTextBoxColumn.Name = "oLITEMDataGridViewTextBoxColumn";
            this.oLITEMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oLITEMDataGridViewTextBoxColumn.Visible = false;
            this.oLITEMDataGridViewTextBoxColumn.Width = 60;
            // 
            // ITEMComboBoxColumn
            // 
            this.ITEMComboBoxColumn.DataPropertyName = "OL_ITEM";
            this.ITEMComboBoxColumn.DataSource = this.iTEMSBindingSource;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.ITEMComboBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.ITEMComboBoxColumn.DisplayMember = "I_NAME";
            this.ITEMComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ITEMComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ITEMComboBoxColumn.HeaderText = "Назва";
            this.ITEMComboBoxColumn.Name = "ITEMComboBoxColumn";
            this.ITEMComboBoxColumn.ReadOnly = true;
            this.ITEMComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ITEMComboBoxColumn.ValueMember = "I_ID";
            this.ITEMComboBoxColumn.Width = 285;
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // oLQUANTITYDataGridViewTextBoxColumn
            // 
            this.oLQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "OL_QUANTITY";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.oLQUANTITYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.oLQUANTITYDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.oLQUANTITYDataGridViewTextBoxColumn.Name = "oLQUANTITYDataGridViewTextBoxColumn";
            this.oLQUANTITYDataGridViewTextBoxColumn.Width = 70;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.DataPropertyName = "OL_ID";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.DeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteColumn.HeaderText = " ";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = " ×";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 29;
            // 
            // oLORDERHEADERDataGridViewTextBoxColumn
            // 
            this.oLORDERHEADERDataGridViewTextBoxColumn.DataPropertyName = "OL_ORDER_HEADER";
            this.oLORDERHEADERDataGridViewTextBoxColumn.HeaderText = "OL_ORDER_HEADER";
            this.oLORDERHEADERDataGridViewTextBoxColumn.Name = "oLORDERHEADERDataGridViewTextBoxColumn";
            this.oLORDERHEADERDataGridViewTextBoxColumn.Visible = false;
            // 
            // oLIDDataGridViewTextBoxColumn
            // 
            this.oLIDDataGridViewTextBoxColumn.DataPropertyName = "OL_ID";
            this.oLIDDataGridViewTextBoxColumn.HeaderText = "OL_ID";
            this.oLIDDataGridViewTextBoxColumn.Name = "oLIDDataGridViewTextBoxColumn";
            this.oLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMSDataGridViewTextBoxColumn
            // 
            this.iTEMSDataGridViewTextBoxColumn.DataPropertyName = "ITEMS";
            this.iTEMSDataGridViewTextBoxColumn.HeaderText = "ITEMS";
            this.iTEMSDataGridViewTextBoxColumn.Name = "iTEMSDataGridViewTextBoxColumn";
            this.iTEMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERHEADERSDataGridViewTextBoxColumn
            // 
            this.oRDERHEADERSDataGridViewTextBoxColumn.DataPropertyName = "ORDER_HEADERS";
            this.oRDERHEADERSDataGridViewTextBoxColumn.HeaderText = "ORDER_HEADERS";
            this.oRDERHEADERSDataGridViewTextBoxColumn.Name = "oRDERHEADERSDataGridViewTextBoxColumn";
            this.oRDERHEADERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERLINESBindingSource
            // 
            this.oRDERLINESBindingSource.DataSource = typeof(PizzaServiceDataEF.ORDER_LINES);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(226, 247);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(146, 39);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Повернутись";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 11F);
            this.labelPrice.Location = new System.Drawing.Point(112, 259);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(16, 17);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "0";
            // 
            // labelAdditional
            // 
            this.labelAdditional.AutoSize = true;
            this.labelAdditional.Font = new System.Drawing.Font("Arial", 10.75F);
            this.labelAdditional.ForeColor = System.Drawing.Color.Black;
            this.labelAdditional.Location = new System.Drawing.Point(34, 258);
            this.labelAdditional.Name = "labelAdditional";
            this.labelAdditional.Size = new System.Drawing.Size(81, 17);
            this.labelAdditional.TabIndex = 3;
            this.labelAdditional.Text = "До сплати:";
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.labelAdditional);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(400, 400);
            this.MaximizeBox = false;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кошик";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource oRDERLINESBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAdditional;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ITEMComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLORDERHEADERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERHEADERSDataGridViewTextBoxColumn;
    }
}