namespace C968_Inventory_Management
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleInventoryManagementSystems = new Label();
            SearchBoxParts = new TextBox();
            SearchBoxProducts = new TextBox();
            lookupPart = new Button();
            SearchProductButton = new Button();
            PartsLabel = new Label();
            ProdcutsLabel = new Label();
            PartsTable = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            NameOfParts = new DataGridViewTextBoxColumn();
            InStock = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            ProductsTable = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            NameOfProduct = new DataGridViewTextBoxColumn();
            ProductInventory = new DataGridViewTextBoxColumn();
            PriceOfProducts = new DataGridViewTextBoxColumn();
            MinimumProducts = new DataGridViewTextBoxColumn();
            MaximumProducts = new DataGridViewTextBoxColumn();
            AddPartsButton = new Button();
            ModifyPartsButton = new Button();
            DeletePartsButton = new Button();
            AddProductsButton = new Button();
            ModifyProductsButton = new Button();
            DeleteProductsButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // titleInventoryManagementSystems
            // 
            titleInventoryManagementSystems.AutoSize = true;
            titleInventoryManagementSystems.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleInventoryManagementSystems.Location = new Point(9, 9);
            titleInventoryManagementSystems.Name = "titleInventoryManagementSystems";
            titleInventoryManagementSystems.Size = new Size(448, 35);
            titleInventoryManagementSystems.TabIndex = 0;
            titleInventoryManagementSystems.Text = "Inventory Management System";
            // 
            // SearchBoxParts
            // 
            SearchBoxParts.Location = new Point(492, 94);
            SearchBoxParts.Name = "SearchBoxParts";
            SearchBoxParts.Size = new Size(160, 23);
            SearchBoxParts.TabIndex = 1;
            // 
            // SearchBoxProducts
            // 
            SearchBoxProducts.Location = new Point(1143, 97);
            SearchBoxProducts.Name = "SearchBoxProducts";
            SearchBoxProducts.Size = new Size(160, 23);
            SearchBoxProducts.TabIndex = 2;
            // 
            // lookupPart
            // 
            lookupPart.Location = new Point(412, 93);
            lookupPart.Name = "lookupPart";
            lookupPart.Size = new Size(74, 23);
            lookupPart.TabIndex = 3;
            lookupPart.Text = "Search";
            lookupPart.UseVisualStyleBackColor = true;
            lookupPart.Click += SearchPartButton_Click;
            // 
            // SearchProductButton
            // 
            SearchProductButton.Location = new Point(1062, 98);
            SearchProductButton.Name = "SearchProductButton";
            SearchProductButton.Size = new Size(75, 23);
            SearchProductButton.TabIndex = 4;
            SearchProductButton.Text = "Search";
            SearchProductButton.UseVisualStyleBackColor = true;
            SearchProductButton.Click += SearchProductButton_Click;
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartsLabel.Location = new Point(49, 93);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(58, 25);
            PartsLabel.TabIndex = 5;
            PartsLabel.Text = "Parts";
            // 
            // ProdcutsLabel
            // 
            ProdcutsLabel.AutoSize = true;
            ProdcutsLabel.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProdcutsLabel.Location = new Point(700, 93);
            ProdcutsLabel.Name = "ProdcutsLabel";
            ProdcutsLabel.Size = new Size(93, 25);
            ProdcutsLabel.TabIndex = 6;
            ProdcutsLabel.Text = "Products";
            // 
            // PartsTable
            // 
            PartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID, NameOfParts, InStock, Price, Min, Max });
            PartsTable.Location = new Point(49, 127);
            PartsTable.Name = "PartsTable";
            PartsTable.RowHeadersVisible = false;
            PartsTable.Size = new Size(603, 302);
            PartsTable.TabIndex = 7;
            PartsTable.CellContentClick += PartsTable_CellContentClick;
            // 
            // PartID
            // 
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            // 
            // NameOfParts
            // 
            NameOfParts.HeaderText = "Name";
            NameOfParts.Name = "NameOfParts";
            // 
            // InStock
            // 
            InStock.HeaderText = "Inventory";
            InStock.Name = "InStock";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Min
            // 
            Min.HeaderText = "Minimum";
            Min.Name = "Min";
            // 
            // Max
            // 
            Max.HeaderText = "Maximum";
            Max.Name = "Max";
            // 
            // ProductsTable
            // 
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { ProductID, NameOfProduct, ProductInventory, PriceOfProducts, MinimumProducts, MaximumProducts });
            ProductsTable.Location = new Point(700, 127);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersVisible = false;
            ProductsTable.Size = new Size(603, 302);
            ProductsTable.TabIndex = 8;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            // 
            // NameOfProduct
            // 
            NameOfProduct.HeaderText = "Name";
            NameOfProduct.Name = "NameOfProduct";
            // 
            // ProductInventory
            // 
            ProductInventory.HeaderText = "Inventory";
            ProductInventory.Name = "ProductInventory";
            // 
            // PriceOfProducts
            // 
            PriceOfProducts.HeaderText = "Price";
            PriceOfProducts.Name = "PriceOfProducts";
            // 
            // MinimumProducts
            // 
            MinimumProducts.HeaderText = "Minimum";
            MinimumProducts.Name = "MinimumProducts";
            // 
            // MaximumProducts
            // 
            MaximumProducts.HeaderText = "Maximum";
            MaximumProducts.Name = "MaximumProducts";
            // 
            // AddPartsButton
            // 
            AddPartsButton.Location = new Point(355, 450);
            AddPartsButton.Name = "AddPartsButton";
            AddPartsButton.Size = new Size(75, 23);
            AddPartsButton.TabIndex = 9;
            AddPartsButton.Text = "Add";
            AddPartsButton.UseVisualStyleBackColor = true;
            AddPartsButton.Click += AddPartsButton_Click;
            // 
            // ModifyPartsButton
            // 
            ModifyPartsButton.Location = new Point(468, 450);
            ModifyPartsButton.Name = "ModifyPartsButton";
            ModifyPartsButton.Size = new Size(75, 23);
            ModifyPartsButton.TabIndex = 10;
            ModifyPartsButton.Text = "Modify";
            ModifyPartsButton.UseVisualStyleBackColor = true;
            ModifyPartsButton.Click += ModifyPartsButton_Click;
            // 
            // DeletePartsButton
            // 
            DeletePartsButton.Location = new Point(577, 450);
            DeletePartsButton.Name = "DeletePartsButton";
            DeletePartsButton.Size = new Size(75, 23);
            DeletePartsButton.TabIndex = 11;
            DeletePartsButton.Text = "Delete";
            DeletePartsButton.UseVisualStyleBackColor = true;
            // 
            // AddProductsButton
            // 
            AddProductsButton.Location = new Point(1014, 450);
            AddProductsButton.Name = "AddProductsButton";
            AddProductsButton.Size = new Size(75, 23);
            AddProductsButton.TabIndex = 12;
            AddProductsButton.Text = "Add";
            AddProductsButton.UseVisualStyleBackColor = true;
            AddProductsButton.Click += AddProductsButton_Click;
            // 
            // ModifyProductsButton
            // 
            ModifyProductsButton.Location = new Point(1120, 450);
            ModifyProductsButton.Name = "ModifyProductsButton";
            ModifyProductsButton.Size = new Size(75, 23);
            ModifyProductsButton.TabIndex = 13;
            ModifyProductsButton.Text = "Modify";
            ModifyProductsButton.UseVisualStyleBackColor = true;
            ModifyProductsButton.Click += ModifyProductsButton_Click;
            // 
            // DeleteProductsButton
            // 
            DeleteProductsButton.Location = new Point(1228, 450);
            DeleteProductsButton.Name = "DeleteProductsButton";
            DeleteProductsButton.Size = new Size(75, 23);
            DeleteProductsButton.TabIndex = 14;
            DeleteProductsButton.Text = "Delete";
            DeleteProductsButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1201, 498);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(102, 43);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 563);
            Controls.Add(ExitButton);
            Controls.Add(DeleteProductsButton);
            Controls.Add(ModifyProductsButton);
            Controls.Add(AddProductsButton);
            Controls.Add(DeletePartsButton);
            Controls.Add(ModifyPartsButton);
            Controls.Add(AddPartsButton);
            Controls.Add(ProductsTable);
            Controls.Add(PartsTable);
            Controls.Add(ProdcutsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(SearchProductButton);
            Controls.Add(lookupPart);
            Controls.Add(SearchBoxProducts);
            Controls.Add(SearchBoxParts);
            Controls.Add(titleInventoryManagementSystems);
            Name = "MainForm";
            Text = "Inventory Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PartsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleInventoryManagementSystems;
        private TextBox SearchBoxParts;
        private TextBox SearchBoxProducts;
        private Button lookupPart;
        private Button SearchProductButton;
        private Label PartsLabel;
        private Label ProdcutsLabel;
        private DataGridView PartsTable;
        private DataGridView ProductsTable;
        private Button AddPartsButton;
        private Button ModifyPartsButton;
        private Button DeletePartsButton;
        private Button AddProductsButton;
        private Button ModifyProductsButton;
        private Button DeleteProductsButton;
        private Button ExitButton;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn NameOfProduct;
        private DataGridViewTextBoxColumn ProductInventory;
        private DataGridViewTextBoxColumn PriceOfProducts;
        private DataGridViewTextBoxColumn MinimumProducts;
        private DataGridViewTextBoxColumn MaximumProducts;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn NameOfParts;
        private DataGridViewTextBoxColumn InStock;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
    }
}
