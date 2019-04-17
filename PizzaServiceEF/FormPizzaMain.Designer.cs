namespace PizzaServiceEF
{
    partial class FormPizzaService
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPizzaService));
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonRestaurants = new System.Windows.Forms.Button();
            this.buttonComment = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активніЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.історіяЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(-2, 155);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(264, 56);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "Зробити замовлення";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonRestaurants
            // 
            this.buttonRestaurants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRestaurants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurants.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRestaurants.ForeColor = System.Drawing.Color.White;
            this.buttonRestaurants.Location = new System.Drawing.Point(-1, 248);
            this.buttonRestaurants.Name = "buttonRestaurants";
            this.buttonRestaurants.Size = new System.Drawing.Size(263, 56);
            this.buttonRestaurants.TabIndex = 1;
            this.buttonRestaurants.Text = "Ресторани";
            this.buttonRestaurants.UseVisualStyleBackColor = false;
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonComment.ForeColor = System.Drawing.Color.White;
            this.buttonComment.Location = new System.Drawing.Point(-1, 337);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(263, 56);
            this.buttonComment.TabIndex = 2;
            this.buttonComment.Text = "Залишити відгук";
            this.buttonComment.UseVisualStyleBackColor = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(683, 337);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(263, 56);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Увійти";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(38)))), ((int)(((byte)(187)))));
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(-2, 337);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(263, 56);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "Керування";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(683, 337);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(263, 56);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Вийти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStripMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripMain.Size = new System.Drawing.Size(944, 24);
            this.menuStripMain.TabIndex = 7;
            this.menuStripMain.Text = "menuStrip";
            this.menuStripMain.Visible = false;
            this.menuStripMain.MenuDeactivate += new System.EventHandler(this.menuStripMain_MenuDeactivate);
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.активніЗамовленняToolStripMenuItem,
            this.історіяЗамовленьToolStripMenuItem});
            this.userNameToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userNameToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.userNameToolStripMenuItem.Text = "Користувач";
            this.userNameToolStripMenuItem.Click += new System.EventHandler(this.userNameToolStripMenuItem_Click);
            // 
            // активніЗамовленняToolStripMenuItem
            // 
            this.активніЗамовленняToolStripMenuItem.Name = "активніЗамовленняToolStripMenuItem";
            this.активніЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.активніЗамовленняToolStripMenuItem.Text = "Активні замовлення  ";
            this.активніЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.активніЗамовленняToolStripMenuItem_Click);
            // 
            // історіяЗамовленьToolStripMenuItem
            // 
            this.історіяЗамовленьToolStripMenuItem.Name = "історіяЗамовленьToolStripMenuItem";
            this.історіяЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.історіяЗамовленьToolStripMenuItem.Text = "Історія замовлень";
            this.історіяЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.історіяЗамовленьToolStripMenuItem_Click);
            // 
            // FormPizzaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonRestaurants);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormPizzaService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domino\'s Pizza";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonRestaurants;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активніЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem історіяЗамовленьToolStripMenuItem;
    }
}

