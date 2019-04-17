namespace PizzaServiceEF
{
    partial class FormHistoryOrderSelected
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
            this.dataGridViewHistoryLines = new System.Windows.Forms.DataGridView();
            this.hISTORYLINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hLITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hLQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORYHEADERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hLORDERHEADERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRepeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYLINESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoryLines
            // 
            this.dataGridViewHistoryLines.AllowUserToAddRows = false;
            this.dataGridViewHistoryLines.AllowUserToDeleteRows = false;
            this.dataGridViewHistoryLines.AllowUserToResizeColumns = false;
            this.dataGridViewHistoryLines.AllowUserToResizeRows = false;
            this.dataGridViewHistoryLines.AutoGenerateColumns = false;
            this.dataGridViewHistoryLines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistoryLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hLITEMDataGridViewTextBoxColumn,
            this.hLQUANTITYDataGridViewTextBoxColumn,
            this.hISTORYHEADERSDataGridViewTextBoxColumn,
            this.iTEMSDataGridViewTextBoxColumn,
            this.hLORDERHEADERDataGridViewTextBoxColumn,
            this.hLIDDataGridViewTextBoxColumn});
            this.dataGridViewHistoryLines.DataSource = this.hISTORYLINESBindingSource;
            this.dataGridViewHistoryLines.GridColor = System.Drawing.Color.White;
            this.dataGridViewHistoryLines.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHistoryLines.Name = "dataGridViewHistoryLines";
            this.dataGridViewHistoryLines.RowHeadersVisible = false;
            this.dataGridViewHistoryLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewHistoryLines.Size = new System.Drawing.Size(360, 143);
            this.dataGridViewHistoryLines.TabIndex = 0;
            this.dataGridViewHistoryLines.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewHistoryLines_DataError);
            // 
            // hISTORYLINESBindingSource
            // 
            this.hISTORYLINESBindingSource.DataSource = typeof(PizzaServiceDataEF.HISTORY_LINES);
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // hLITEMDataGridViewTextBoxColumn
            // 
            this.hLITEMDataGridViewTextBoxColumn.DataPropertyName = "HL_ITEM";
            this.hLITEMDataGridViewTextBoxColumn.DataSource = this.iTEMSBindingSource;
            this.hLITEMDataGridViewTextBoxColumn.DisplayMember = "I_NAME";
            this.hLITEMDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.hLITEMDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hLITEMDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.hLITEMDataGridViewTextBoxColumn.Name = "hLITEMDataGridViewTextBoxColumn";
            this.hLITEMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hLITEMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hLITEMDataGridViewTextBoxColumn.ValueMember = "I_ID";
            this.hLITEMDataGridViewTextBoxColumn.Width = 277;
            // 
            // hLQUANTITYDataGridViewTextBoxColumn
            // 
            this.hLQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "HL_QUANTITY";
            this.hLQUANTITYDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.hLQUANTITYDataGridViewTextBoxColumn.Name = "hLQUANTITYDataGridViewTextBoxColumn";
            this.hLQUANTITYDataGridViewTextBoxColumn.Width = 80;
            // 
            // hISTORYHEADERSDataGridViewTextBoxColumn
            // 
            this.hISTORYHEADERSDataGridViewTextBoxColumn.DataPropertyName = "HISTORY_HEADERS";
            this.hISTORYHEADERSDataGridViewTextBoxColumn.HeaderText = "HISTORY_HEADERS";
            this.hISTORYHEADERSDataGridViewTextBoxColumn.Name = "hISTORYHEADERSDataGridViewTextBoxColumn";
            this.hISTORYHEADERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMSDataGridViewTextBoxColumn
            // 
            this.iTEMSDataGridViewTextBoxColumn.DataPropertyName = "ITEMS";
            this.iTEMSDataGridViewTextBoxColumn.HeaderText = "ITEMS";
            this.iTEMSDataGridViewTextBoxColumn.Name = "iTEMSDataGridViewTextBoxColumn";
            this.iTEMSDataGridViewTextBoxColumn.Visible = false;
            // 
            // hLORDERHEADERDataGridViewTextBoxColumn
            // 
            this.hLORDERHEADERDataGridViewTextBoxColumn.DataPropertyName = "HL_ORDER_HEADER";
            this.hLORDERHEADERDataGridViewTextBoxColumn.HeaderText = "HL_ORDER_HEADER";
            this.hLORDERHEADERDataGridViewTextBoxColumn.Name = "hLORDERHEADERDataGridViewTextBoxColumn";
            this.hLORDERHEADERDataGridViewTextBoxColumn.Visible = false;
            // 
            // hLIDDataGridViewTextBoxColumn
            // 
            this.hLIDDataGridViewTextBoxColumn.DataPropertyName = "HL_ID";
            this.hLIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.hLIDDataGridViewTextBoxColumn.Name = "hLIDDataGridViewTextBoxColumn";
            this.hLIDDataGridViewTextBoxColumn.Visible = false;
            this.hLIDDataGridViewTextBoxColumn.Width = 35;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRepeat.ForeColor = System.Drawing.Color.White;
            this.buttonRepeat.Location = new System.Drawing.Point(13, 165);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(360, 37);
            this.buttonRepeat.TabIndex = 1;
            this.buttonRepeat.Text = "Зробити аналогічне замовлення";
            this.buttonRepeat.UseVisualStyleBackColor = false;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // FormHistoryOrderSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.buttonRepeat);
            this.Controls.Add(this.dataGridViewHistoryLines);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormHistoryOrderSelected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Деталі замовлення";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYLINESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistoryLines;
        private System.Windows.Forms.BindingSource hISTORYLINESBindingSource;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn hLITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hLQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hISTORYHEADERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hLORDERHEADERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRepeat;
    }
}