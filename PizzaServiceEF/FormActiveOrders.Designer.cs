namespace PizzaServiceEF
{
    partial class FormActiveOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActiveOrders));
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.sTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERHEADERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oHADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oHSTOREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oHCUSTOMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTORESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERLINESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERHEADERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oHIDDataGridViewTextBoxColumn,
            this.oHADDRESSDataGridViewTextBoxColumn,
            this.oHSTOREDataGridViewTextBoxColumn,
            this.oHDATEDataGridViewTextBoxColumn,
            this.cUSTOMERSDataGridViewTextBoxColumn,
            this.oHCUSTOMERDataGridViewTextBoxColumn,
            this.sTORESDataGridViewTextBoxColumn,
            this.oRDERLINESDataGridViewTextBoxColumn});
            this.dataGridViewOrders.DataSource = this.oRDERHEADERSBindingSource;
            this.dataGridViewOrders.GridColor = System.Drawing.Color.White;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrders.Size = new System.Drawing.Size(640, 236);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellDoubleClick);
            // 
            // sTORESBindingSource
            // 
            this.sTORESBindingSource.DataSource = typeof(PizzaServiceDataEF.STORES);
            // 
            // oRDERHEADERSBindingSource
            // 
            this.oRDERHEADERSBindingSource.DataSource = typeof(PizzaServiceDataEF.ORDER_HEADERS);
            // 
            // oHIDDataGridViewTextBoxColumn
            // 
            this.oHIDDataGridViewTextBoxColumn.DataPropertyName = "OH_ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.oHIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.oHIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.oHIDDataGridViewTextBoxColumn.Name = "oHIDDataGridViewTextBoxColumn";
            this.oHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oHIDDataGridViewTextBoxColumn.Width = 35;
            // 
            // oHADDRESSDataGridViewTextBoxColumn
            // 
            this.oHADDRESSDataGridViewTextBoxColumn.DataPropertyName = "OH_ADDRESS";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.oHADDRESSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.oHADDRESSDataGridViewTextBoxColumn.HeaderText = "Ваша адреса";
            this.oHADDRESSDataGridViewTextBoxColumn.Name = "oHADDRESSDataGridViewTextBoxColumn";
            this.oHADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oHADDRESSDataGridViewTextBoxColumn.Width = 250;
            // 
            // oHSTOREDataGridViewTextBoxColumn
            // 
            this.oHSTOREDataGridViewTextBoxColumn.DataPropertyName = "OH_STORE";
            this.oHSTOREDataGridViewTextBoxColumn.DataSource = this.sTORESBindingSource;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.oHSTOREDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.oHSTOREDataGridViewTextBoxColumn.DisplayMember = "S_ADDRESS";
            this.oHSTOREDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oHSTOREDataGridViewTextBoxColumn.HeaderText = "Адреса ресторану";
            this.oHSTOREDataGridViewTextBoxColumn.Name = "oHSTOREDataGridViewTextBoxColumn";
            this.oHSTOREDataGridViewTextBoxColumn.ReadOnly = true;
            this.oHSTOREDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oHSTOREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oHSTOREDataGridViewTextBoxColumn.ValueMember = "S_ID";
            this.oHSTOREDataGridViewTextBoxColumn.Width = 200;
            // 
            // oHDATEDataGridViewTextBoxColumn
            // 
            this.oHDATEDataGridViewTextBoxColumn.DataPropertyName = "OH_DATE";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.oHDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.oHDATEDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.oHDATEDataGridViewTextBoxColumn.Name = "oHDATEDataGridViewTextBoxColumn";
            this.oHDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oHDATEDataGridViewTextBoxColumn.Width = 152;
            // 
            // cUSTOMERSDataGridViewTextBoxColumn
            // 
            this.cUSTOMERSDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERS";
            this.cUSTOMERSDataGridViewTextBoxColumn.HeaderText = "CUSTOMERS";
            this.cUSTOMERSDataGridViewTextBoxColumn.Name = "cUSTOMERSDataGridViewTextBoxColumn";
            this.cUSTOMERSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTOMERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // oHCUSTOMERDataGridViewTextBoxColumn
            // 
            this.oHCUSTOMERDataGridViewTextBoxColumn.DataPropertyName = "OH_CUSTOMER";
            this.oHCUSTOMERDataGridViewTextBoxColumn.HeaderText = "OH_CUSTOMER";
            this.oHCUSTOMERDataGridViewTextBoxColumn.Name = "oHCUSTOMERDataGridViewTextBoxColumn";
            this.oHCUSTOMERDataGridViewTextBoxColumn.ReadOnly = true;
            this.oHCUSTOMERDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTORESDataGridViewTextBoxColumn
            // 
            this.sTORESDataGridViewTextBoxColumn.DataPropertyName = "STORES";
            this.sTORESDataGridViewTextBoxColumn.HeaderText = "STORES";
            this.sTORESDataGridViewTextBoxColumn.Name = "sTORESDataGridViewTextBoxColumn";
            this.sTORESDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTORESDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERLINESDataGridViewTextBoxColumn
            // 
            this.oRDERLINESDataGridViewTextBoxColumn.DataPropertyName = "ORDER_LINES";
            this.oRDERLINESDataGridViewTextBoxColumn.HeaderText = "ORDER_LINES";
            this.oRDERLINESDataGridViewTextBoxColumn.Name = "oRDERLINESDataGridViewTextBoxColumn";
            this.oRDERLINESDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERLINESDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormActiveOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 260);
            this.Controls.Add(this.dataGridViewOrders);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormActiveOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Активні замовлення";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERHEADERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.BindingSource oRDERHEADERSBindingSource;
        private System.Windows.Forms.BindingSource sTORESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oHADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oHSTOREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oHCUSTOMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERLINESDataGridViewTextBoxColumn;
    }
}