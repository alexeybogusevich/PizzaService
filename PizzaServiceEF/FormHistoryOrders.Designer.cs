namespace PizzaServiceEF
{
    partial class FormHistoryOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.ColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHTRANSACTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANSACTIONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORYLINESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORYHEADERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYHEADERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            this.dataGridViewHistory.AutoGenerateColumns = false;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hHIDDataGridViewTextBoxColumn,
            this.hHDATEDataGridViewTextBoxColumn,
            this.ColumnButton,
            this.hHTRANSACTIONDataGridViewTextBoxColumn,
            this.tRANSACTIONSDataGridViewTextBoxColumn,
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn,
            this.hISTORYLINESDataGridViewTextBoxColumn});
            this.dataGridViewHistory.DataSource = this.hISTORYHEADERSBindingSource;
            this.dataGridViewHistory.GridColor = System.Drawing.Color.White;
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewHistory.Size = new System.Drawing.Size(415, 236);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellClick);
            // 
            // ColumnButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnButton.HeaderText = "";
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.ReadOnly = true;
            this.ColumnButton.Text = "Деталі";
            this.ColumnButton.UseColumnTextForButtonValue = true;
            // 
            // hHIDDataGridViewTextBoxColumn
            // 
            this.hHIDDataGridViewTextBoxColumn.DataPropertyName = "HH_ID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.hHIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hHIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.hHIDDataGridViewTextBoxColumn.Name = "hHIDDataGridViewTextBoxColumn";
            this.hHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hHIDDataGridViewTextBoxColumn.Width = 35;
            // 
            // hHDATEDataGridViewTextBoxColumn
            // 
            this.hHDATEDataGridViewTextBoxColumn.DataPropertyName = "HH_DATE";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.hHDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.hHDATEDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.hHDATEDataGridViewTextBoxColumn.Name = "hHDATEDataGridViewTextBoxColumn";
            this.hHDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.hHDATEDataGridViewTextBoxColumn.Width = 280;
            // 
            // hHTRANSACTIONDataGridViewTextBoxColumn
            // 
            this.hHTRANSACTIONDataGridViewTextBoxColumn.DataPropertyName = "HH_TRANSACTION";
            this.hHTRANSACTIONDataGridViewTextBoxColumn.HeaderText = "HH_TRANSACTION";
            this.hHTRANSACTIONDataGridViewTextBoxColumn.Name = "hHTRANSACTIONDataGridViewTextBoxColumn";
            this.hHTRANSACTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.hHTRANSACTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // tRANSACTIONSDataGridViewTextBoxColumn
            // 
            this.tRANSACTIONSDataGridViewTextBoxColumn.DataPropertyName = "TRANSACTIONS";
            this.tRANSACTIONSDataGridViewTextBoxColumn.HeaderText = "TRANSACTIONS";
            this.tRANSACTIONSDataGridViewTextBoxColumn.Name = "tRANSACTIONSDataGridViewTextBoxColumn";
            this.tRANSACTIONSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANSACTIONSDataGridViewTextBoxColumn.Visible = false;
            // 
            // hHPAYMENTTYPEDataGridViewTextBoxColumn
            // 
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn.DataPropertyName = "HH_PAYMENT_TYPE";
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn.HeaderText = "HH_PAYMENT_TYPE";
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn.Name = "hHPAYMENTTYPEDataGridViewTextBoxColumn";
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.hHPAYMENTTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // hISTORYLINESDataGridViewTextBoxColumn
            // 
            this.hISTORYLINESDataGridViewTextBoxColumn.DataPropertyName = "HISTORY_LINES";
            this.hISTORYLINESDataGridViewTextBoxColumn.HeaderText = "HISTORY_LINES";
            this.hISTORYLINESDataGridViewTextBoxColumn.Name = "hISTORYLINESDataGridViewTextBoxColumn";
            this.hISTORYLINESDataGridViewTextBoxColumn.ReadOnly = true;
            this.hISTORYLINESDataGridViewTextBoxColumn.Visible = false;
            // 
            // hISTORYHEADERSBindingSource
            // 
            this.hISTORYHEADERSBindingSource.DataSource = typeof(PizzaServiceDataEF.HISTORY_HEADERS);
            // 
            // FormHistoryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 260);
            this.Controls.Add(this.dataGridViewHistory);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormHistoryOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваша історія замовлень";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYHEADERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.BindingSource hISTORYHEADERSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHTRANSACTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANSACTIONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hHPAYMENTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hISTORYLINESDataGridViewTextBoxColumn;
    }
}