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
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.rEVIEWSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.AutoGenerateColumns = false;
            this.dataGridViewComments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIDDataGridViewTextBoxColumn,
            this.rUSERIDDataGridViewTextBoxColumn,
            this.rTEXTDataGridViewTextBoxColumn,
            this.rDATEDataGridViewTextBoxColumn,
            this.uSERSDataGridViewTextBoxColumn});
            this.dataGridViewComments.DataSource = this.rEVIEWSBindingSource;
            this.dataGridViewComments.GridColor = System.Drawing.Color.White;
            this.dataGridViewComments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.RowHeadersVisible = false;
            this.dataGridViewComments.Size = new System.Drawing.Size(510, 277);
            this.dataGridViewComments.TabIndex = 0;
            // 
            // rEVIEWSBindingSource
            // 
            this.rEVIEWSBindingSource.DataSource = typeof(PizzaServiceDataEF.REVIEWS);
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "R_ID";
            this.rIDDataGridViewTextBoxColumn.HeaderText = "R_ID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            this.rIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rUSERIDDataGridViewTextBoxColumn
            // 
            this.rUSERIDDataGridViewTextBoxColumn.DataPropertyName = "R_USERID";
            this.rUSERIDDataGridViewTextBoxColumn.HeaderText = "Користувач";
            this.rUSERIDDataGridViewTextBoxColumn.Name = "rUSERIDDataGridViewTextBoxColumn";
            // 
            // rTEXTDataGridViewTextBoxColumn
            // 
            this.rTEXTDataGridViewTextBoxColumn.DataPropertyName = "R_TEXT";
            this.rTEXTDataGridViewTextBoxColumn.HeaderText = "Відгук";
            this.rTEXTDataGridViewTextBoxColumn.Name = "rTEXTDataGridViewTextBoxColumn";
            // 
            // rDATEDataGridViewTextBoxColumn
            // 
            this.rDATEDataGridViewTextBoxColumn.DataPropertyName = "R_DATE";
            this.rDATEDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.rDATEDataGridViewTextBoxColumn.Name = "rDATEDataGridViewTextBoxColumn";
            // 
            // uSERSDataGridViewTextBoxColumn
            // 
            this.uSERSDataGridViewTextBoxColumn.DataPropertyName = "USERS";
            this.uSERSDataGridViewTextBoxColumn.HeaderText = "USERS";
            this.uSERSDataGridViewTextBoxColumn.Name = "uSERSDataGridViewTextBoxColumn";
            this.uSERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.dataGridViewComments);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Відгуки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.BindingSource rEVIEWSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERSDataGridViewTextBoxColumn;
    }
}