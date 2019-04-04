namespace PizzaServiceEF
{
    partial class FormPizzaAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSizes = new System.Windows.Forms.DataGridView();
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSIZEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIMAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hISTORYLINESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMAGESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERLINESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSizes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSizes
            // 
            this.dataGridViewSizes.AllowUserToAddRows = false;
            this.dataGridViewSizes.AllowUserToDeleteRows = false;
            this.dataGridViewSizes.AllowUserToResizeColumns = false;
            this.dataGridViewSizes.AllowUserToResizeRows = false;
            this.dataGridViewSizes.AutoGenerateColumns = false;
            this.dataGridViewSizes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewSizes.ColumnHeadersHeight = 29;
            this.dataGridViewSizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.iNAMEDataGridViewTextBoxColumn,
            this.iSIZEDataGridViewTextBoxColumn,
            this.iDESCRIPTIONDataGridViewTextBoxColumn,
            this.iCATEGORYDataGridViewTextBoxColumn,
            this.iPRICEDataGridViewTextBoxColumn,
            this.iIMAGEDataGridViewTextBoxColumn,
            this.hISTORYLINESDataGridViewTextBoxColumn,
            this.iMAGESDataGridViewTextBoxColumn,
            this.oRDERLINESDataGridViewTextBoxColumn});
            this.dataGridViewSizes.DataSource = this.iTEMSBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(6)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSizes.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewSizes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSizes.Name = "dataGridViewSizes";
            this.dataGridViewSizes.ReadOnly = true;
            this.dataGridViewSizes.RowHeadersVisible = false;
            this.dataGridViewSizes.RowHeadersWidth = 4;
            this.dataGridViewSizes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSizes.RowTemplate.Height = 58;
            this.dataGridViewSizes.RowTemplate.ReadOnly = true;
            this.dataGridViewSizes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSizes.Size = new System.Drawing.Size(206, 205);
            this.dataGridViewSizes.TabIndex = 0;
            this.dataGridViewSizes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSizes_CellClick);
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(12, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(206, 48);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати в кошик";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(248, 107);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 22);
            this.labelPrice.TabIndex = 2;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "I_ID";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(6)))), ((int)(((byte)(1)))));
            this.iIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.iIDDataGridViewTextBoxColumn.HeaderText = "I_ID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNAMEDataGridViewTextBoxColumn
            // 
            this.iNAMEDataGridViewTextBoxColumn.DataPropertyName = "I_NAME";
            this.iNAMEDataGridViewTextBoxColumn.HeaderText = "I_NAME";
            this.iNAMEDataGridViewTextBoxColumn.Name = "iNAMEDataGridViewTextBoxColumn";
            this.iNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iSIZEDataGridViewTextBoxColumn
            // 
            this.iSIZEDataGridViewTextBoxColumn.DataPropertyName = "I_SIZE";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(160)))));
            this.iSIZEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.iSIZEDataGridViewTextBoxColumn.HeaderText = "Розмір";
            this.iSIZEDataGridViewTextBoxColumn.Name = "iSIZEDataGridViewTextBoxColumn";
            this.iSIZEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSIZEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iSIZEDataGridViewTextBoxColumn.Width = 203;
            // 
            // iDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.iDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "I_DESCRIPTION";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "I_DESCRIPTION";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.Name = "iDESCRIPTIONDataGridViewTextBoxColumn";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDESCRIPTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // iCATEGORYDataGridViewTextBoxColumn
            // 
            this.iCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "I_CATEGORY";
            this.iCATEGORYDataGridViewTextBoxColumn.HeaderText = "I_CATEGORY";
            this.iCATEGORYDataGridViewTextBoxColumn.Name = "iCATEGORYDataGridViewTextBoxColumn";
            this.iCATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCATEGORYDataGridViewTextBoxColumn.Visible = false;
            // 
            // iPRICEDataGridViewTextBoxColumn
            // 
            this.iPRICEDataGridViewTextBoxColumn.DataPropertyName = "I_PRICE";
            this.iPRICEDataGridViewTextBoxColumn.HeaderText = "I_PRICE";
            this.iPRICEDataGridViewTextBoxColumn.Name = "iPRICEDataGridViewTextBoxColumn";
            this.iPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPRICEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iIMAGEDataGridViewTextBoxColumn
            // 
            this.iIMAGEDataGridViewTextBoxColumn.DataPropertyName = "I_IMAGE";
            this.iIMAGEDataGridViewTextBoxColumn.HeaderText = "I_IMAGE";
            this.iIMAGEDataGridViewTextBoxColumn.Name = "iIMAGEDataGridViewTextBoxColumn";
            this.iIMAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIMAGEDataGridViewTextBoxColumn.Visible = false;
            // 
            // hISTORYLINESDataGridViewTextBoxColumn
            // 
            this.hISTORYLINESDataGridViewTextBoxColumn.DataPropertyName = "HISTORY_LINES";
            this.hISTORYLINESDataGridViewTextBoxColumn.HeaderText = "HISTORY_LINES";
            this.hISTORYLINESDataGridViewTextBoxColumn.Name = "hISTORYLINESDataGridViewTextBoxColumn";
            this.hISTORYLINESDataGridViewTextBoxColumn.ReadOnly = true;
            this.hISTORYLINESDataGridViewTextBoxColumn.Visible = false;
            // 
            // iMAGESDataGridViewTextBoxColumn
            // 
            this.iMAGESDataGridViewTextBoxColumn.DataPropertyName = "IMAGES";
            this.iMAGESDataGridViewTextBoxColumn.HeaderText = "IMAGES";
            this.iMAGESDataGridViewTextBoxColumn.Name = "iMAGESDataGridViewTextBoxColumn";
            this.iMAGESDataGridViewTextBoxColumn.ReadOnly = true;
            this.iMAGESDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERLINESDataGridViewTextBoxColumn
            // 
            this.oRDERLINESDataGridViewTextBoxColumn.DataPropertyName = "ORDER_LINES";
            this.oRDERLINESDataGridViewTextBoxColumn.HeaderText = "ORDER_LINES";
            this.oRDERLINESDataGridViewTextBoxColumn.Name = "oRDERLINESDataGridViewTextBoxColumn";
            this.oRDERLINESDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERLINESDataGridViewTextBoxColumn.Visible = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(300, 249);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(18, 19);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "1";
            // 
            // buttonPlus
            // 
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPlus.Location = new System.Drawing.Point(324, 245);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(23, 23);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(272, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormPizzaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPizzaAdd";
            this.Text = "Додати";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSizes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSizes;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSIZEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIMAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hISTORYLINESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMAGESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERLINESDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button1;
    }
}