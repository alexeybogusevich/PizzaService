namespace PizzaServiceEF
{
    partial class FormPizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPizzaOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePizza = new System.Windows.Forms.TabPage();
            this.dataGridViewPizza = new System.Windows.Forms.DataGridView();
            this.tabPageDrinks = new System.Windows.Forms.TabPage();
            this.tabPageDesserts = new System.Windows.Forms.TabPage();
            this.tabPageSides = new System.Windows.Forms.TabPage();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            this.iTEMSBindingSourcePizza = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPagePizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSourcePizza)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePizza);
            this.tabControl1.Controls.Add(this.tabPageDrinks);
            this.tabControl1.Controls.Add(this.tabPageDesserts);
            this.tabControl1.Controls.Add(this.tabPageSides);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 418);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPagePizza
            // 
            this.tabPagePizza.Controls.Add(this.buttonAdd);
            this.tabPagePizza.Controls.Add(this.dataGridViewPizza);
            this.tabPagePizza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPagePizza.Location = new System.Drawing.Point(4, 25);
            this.tabPagePizza.Name = "tabPagePizza";
            this.tabPagePizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePizza.Size = new System.Drawing.Size(912, 389);
            this.tabPagePizza.TabIndex = 0;
            this.tabPagePizza.Text = "Піца";
            this.tabPagePizza.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPizza
            // 
            this.dataGridViewPizza.AutoGenerateColumns = false;
            this.dataGridViewPizza.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewPizza.DataSource = this.iTEMSBindingSourcePizza;
            this.dataGridViewPizza.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPizza.Name = "dataGridViewPizza";
            this.dataGridViewPizza.ReadOnly = true;
            this.dataGridViewPizza.RowHeadersWidth = 40;
            this.dataGridViewPizza.RowTemplate.Height = 40;
            this.dataGridViewPizza.Size = new System.Drawing.Size(723, 377);
            this.dataGridViewPizza.TabIndex = 0;
            // 
            // tabPageDrinks
            // 
            this.tabPageDrinks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageDrinks.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrinks.Name = "tabPageDrinks";
            this.tabPageDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrinks.Size = new System.Drawing.Size(912, 389);
            this.tabPageDrinks.TabIndex = 1;
            this.tabPageDrinks.Text = "Напої";
            this.tabPageDrinks.UseVisualStyleBackColor = true;
            // 
            // tabPageDesserts
            // 
            this.tabPageDesserts.Location = new System.Drawing.Point(4, 25);
            this.tabPageDesserts.Name = "tabPageDesserts";
            this.tabPageDesserts.Size = new System.Drawing.Size(912, 389);
            this.tabPageDesserts.TabIndex = 2;
            this.tabPageDesserts.Text = "Десерти";
            this.tabPageDesserts.UseVisualStyleBackColor = true;
            // 
            // tabPageSides
            // 
            this.tabPageSides.Location = new System.Drawing.Point(4, 25);
            this.tabPageSides.Name = "tabPageSides";
            this.tabPageSides.Size = new System.Drawing.Size(912, 389);
            this.tabPageSides.TabIndex = 3;
            this.tabPageSides.Text = "Сайди";
            this.tabPageSides.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            this.buttonCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.buttonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCart.ForeColor = System.Drawing.Color.White;
            this.buttonCart.Location = new System.Drawing.Point(523, 23);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(108, 44);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.Text = "Кошик";
            this.buttonCart.UseVisualStyleBackColor = false;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(631, 23);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(104, 44);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Замовити";
            this.buttonOrder.UseVisualStyleBackColor = false;
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(160)))));
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonMain.ForeColor = System.Drawing.Color.White;
            this.buttonMain.Location = new System.Drawing.Point(832, 23);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(100, 44);
            this.buttonMain.TabIndex = 3;
            this.buttonMain.Text = "На головну";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(762, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 44);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати в кошик";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "I_ID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "I_ID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNAMEDataGridViewTextBoxColumn
            // 
            this.iNAMEDataGridViewTextBoxColumn.DataPropertyName = "I_NAME";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.iNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iNAMEDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.iNAMEDataGridViewTextBoxColumn.Name = "iNAMEDataGridViewTextBoxColumn";
            this.iNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // iSIZEDataGridViewTextBoxColumn
            // 
            this.iSIZEDataGridViewTextBoxColumn.DataPropertyName = "I_SIZE";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.iSIZEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iSIZEDataGridViewTextBoxColumn.HeaderText = "Розмір";
            this.iSIZEDataGridViewTextBoxColumn.Name = "iSIZEDataGridViewTextBoxColumn";
            this.iSIZEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSIZEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.iDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "I_DESCRIPTION";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iDESCRIPTIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.Name = "iDESCRIPTIONDataGridViewTextBoxColumn";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDESCRIPTIONDataGridViewTextBoxColumn.Width = 400;
            // 
            // iCATEGORYDataGridViewTextBoxColumn
            // 
            this.iCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "I_CATEGORY";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.iCATEGORYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.iCATEGORYDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.iCATEGORYDataGridViewTextBoxColumn.Name = "iCATEGORYDataGridViewTextBoxColumn";
            this.iCATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCATEGORYDataGridViewTextBoxColumn.Visible = false;
            // 
            // iPRICEDataGridViewTextBoxColumn
            // 
            this.iPRICEDataGridViewTextBoxColumn.DataPropertyName = "I_PRICE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iPRICEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.iPRICEDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.iPRICEDataGridViewTextBoxColumn.Name = "iPRICEDataGridViewTextBoxColumn";
            this.iPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPRICEDataGridViewTextBoxColumn.Width = 80;
            // 
            // iIMAGEDataGridViewTextBoxColumn
            // 
            this.iIMAGEDataGridViewTextBoxColumn.DataPropertyName = "I_IMAGE";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iIMAGEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.iIMAGEDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.iIMAGEDataGridViewTextBoxColumn.Name = "iIMAGEDataGridViewTextBoxColumn";
            this.iIMAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIMAGEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iIMAGEDataGridViewTextBoxColumn.Visible = false;
            this.iIMAGEDataGridViewTextBoxColumn.Width = 80;
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
            // iTEMSBindingSourcePizza
            // 
            this.iTEMSBindingSourcePizza.DataSource = typeof(PizzaServiceDataEF.ITEMS);
            // 
            // FormPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPizzaOrder";
            this.Text = "Піца - замовити з доставкою | Domino\'s Pizza";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePizza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSourcePizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePizza;
        private System.Windows.Forms.TabPage tabPageDrinks;
        private System.Windows.Forms.TabPage tabPageDesserts;
        private System.Windows.Forms.TabPage tabPageSides;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPizza;
        private System.Windows.Forms.BindingSource iTEMSBindingSourcePizza;
        private System.Windows.Forms.Button buttonAdd;
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
    }
}