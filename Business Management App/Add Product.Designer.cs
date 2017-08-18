namespace Business_Management_App
{
    partial class Add_Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Product_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Product_Sell_Price = new System.Windows.Forms.TextBox();
            this.shopDataBaseDataSet = new Business_Management_App.ShopDataBaseDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Business_Management_App.ShopDataBaseDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Category";
            // 
            // txb_Product_Name
            // 
            this.txb_Product_Name.Location = new System.Drawing.Point(336, 307);
            this.txb_Product_Name.Name = "txb_Product_Name";
            this.txb_Product_Name.Size = new System.Drawing.Size(373, 38);
            this.txb_Product_Name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Sell Price";
            // 
            // txb_Product_Sell_Price
            // 
            this.txb_Product_Sell_Price.Location = new System.Drawing.Point(336, 389);
            this.txb_Product_Sell_Price.Name = "txb_Product_Sell_Price";
            this.txb_Product_Sell_Price.Size = new System.Drawing.Size(373, 38);
            this.txb_Product_Sell_Price.TabIndex = 9;
            // 
            // shopDataBaseDataSet
            // 
            this.shopDataBaseDataSet.DataSetName = "ShopDataBaseDataSet";
            this.shopDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.shopDataBaseDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.CPL_ProductTableAdapter = null;
            this.tableAdapterManager.Customer_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.PPL_ProductTableAdapter = null;
            this.tableAdapterManager.Product_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vendor_Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(336, 222);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(373, 39);
            this.categoryComboBox.TabIndex = 11;
            this.categoryComboBox.ValueMember = "Name";
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.Location = new System.Drawing.Point(61, 508);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(648, 90);
            this.btn_Add_Product.TabIndex = 12;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = true;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 884);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.txb_Product_Sell_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Product_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Add_Product";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.btn_Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Product_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Product_Sell_Price;
        private ShopDataBaseDataSet shopDataBaseDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ShopDataBaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private ShopDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button btn_Add_Product;

    }
}