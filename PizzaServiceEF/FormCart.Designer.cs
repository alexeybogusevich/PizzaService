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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.oRDERLINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLORDERHEADERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERHEADERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AutoGenerateColumns = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oLIDDataGridViewTextBoxColumn,
            this.oLORDERHEADERDataGridViewTextBoxColumn,
            this.oLITEMDataGridViewTextBoxColumn,
            this.oLQUANTITYDataGridViewTextBoxColumn,
            this.iTEMSDataGridViewTextBoxColumn,
            this.oRDERHEADERSDataGridViewTextBoxColumn});
            this.dataGridViewCart.DataSource = this.oRDERLINESBindingSource;
            this.dataGridViewCart.Location = new System.Drawing.Point(-1, -1);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersVisible = false;
            this.dataGridViewCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCart.Size = new System.Drawing.Size(387, 257);
            this.dataGridViewCart.TabIndex = 0;
            // 
            // oRDERLINESBindingSource
            // 
            this.oRDERLINESBindingSource.DataSource = typeof(PizzaServiceDataEF.ORDER_LINES);
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
            // oLITEMDataGridViewTextBoxColumn
            // 
            this.oLITEMDataGridViewTextBoxColumn.DataPropertyName = "OL_ITEM";
            this.oLITEMDataGridViewTextBoxColumn.HeaderText = "OL_ITEM";
            this.oLITEMDataGridViewTextBoxColumn.Name = "oLITEMDataGridViewTextBoxColumn";
            // 
            // oLQUANTITYDataGridViewTextBoxColumn
            // 
            this.oLQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "OL_QUANTITY";
            this.oLQUANTITYDataGridViewTextBoxColumn.HeaderText = "OL_QUANTITY";
            this.oLQUANTITYDataGridViewTextBoxColumn.Name = "oLQUANTITYDataGridViewTextBoxColumn";
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
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.dataGridViewCart);
            this.Name = "FormCart";
            this.Text = "Кошик";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLORDERHEADERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERHEADERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oRDERLINESBindingSource;
    }
}