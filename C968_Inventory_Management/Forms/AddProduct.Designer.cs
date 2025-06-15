namespace C968_Inventory_Management
{
    partial class AddProduct
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
            dvgAllCandidateParts = new DataGridView();
            lblCandidateParts = new Label();
            btnSearchAllCandidateParts = new Button();
            txtSearchAllCandidateParts = new TextBox();
            dvgPartsAssociatedWithProduct = new DataGridView();
            lblPartsAssociatedWithProduct = new Label();
            txtMaxProduct = new Label();
            txtMinProduct = new Label();
            txtPriceOrCostProduct = new Label();
            label3 = new Label();
            label2 = new Label();
            txtProductMax = new TextBox();
            txtProductMin = new TextBox();
            txtProductInventory = new TextBox();
            txtProductPriceOrCost = new TextBox();
            txtProductID = new TextBox();
            lblAddProduct = new Label();
            btnAddCandidatePart = new Button();
            btnSavePartAssociatedWithProduct = new Button();
            btnDeletePartAssociatedWithProduct = new Button();
            btnCancelAddProduct = new Button();
            txtProductName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgPartsAssociatedWithProduct).BeginInit();
            SuspendLayout();
            // 
            // dvgAllCandidateParts
            // 
            dvgAllCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAllCandidateParts.Location = new Point(548, 68);
            dvgAllCandidateParts.Name = "dvgAllCandidateParts";
            dvgAllCandidateParts.RowHeadersVisible = false;
            dvgAllCandidateParts.Size = new Size(603, 247);
            dvgAllCandidateParts.TabIndex = 11;
            dvgAllCandidateParts.DataBindingComplete += dvgAllCandidateParts_DataBindingComplete;
            // 
            // lblCandidateParts
            // 
            lblCandidateParts.AutoSize = true;
            lblCandidateParts.Font = new Font("Gadugi", 13.75F);
            lblCandidateParts.Location = new Point(548, 32);
            lblCandidateParts.Name = "lblCandidateParts";
            lblCandidateParts.Size = new Size(170, 22);
            lblCandidateParts.TabIndex = 10;
            lblCandidateParts.Text = "All Candidate Parts";
            // 
            // btnSearchAllCandidateParts
            // 
            btnSearchAllCandidateParts.Location = new Point(911, 32);
            btnSearchAllCandidateParts.Name = "btnSearchAllCandidateParts";
            btnSearchAllCandidateParts.Size = new Size(74, 25);
            btnSearchAllCandidateParts.TabIndex = 9;
            btnSearchAllCandidateParts.Text = "Search";
            btnSearchAllCandidateParts.UseVisualStyleBackColor = true;
            // 
            // txtSearchAllCandidateParts
            // 
            txtSearchAllCandidateParts.Location = new Point(991, 33);
            txtSearchAllCandidateParts.Name = "txtSearchAllCandidateParts";
            txtSearchAllCandidateParts.Size = new Size(160, 23);
            txtSearchAllCandidateParts.TabIndex = 8;
            // 
            // dvgPartsAssociatedWithProduct
            // 
            dvgPartsAssociatedWithProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPartsAssociatedWithProduct.Location = new Point(548, 354);
            dvgPartsAssociatedWithProduct.Name = "dvgPartsAssociatedWithProduct";
            dvgPartsAssociatedWithProduct.RowHeadersVisible = false;
            dvgPartsAssociatedWithProduct.Size = new Size(603, 230);
            dvgPartsAssociatedWithProduct.TabIndex = 15;
            // 
            // lblPartsAssociatedWithProduct
            // 
            lblPartsAssociatedWithProduct.AutoSize = true;
            lblPartsAssociatedWithProduct.Font = new Font("Gadugi", 13.75F);
            lblPartsAssociatedWithProduct.Location = new Point(548, 329);
            lblPartsAssociatedWithProduct.Name = "lblPartsAssociatedWithProduct";
            lblPartsAssociatedWithProduct.Size = new Size(263, 22);
            lblPartsAssociatedWithProduct.TabIndex = 14;
            lblPartsAssociatedWithProduct.Text = "Parts Associated With Product";
            // 
            // txtMaxProduct
            // 
            txtMaxProduct.AutoSize = true;
            txtMaxProduct.Font = new Font("Gadugi", 9.75F);
            txtMaxProduct.Location = new Point(251, 402);
            txtMaxProduct.Name = "txtMaxProduct";
            txtMaxProduct.Size = new Size(32, 16);
            txtMaxProduct.TabIndex = 29;
            txtMaxProduct.Text = "Max";
            // 
            // txtMinProduct
            // 
            txtMinProduct.AutoSize = true;
            txtMinProduct.Font = new Font("Gadugi", 9.75F);
            txtMinProduct.Location = new Point(96, 402);
            txtMinProduct.Name = "txtMinProduct";
            txtMinProduct.Size = new Size(29, 16);
            txtMinProduct.TabIndex = 28;
            txtMinProduct.Text = "Min";
            // 
            // txtPriceOrCostProduct
            // 
            txtPriceOrCostProduct.AutoSize = true;
            txtPriceOrCostProduct.Font = new Font("Gadugi", 9.75F);
            txtPriceOrCostProduct.Location = new Point(96, 350);
            txtPriceOrCostProduct.Name = "txtPriceOrCostProduct";
            txtPriceOrCostProduct.Size = new Size(66, 16);
            txtPriceOrCostProduct.TabIndex = 27;
            txtPriceOrCostProduct.Text = "Price/Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F);
            label3.Location = new Point(96, 254);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 25;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9.75F);
            label2.Location = new Point(96, 209);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 24;
            label2.Text = "ID";
            // 
            // txtProductMax
            // 
            txtProductMax.BackColor = Color.Salmon;
            txtProductMax.Location = new Point(289, 399);
            txtProductMax.Name = "txtProductMax";
            txtProductMax.Size = new Size(102, 23);
            txtProductMax.TabIndex = 23;
            txtProductMax.TextChanged += txtProductMax_TextChanged;
            // 
            // txtProductMin
            // 
            txtProductMin.BackColor = Color.Salmon;
            txtProductMin.Location = new Point(131, 399);
            txtProductMin.Name = "txtProductMin";
            txtProductMin.Size = new Size(102, 23);
            txtProductMin.TabIndex = 22;
            txtProductMin.TextChanged += txtProductMin_TextChanged;
            // 
            // txtProductInventory
            // 
            txtProductInventory.BackColor = Color.Salmon;
            txtProductInventory.Location = new Point(179, 292);
            txtProductInventory.Name = "txtProductInventory";
            txtProductInventory.Size = new Size(155, 23);
            txtProductInventory.TabIndex = 21;
            txtProductInventory.TextChanged += txtProductInventory_TextChanged;
            // 
            // txtProductPriceOrCost
            // 
            txtProductPriceOrCost.BackColor = Color.Salmon;
            txtProductPriceOrCost.Location = new Point(179, 343);
            txtProductPriceOrCost.Name = "txtProductPriceOrCost";
            txtProductPriceOrCost.Size = new Size(155, 23);
            txtProductPriceOrCost.TabIndex = 20;
            txtProductPriceOrCost.TextChanged += txtProductPriceOrCost_TextChanged;
            // 
            // txtProductID
            // 
            txtProductID.BackColor = SystemColors.InactiveCaption;
            txtProductID.Location = new Point(179, 207);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(155, 23);
            txtProductID.TabIndex = 18;
            // 
            // lblAddProduct
            // 
            lblAddProduct.AutoSize = true;
            lblAddProduct.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddProduct.Location = new Point(27, 29);
            lblAddProduct.Name = "lblAddProduct";
            lblAddProduct.Size = new Size(188, 35);
            lblAddProduct.TabIndex = 30;
            lblAddProduct.Text = "Add Product";
            // 
            // btnAddCandidatePart
            // 
            btnAddCandidatePart.Font = new Font("Gadugi", 9F);
            btnAddCandidatePart.Location = new Point(455, 159);
            btnAddCandidatePart.Name = "btnAddCandidatePart";
            btnAddCandidatePart.Size = new Size(61, 39);
            btnAddCandidatePart.TabIndex = 31;
            btnAddCandidatePart.Text = "Add";
            btnAddCandidatePart.UseVisualStyleBackColor = true;
            btnAddCandidatePart.Click += btnAddCandidatePart_Click;
            // 
            // btnSavePartAssociatedWithProduct
            // 
            btnSavePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnSavePartAssociatedWithProduct.Location = new Point(455, 427);
            btnSavePartAssociatedWithProduct.Name = "btnSavePartAssociatedWithProduct";
            btnSavePartAssociatedWithProduct.Size = new Size(61, 39);
            btnSavePartAssociatedWithProduct.TabIndex = 32;
            btnSavePartAssociatedWithProduct.Text = "Save";
            btnSavePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnSavePartAssociatedWithProduct.Click += btnSavePartAssociatedWithProduct_Click;
            // 
            // btnDeletePartAssociatedWithProduct
            // 
            btnDeletePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnDeletePartAssociatedWithProduct.Location = new Point(455, 486);
            btnDeletePartAssociatedWithProduct.Name = "btnDeletePartAssociatedWithProduct";
            btnDeletePartAssociatedWithProduct.Size = new Size(61, 39);
            btnDeletePartAssociatedWithProduct.TabIndex = 33;
            btnDeletePartAssociatedWithProduct.Text = "Delete";
            btnDeletePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnDeletePartAssociatedWithProduct.Click += btnDeletePartAssociatedWithProduct_Click;
            // 
            // btnCancelAddProduct
            // 
            btnCancelAddProduct.Font = new Font("Gadugi", 9F);
            btnCancelAddProduct.Location = new Point(1090, 617);
            btnCancelAddProduct.Name = "btnCancelAddProduct";
            btnCancelAddProduct.Size = new Size(61, 39);
            btnCancelAddProduct.TabIndex = 34;
            btnCancelAddProduct.Text = "Cancel";
            btnCancelAddProduct.UseVisualStyleBackColor = true;
            btnCancelAddProduct.Click += btnCancelAddProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.Salmon;
            txtProductName.Location = new Point(179, 254);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(155, 23);
            txtProductName.TabIndex = 35;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9.75F);
            label1.Location = new Point(96, 299);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 36;
            label1.Text = "Inventory";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 682);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(btnCancelAddProduct);
            Controls.Add(btnDeletePartAssociatedWithProduct);
            Controls.Add(btnSavePartAssociatedWithProduct);
            Controls.Add(btnAddCandidatePart);
            Controls.Add(lblAddProduct);
            Controls.Add(txtMaxProduct);
            Controls.Add(txtMinProduct);
            Controls.Add(txtPriceOrCostProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductMax);
            Controls.Add(txtProductMin);
            Controls.Add(txtProductInventory);
            Controls.Add(txtProductPriceOrCost);
            Controls.Add(txtProductID);
            Controls.Add(dvgPartsAssociatedWithProduct);
            Controls.Add(lblPartsAssociatedWithProduct);
            Controls.Add(dvgAllCandidateParts);
            Controls.Add(lblCandidateParts);
            Controls.Add(btnSearchAllCandidateParts);
            Controls.Add(txtSearchAllCandidateParts);
            Font = new Font("Gadugi", 9F);
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgPartsAssociatedWithProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgAllCandidateParts;
        private Label lblCandidateParts;
        private Button btnSearchAllCandidateParts;
        private TextBox txtSearchAllCandidateParts;
        private DataGridView dvgPartsAssociatedWithProduct;
        private Label lblPartsAssociatedWithProduct;
        private Label txtMaxProduct;
        private Label txtMinProduct;
        private Label txtPriceOrCostProduct;
        private Label label3;
        private Label label2;
        private TextBox txtProductMax;
        private TextBox txtProductMin;
        private TextBox txtProductInventory;
        private TextBox txtProductPriceOrCost;
        private TextBox txtProductID;
        private Label lblAddProduct;
        private Button btnAddCandidatePart;
        private Button btnSavePartAssociatedWithProduct;
        private Button btnDeletePartAssociatedWithProduct;
        private Button btnCancelAddProduct;
        private TextBox txtProductName;
        private Label label1;
    }
}