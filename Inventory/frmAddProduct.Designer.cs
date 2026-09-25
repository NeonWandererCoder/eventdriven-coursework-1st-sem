namespace Inventory
{
    partial class frmAddProduct
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(110, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(20, 60);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(45, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(110, 57);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 90);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(48, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(110, 87);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(250, 21);
            this.cbCategory.TabIndex = 4;
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.Location = new System.Drawing.Point(20, 120);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(52, 13);
            this.lblMfgDate.TabIndex = 5;
            this.lblMfgDate.Text = "Mfg. Date";
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.Location = new System.Drawing.Point(110, 117);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(250, 20);
            this.dtPickerMfgDate.TabIndex = 6;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(20, 150);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(52, 13);
            this.lblExpDate.TabIndex = 7;
            this.lblExpDate.Text = "Exp. Date";
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Location = new System.Drawing.Point(110, 147);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(250, 20);
            this.dtPickerExpDate.TabIndex = 8;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(20, 180);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(25, 13);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Qty.";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(110, 177);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(20, 210);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(56, 13);
            this.lblSellPrice.TabIndex = 11;
            this.lblSellPrice.Text = "Sell Price";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(110, 207);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(250, 20);
            this.txtSellPrice.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(390, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(390, 80);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(280, 150);
            this.richTxtDescription.TabIndex = 14;
            this.richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(590, 240);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(90, 30);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.Location = new System.Drawing.Point(20, 280);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.RowTemplate.Height = 24;
            this.gridViewProductList.Size = new System.Drawing.Size(650, 220);
            this.gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblMfgDate);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.gridViewProductList);
            this.Name = "frmAddProduct";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}