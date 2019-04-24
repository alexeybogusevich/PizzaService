namespace PizzaServiceEF
{
    partial class FormActiveOrdersSelected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActiveOrdersSelected));
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.oLITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oLQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLORDERHEADERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERHEADERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERLINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oLITEMDataGridViewTextBoxColumn,
            this.oLQUANTITYDataGridViewTextBoxColumn,
            this.iTEMSDataGridViewTextBoxColumn,
            this.oLIDDataGridViewTextBoxColumn,
            this.oLORDERHEADERDataGridViewTextBoxColumn,
            this.oRDERHEADERSDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.oRDERLINESBindingSource;
            this.dataGridViewOrder.GridColor = System.Drawing.Color.White;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersVisible = false;
            this.dataGridViewOrder.Size = new System.Drawing.Size(360, 143);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOrder_DataError);
            // 
            // oLITEMDataGridViewTextBoxColumn
            // 
            this.oLITEMDataGridViewTextBoxColumn.DataPropertyName = "OL_ITEM";
            this.oLITEMDataGridViewTextBoxColumn.DataSource = this.iTEMSBindingSource;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.oLITEMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.oLITEMDataGridViewTextBoxColumn.DisplayMember = "I_NAME";
            this.oLITEMDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oLITEMDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.oLITEMDataGridViewTextBoxColumn.Name = "oLITEMDataGridViewTextBoxColumn";
            this.oLITEMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oLITEMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oLITEMDataGridViewTextBoxColumn.ValueMember = "I_ID";
            this.oLITEMDataGridViewTextBoxColumn.Width = 277;
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // oLQUANTITYDataGridViewTextBoxColumn
            // 
            this.oLQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "OL_QUANTITY";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.oLQUANTITYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.oLQUANTITYDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.oLQUANTITYDataGridViewTextBoxColumn.Name = "oLQUANTITYDataGridViewTextBoxColumn";
            this.oLQUANTITYDataGridViewTextBoxColumn.Width = 80;
            // 
            // iTEMSDataGridViewTextBoxColumn
            // 
            this.iTEMSDataGridViewTextBoxColumn.DataPropertyName = "ITEMS";
            this.iTEMSDataGridViewTextBoxColumn.HeaderText = "ITEMS";
            this.iTEMSDataGridViewTextBoxColumn.Name = "iTEMSDataGridViewTextBoxColumn";
            this.iTEMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // oLIDDataGridViewTextBoxColumn
            // 
            this.oLIDDataGridViewTextBoxColumn.DataPropertyName = "OL_ID";
            this.oLIDDataGridViewTextBoxColumn.HeaderText = "OL_ID";
            this.oLIDDataGridViewTextBoxColumn.Name = "oLIDDataGridViewTextBoxColumn";
            this.oLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // oLORDERHEADERDataGridViewTextBoxColumn
            // 
            this.oLORDERHEADERDataGridViewTextBoxColumn.DataPropertyName = "OL_ORDER_HEADER";
            this.oLORDERHEADERDataGridViewTextBoxColumn.HeaderText = "OL_ORDER_HEADER";
            this.oLORDERHEADERDataGridViewTextBoxColumn.Name = "oLORDERHEADERDataGridViewTextBoxColumn";
            this.oLORDERHEADERDataGridViewTextBoxColumn.Visible = false;
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
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(13, 166);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(359, 37);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Відмінити замовлення";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormActiveOrdersSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormActiveOrdersSelected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замовлення";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private System.Windows.Forms.BindingSource oRDERLINESBindingSource;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewComboBoxColumn oLITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLORDERHEADERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERHEADERSDataGridViewTextBoxColumn;
    }
}