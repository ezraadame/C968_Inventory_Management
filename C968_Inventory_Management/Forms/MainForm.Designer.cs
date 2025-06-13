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
            titleIMS = new Label();
            txtSearchParts = new TextBox();
            txtSearchProducts = new TextBox();
            btnSearchParts = new Button();
            btnSearchProducts = new Button();
            lblParts = new Label();
            lblProducts = new Label();
            dvgParts = new DataGridView();
            dvgProducts = new DataGridView();
            btnAddParts = new Button();
            btnModifyParts = new Button();
            btnDeleteParts = new Button();
            btnAddProducts = new Button();
            btnModifyProducts = new Button();
            btnDeleteProducts = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).BeginInit();
            SuspendLayout();
            // 
            // titleIMS
            // 
            titleIMS.AutoSize = true;
            titleIMS.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleIMS.Location = new Point(9, 9);
            titleIMS.Name = "titleIMS";
            titleIMS.Size = new Size(448, 35);
            titleIMS.TabIndex = 0;
            titleIMS.Text = "Inventory Management System";
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(492, 94);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(160, 23);
            txtSearchParts.TabIndex = 1;
            txtSearchParts.TextChanged += SearchBoxParts_TextChanged;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Location = new Point(1143, 97);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.Size = new Size(160, 23);
            txtSearchProducts.TabIndex = 2;
            // 
            // btnSearchParts
            // 
            btnSearchParts.Location = new Point(412, 93);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(74, 23);
            btnSearchParts.TabIndex = 3;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += SearchPartButton_Click;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Location = new Point(1062, 98);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(75, 23);
            btnSearchProducts.TabIndex = 4;
            btnSearchProducts.Text = "Search";
            btnSearchProducts.UseVisualStyleBackColor = true;
            btnSearchProducts.Click += SearchProductButton_Click;
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParts.Location = new Point(49, 93);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(58, 25);
            lblParts.TabIndex = 5;
            lblParts.Text = "Parts";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducts.Location = new Point(700, 93);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(93, 25);
            lblProducts.TabIndex = 6;
            lblProducts.Text = "Products";
            // 
            // dvgParts
            // 
            dvgParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgParts.Location = new Point(49, 127);
            dvgParts.Name = "dvgParts";
            dvgParts.RowHeadersVisible = false;
            dvgParts.Size = new Size(603, 302);
            dvgParts.TabIndex = 7;
            dvgParts.CellContentClick += PartsTable_CellContentClick;
            // 
            // dvgProducts
            // 
            dvgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducts.Location = new Point(700, 127);
            dvgProducts.Name = "dvgProducts";
            dvgProducts.RowHeadersVisible = false;
            dvgProducts.Size = new Size(603, 302);
            dvgProducts.TabIndex = 8;
            dvgProducts.CellContentClick += ProductsTable_CellContentClick;
            // 
            // btnAddParts
            // 
            btnAddParts.Location = new Point(355, 450);
            btnAddParts.Name = "btnAddParts";
            btnAddParts.Size = new Size(75, 23);
            btnAddParts.TabIndex = 9;
            btnAddParts.Text = "Add";
            btnAddParts.UseVisualStyleBackColor = true;
            btnAddParts.Click += AddPartsButton_Click;
            // 
            // btnModifyParts
            // 
            btnModifyParts.Location = new Point(468, 450);
            btnModifyParts.Name = "btnModifyParts";
            btnModifyParts.Size = new Size(75, 23);
            btnModifyParts.TabIndex = 10;
            btnModifyParts.Text = "Modify";
            btnModifyParts.UseVisualStyleBackColor = true;
            btnModifyParts.Click += ModifyPartsButton_Click;
            // 
            // btnDeleteParts
            // 
            btnDeleteParts.Location = new Point(577, 450);
            btnDeleteParts.Name = "btnDeleteParts";
            btnDeleteParts.Size = new Size(75, 23);
            btnDeleteParts.TabIndex = 11;
            btnDeleteParts.Text = "Delete";
            btnDeleteParts.UseVisualStyleBackColor = true;
            btnDeleteParts.Click += DeletePartsButton_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.Location = new Point(1014, 450);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(75, 23);
            btnAddProducts.TabIndex = 12;
            btnAddProducts.Text = "Add";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += AddProductsButton_Click;
            // 
            // btnModifyProducts
            // 
            btnModifyProducts.Location = new Point(1120, 450);
            btnModifyProducts.Name = "btnModifyProducts";
            btnModifyProducts.Size = new Size(75, 23);
            btnModifyProducts.TabIndex = 13;
            btnModifyProducts.Text = "Modify";
            btnModifyProducts.UseVisualStyleBackColor = true;
            btnModifyProducts.Click += ModifyProductsButton_Click;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Location = new Point(1228, 450);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(75, 23);
            btnDeleteProducts.TabIndex = 14;
            btnDeleteProducts.Text = "Delete";
            btnDeleteProducts.UseVisualStyleBackColor = true;
            btnDeleteProducts.Click += DeleteProductsButton_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1201, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 43);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 563);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteProducts);
            Controls.Add(btnModifyProducts);
            Controls.Add(btnAddProducts);
            Controls.Add(btnDeleteParts);
            Controls.Add(btnModifyParts);
            Controls.Add(btnAddParts);
            Controls.Add(dvgProducts);
            Controls.Add(dvgParts);
            Controls.Add(lblProducts);
            Controls.Add(lblParts);
            Controls.Add(btnSearchProducts);
            Controls.Add(btnSearchParts);
            Controls.Add(txtSearchProducts);
            Controls.Add(txtSearchParts);
            Controls.Add(titleIMS);
            Name = "MainForm";
            Text = "Inventory Management System";
            Load += MainFormLoad;
            ((System.ComponentModel.ISupportInitialize)dvgParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleIMS;
        private TextBox txtSearchParts;
        private TextBox txtSearchProducts;
        private Button btnSearchParts;
        private Button btnSearchProducts;
        private Label lblParts;
        private Label lblProducts;
        private DataGridView dvgParts;
        private DataGridView dvgProducts;
        private Button btnAddParts;
        private Button btnModifyParts;
        private Button btnDeleteParts;
        private Button btnAddProducts;
        private Button btnModifyProducts;
        private Button btnDeleteProducts;
        private Button btnExit;
    }
}
