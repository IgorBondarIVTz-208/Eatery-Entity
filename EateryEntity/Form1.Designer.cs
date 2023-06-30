namespace EateryEntity
{
    partial class Root
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddProduct = new System.Windows.Forms.Button();
            this.productDelete = new System.Windows.Forms.Button();
            this.productsUpdate = new System.Windows.Forms.Button();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dishesView = new System.Windows.Forms.DataGridView();
            this.AddDish = new System.Windows.Forms.Button();
            this.RemoveDishes = new System.Windows.Forms.Button();
            this.UpdateDishBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PurchasesView = new System.Windows.Forms.DataGridView();
            this.AddPurchases = new System.Windows.Forms.Button();
            this.RemovePurchases = new System.Windows.Forms.Button();
            this.UpdatePurchases = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasesView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddProduct);
            this.tabPage1.Controls.Add(this.productDelete);
            this.tabPage1.Controls.Add(this.productsUpdate);
            this.tabPage1.Controls.Add(this.ProductsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(168, 3);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 3;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // productDelete
            // 
            this.productDelete.Location = new System.Drawing.Point(87, 3);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(75, 23);
            this.productDelete.TabIndex = 2;
            this.productDelete.Text = "Remove";
            this.productDelete.UseVisualStyleBackColor = true;
            this.productDelete.Click += new System.EventHandler(this.productDelete_Click);
            // 
            // productsUpdate
            // 
            this.productsUpdate.Location = new System.Drawing.Point(6, 3);
            this.productsUpdate.Name = "productsUpdate";
            this.productsUpdate.Size = new System.Drawing.Size(75, 23);
            this.productsUpdate.TabIndex = 1;
            this.productsUpdate.Text = "Update";
            this.productsUpdate.UseVisualStyleBackColor = true;
            this.productsUpdate.Click += new System.EventHandler(this.productsUpdateClick);
            // 
            // ProductsView
            // 
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Location = new System.Drawing.Point(6, 29);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsView.Size = new System.Drawing.Size(774, 386);
            this.ProductsView.TabIndex = 0;
            this.ProductsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dishesView);
            this.tabPage2.Controls.Add(this.AddDish);
            this.tabPage2.Controls.Add(this.RemoveDishes);
            this.tabPage2.Controls.Add(this.UpdateDishBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dishes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dishesView
            // 
            this.dishesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesView.Location = new System.Drawing.Point(6, 35);
            this.dishesView.Name = "dishesView";
            this.dishesView.Size = new System.Drawing.Size(778, 380);
            this.dishesView.TabIndex = 3;
            // 
            // AddDish
            // 
            this.AddDish.Location = new System.Drawing.Point(168, 6);
            this.AddDish.Name = "AddDish";
            this.AddDish.Size = new System.Drawing.Size(75, 23);
            this.AddDish.TabIndex = 2;
            this.AddDish.Text = "Add";
            this.AddDish.UseVisualStyleBackColor = true;
            this.AddDish.Click += new System.EventHandler(this.AddDish_Click);
            // 
            // RemoveDishes
            // 
            this.RemoveDishes.Location = new System.Drawing.Point(87, 6);
            this.RemoveDishes.Name = "RemoveDishes";
            this.RemoveDishes.Size = new System.Drawing.Size(75, 23);
            this.RemoveDishes.TabIndex = 1;
            this.RemoveDishes.Text = "Remove";
            this.RemoveDishes.UseVisualStyleBackColor = true;
            this.RemoveDishes.Click += new System.EventHandler(this.RemoveDishes_Click);
            // 
            // UpdateDishBtn
            // 
            this.UpdateDishBtn.Location = new System.Drawing.Point(6, 6);
            this.UpdateDishBtn.Name = "UpdateDishBtn";
            this.UpdateDishBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateDishBtn.TabIndex = 0;
            this.UpdateDishBtn.Text = "Update";
            this.UpdateDishBtn.UseVisualStyleBackColor = true;
            this.UpdateDishBtn.Click += new System.EventHandler(this.UpdateDishBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PurchasesView);
            this.tabPage3.Controls.Add(this.AddPurchases);
            this.tabPage3.Controls.Add(this.RemovePurchases);
            this.tabPage3.Controls.Add(this.UpdatePurchases);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Purchases";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PurchasesView
            // 
            this.PurchasesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasesView.Location = new System.Drawing.Point(7, 36);
            this.PurchasesView.Name = "PurchasesView";
            this.PurchasesView.Size = new System.Drawing.Size(777, 379);
            this.PurchasesView.TabIndex = 3;
            // 
            // AddPurchases
            // 
            this.AddPurchases.Location = new System.Drawing.Point(168, 6);
            this.AddPurchases.Name = "AddPurchases";
            this.AddPurchases.Size = new System.Drawing.Size(75, 23);
            this.AddPurchases.TabIndex = 2;
            this.AddPurchases.Text = "Add";
            this.AddPurchases.UseVisualStyleBackColor = true;
            this.AddPurchases.Click += new System.EventHandler(this.AddPurchases_Click);
            // 
            // RemovePurchases
            // 
            this.RemovePurchases.Location = new System.Drawing.Point(87, 6);
            this.RemovePurchases.Name = "RemovePurchases";
            this.RemovePurchases.Size = new System.Drawing.Size(75, 23);
            this.RemovePurchases.TabIndex = 1;
            this.RemovePurchases.Text = "Remove";
            this.RemovePurchases.UseVisualStyleBackColor = true;
            this.RemovePurchases.Click += new System.EventHandler(this.RemovePurchases_Click);
            // 
            // UpdatePurchases
            // 
            this.UpdatePurchases.Location = new System.Drawing.Point(6, 6);
            this.UpdatePurchases.Name = "UpdatePurchases";
            this.UpdatePurchases.Size = new System.Drawing.Size(75, 23);
            this.UpdatePurchases.TabIndex = 0;
            this.UpdatePurchases.Text = "Update";
            this.UpdatePurchases.UseVisualStyleBackColor = true;
            this.UpdatePurchases.Click += new System.EventHandler(this.UpdatePurchases_Click);
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Root";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Root_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.Button productsUpdate;
        private System.Windows.Forms.Button productDelete;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button UpdatePurchases;
        private System.Windows.Forms.Button RemovePurchases;
        private System.Windows.Forms.Button AddPurchases;
        private System.Windows.Forms.DataGridView PurchasesView;
        private System.Windows.Forms.Button RemoveDishes;
        private System.Windows.Forms.Button UpdateDishBtn;
        private System.Windows.Forms.DataGridView dishesView;
        private System.Windows.Forms.Button AddDish;
    }
}

