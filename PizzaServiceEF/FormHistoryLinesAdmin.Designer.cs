namespace PizzaServiceEF
{
    partial class FormHistoryLinesAdmin
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
            this.dataGridViewLines = new System.Windows.Forms.DataGridView();
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERLINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oLITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oLQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERHEADERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLORDERHEADERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLines
            // 
            this.dataGridViewLines.AutoGenerateColumns = false;
            this.dataGridViewLines.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oLITEMDataGridViewTextBoxColumn,
            this.oLQUANTITYDataGridViewTextBoxColumn,
            this.iTEMSDataGridViewTextBoxColumn,
            this.oRDERHEADERSDataGridViewTextBoxColumn,
            this.oLIDDataGridViewTextBoxColumn,
            this.oLORDERHEADERDataGridViewTextBoxColumn});
            this.dataGridViewLines.DataSource = this.oRDERLINESBindingSource;
            this.dataGridViewLines.GridColor = System.Drawing.Color.White;
            this.dataGridViewLines.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLines.Name = "dataGridViewLines";
            this.dataGridViewLines.RowHeadersVisible = false;
            this.dataGridViewLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewLines.Size = new System.Drawing.Size(360, 187);
            this.dataGridViewLines.TabIndex = 0;
            this.dataGridViewLines.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewLines_DataError);
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // oRDERLINESBindingSource
            // 
            this.oRDERLINESBindingSource.DataSource = typeof(PizzaServiceDataEF.ORDER_LINES);
            // 
            // oLITEMDataGridViewTextBoxColumn
            // 
            this.oLITEMDataGridViewTextBoxColumn.DataPropertyName = "OL_ITEM";
            this.oLITEMDataGridViewTextBoxColumn.DataSource = this.iTEMSBindingSource;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(46)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.oLITEMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.oLITEMDataGridViewTextBoxColumn.DisplayMember = "I_NAME";
            this.oLITEMDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oLITEMDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oLITEMDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.oLITEMDataGridViewTextBoxColumn.Name = "oLITEMDataGridViewTextBoxColumn";
            this.oLITEMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oLITEMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oLITEMDataGridViewTextBoxColumn.ValueMember = "I_ID";
            this.oLITEMDataGridViewTextBoxColumn.Width = 260;
            // 
            // oLQUANTITYDataGridViewTextBoxColumn
            // 
            this.oLQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "OL_QUANTITY";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(46)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.oLQUANTITYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.oLQUANTITYDataGridViewTextBoxColumn.HeaderText = "Кількість";
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
            // FormHistoryLinesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.dataGridViewLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FormHistoryLinesAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страви";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERLINESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLines;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private System.Windows.Forms.BindingSource oRDERLINESBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn oLITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERHEADERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLORDERHEADERDataGridViewTextBoxColumn;
    }
}