namespace PizzaServiceEF
{
    partial class FormReviews
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
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEVIEWSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rCUSTOMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.AllowUserToAddRows = false;
            this.dataGridViewComments.AllowUserToDeleteRows = false;
            this.dataGridViewComments.AllowUserToResizeColumns = false;
            this.dataGridViewComments.AllowUserToResizeRows = false;
            this.dataGridViewComments.AutoGenerateColumns = false;
            this.dataGridViewComments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewComments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rCUSTOMERIDDataGridViewTextBoxColumn,
            this.rDATEDataGridViewTextBoxColumn,
            this.rTEXTDataGridViewTextBoxColumn,
            this.rIDDataGridViewTextBoxColumn,
            this.cUSTOMERSDataGridViewTextBoxColumn});
            this.dataGridViewComments.DataSource = this.rEVIEWSBindingSource;
            this.dataGridViewComments.GridColor = System.Drawing.Color.White;
            this.dataGridViewComments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.ReadOnly = true;
            this.dataGridViewComments.RowHeadersVisible = false;
            this.dataGridViewComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewComments.Size = new System.Drawing.Size(510, 107);
            this.dataGridViewComments.TabIndex = 0;
            this.dataGridViewComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComments_CellClick);
            this.dataGridViewComments.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewComments_DataError);
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataSource = typeof(PizzaServiceDataEF.CUSTOMERS);
            // 
            // rEVIEWSBindingSource
            // 
            this.rEVIEWSBindingSource.DataSource = typeof(PizzaServiceDataEF.REVIEWS);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(13)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(13, 304);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(509, 45);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати відгук";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.richTextBox1.Location = new System.Drawing.Point(13, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(509, 162);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // rCUSTOMERIDDataGridViewTextBoxColumn
            // 
            this.rCUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "R_CUSTOMERID";
            this.rCUSTOMERIDDataGridViewTextBoxColumn.DataSource = this.cUSTOMERSBindingSource;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.rCUSTOMERIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.rCUSTOMERIDDataGridViewTextBoxColumn.DisplayMember = "C_NAME";
            this.rCUSTOMERIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rCUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "Користувач";
            this.rCUSTOMERIDDataGridViewTextBoxColumn.Name = "rCUSTOMERIDDataGridViewTextBoxColumn";
            this.rCUSTOMERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rCUSTOMERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rCUSTOMERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rCUSTOMERIDDataGridViewTextBoxColumn.ValueMember = "C_ID";
            this.rCUSTOMERIDDataGridViewTextBoxColumn.Width = 350;
            // 
            // rDATEDataGridViewTextBoxColumn
            // 
            this.rDATEDataGridViewTextBoxColumn.DataPropertyName = "R_DATE";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.rDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rDATEDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.rDATEDataGridViewTextBoxColumn.Name = "rDATEDataGridViewTextBoxColumn";
            this.rDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rDATEDataGridViewTextBoxColumn.Width = 170;
            // 
            // rTEXTDataGridViewTextBoxColumn
            // 
            this.rTEXTDataGridViewTextBoxColumn.DataPropertyName = "R_TEXT";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(219)))), ((int)(((byte)(15)))));
            this.rTEXTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.rTEXTDataGridViewTextBoxColumn.HeaderText = "Відгук";
            this.rTEXTDataGridViewTextBoxColumn.Name = "rTEXTDataGridViewTextBoxColumn";
            this.rTEXTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rTEXTDataGridViewTextBoxColumn.Visible = false;
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "R_ID";
            this.rIDDataGridViewTextBoxColumn.HeaderText = "R_ID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            this.rIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cUSTOMERSDataGridViewTextBoxColumn
            // 
            this.cUSTOMERSDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERS";
            this.cUSTOMERSDataGridViewTextBoxColumn.HeaderText = "CUSTOMERS";
            this.cUSTOMERSDataGridViewTextBoxColumn.Name = "cUSTOMERSDataGridViewTextBoxColumn";
            this.cUSTOMERSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTOMERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewComments);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Відгуки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn rUSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rEVIEWSBindingSource;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn rCUSTOMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERSDataGridViewTextBoxColumn;
    }
}