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
            PartsLabel = new Label();
            btnSearchAllCandidateParts = new Button();
            txtSearchAllCandidateParts = new TextBox();
            dvgPartsAssociatedWithProduct = new DataGridView();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            lblAddProduct = new Label();
            btnAddCandidatePart = new Button();
            btnSavePartAssociatedWithProduct = new Button();
            btnDeletePartAssociatedWithProduct = new Button();
            CancelAddProduct = new Button();
            clmAllCandidatePartsPartID = new DataGridViewTextBoxColumn();
            clmAllCandidatePartsName = new DataGridViewTextBoxColumn();
            clmAllCandidatePartsInventory = new DataGridViewTextBoxColumn();
            clmAllCandidatePartsPrice = new DataGridViewTextBoxColumn();
            clmAllCandidatePartsMin = new DataGridViewTextBoxColumn();
            clmAllCandidatePartsMax = new DataGridViewTextBoxColumn();
            clmPartsAssociatedPartID = new DataGridViewTextBoxColumn();
            clmPartsAssociatedName = new DataGridViewTextBoxColumn();
            clmPartsAssociatedInventory = new DataGridViewTextBoxColumn();
            clmPartsAssociatedPrice = new DataGridViewTextBoxColumn();
            clmPartsAssociatedMin = new DataGridViewTextBoxColumn();
            clmPartsAssociatedMax = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgPartsAssociatedWithProduct).BeginInit();
            SuspendLayout();
            // 
            // dvgAllCandidateParts
            // 
            dvgAllCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAllCandidateParts.Columns.AddRange(new DataGridViewColumn[] { clmAllCandidatePartsPartID, clmAllCandidatePartsName, clmAllCandidatePartsInventory, clmAllCandidatePartsPrice, clmAllCandidatePartsMin, clmAllCandidatePartsMax });
            dvgAllCandidateParts.Location = new Point(548, 68);
            dvgAllCandidateParts.Name = "dvgAllCandidateParts";
            dvgAllCandidateParts.RowHeadersVisible = false;
            dvgAllCandidateParts.Size = new Size(603, 220);
            dvgAllCandidateParts.TabIndex = 11;
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Gadugi", 13.75F);
            PartsLabel.Location = new Point(548, 32);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(170, 22);
            PartsLabel.TabIndex = 10;
            PartsLabel.Text = "All Candidate Parts";
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
            dvgPartsAssociatedWithProduct.Columns.AddRange(new DataGridViewColumn[] { clmPartsAssociatedPartID, clmPartsAssociatedName, clmPartsAssociatedInventory, clmPartsAssociatedPrice, clmPartsAssociatedMin, clmPartsAssociatedMax });
            dvgPartsAssociatedWithProduct.Location = new Point(548, 398);
            dvgPartsAssociatedWithProduct.Name = "dvgPartsAssociatedWithProduct";
            dvgPartsAssociatedWithProduct.RowHeadersVisible = false;
            dvgPartsAssociatedWithProduct.Size = new Size(603, 230);
            dvgPartsAssociatedWithProduct.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 13.75F);
            label1.Location = new Point(548, 362);
            label1.Name = "label1";
            label1.Size = new Size(263, 22);
            label1.TabIndex = 14;
            label1.Text = "Parts Associated With Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9.75F);
            label7.Location = new Point(228, 433);
            label7.Name = "label7";
            label7.Size = new Size(32, 16);
            label7.TabIndex = 29;
            label7.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9.75F);
            label6.Location = new Point(73, 433);
            label6.Name = "label6";
            label6.Size = new Size(29, 16);
            label6.TabIndex = 28;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9.75F);
            label5.Location = new Point(73, 381);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 27;
            label5.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9.75F);
            label4.Location = new Point(73, 330);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 26;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F);
            label3.Location = new Point(73, 285);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 25;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9.75F);
            label2.Location = new Point(73, 240);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 24;
            label2.Text = "ID";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(266, 430);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(102, 23);
            textBox6.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(108, 430);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(102, 23);
            textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 327);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 374);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(156, 238);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 23);
            textBox7.TabIndex = 18;
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
            btnAddCandidatePart.Click += AddCandidateParts_Click;
            // 
            // btnSavePartAssociatedWithProduct
            // 
            btnSavePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnSavePartAssociatedWithProduct.Location = new Point(455, 471);
            btnSavePartAssociatedWithProduct.Name = "btnSavePartAssociatedWithProduct";
            btnSavePartAssociatedWithProduct.Size = new Size(61, 39);
            btnSavePartAssociatedWithProduct.TabIndex = 32;
            btnSavePartAssociatedWithProduct.Text = "Save";
            btnSavePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnSavePartAssociatedWithProduct.Click += SavePartsAssociated_Click;
            // 
            // btnDeletePartAssociatedWithProduct
            // 
            btnDeletePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnDeletePartAssociatedWithProduct.Location = new Point(455, 530);
            btnDeletePartAssociatedWithProduct.Name = "btnDeletePartAssociatedWithProduct";
            btnDeletePartAssociatedWithProduct.Size = new Size(61, 39);
            btnDeletePartAssociatedWithProduct.TabIndex = 33;
            btnDeletePartAssociatedWithProduct.Text = "Delete";
            btnDeletePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnDeletePartAssociatedWithProduct.Click += DeletePartsAssociated_Click;
            // 
            // CancelAddProduct
            // 
            CancelAddProduct.Font = new Font("Gadugi", 9F);
            CancelAddProduct.Location = new Point(1090, 661);
            CancelAddProduct.Name = "CancelAddProduct";
            CancelAddProduct.Size = new Size(61, 39);
            CancelAddProduct.TabIndex = 34;
            CancelAddProduct.Text = "Cancel";
            CancelAddProduct.UseVisualStyleBackColor = true;
            CancelAddProduct.Click += CancelAddProduct_Click;
            // 
            // clmAllCandidatePartsPartID
            // 
            clmAllCandidatePartsPartID.HeaderText = "Part ID";
            clmAllCandidatePartsPartID.Name = "clmAllCandidatePartsPartID";
            // 
            // clmAllCandidatePartsName
            // 
            clmAllCandidatePartsName.HeaderText = "Name";
            clmAllCandidatePartsName.Name = "clmAllCandidatePartsName";
            // 
            // clmAllCandidatePartsInventory
            // 
            clmAllCandidatePartsInventory.HeaderText = "Inventory";
            clmAllCandidatePartsInventory.Name = "clmAllCandidatePartsInventory";
            // 
            // clmAllCandidatePartsPrice
            // 
            clmAllCandidatePartsPrice.HeaderText = "Price";
            clmAllCandidatePartsPrice.Name = "clmAllCandidatePartsPrice";
            // 
            // clmAllCandidatePartsMin
            // 
            clmAllCandidatePartsMin.HeaderText = "Minimum";
            clmAllCandidatePartsMin.Name = "clmAllCandidatePartsMin";
            // 
            // clmAllCandidatePartsMax
            // 
            clmAllCandidatePartsMax.HeaderText = "Maximum";
            clmAllCandidatePartsMax.Name = "clmAllCandidatePartsMax";
            // 
            // clmPartsAssociatedPartID
            // 
            clmPartsAssociatedPartID.HeaderText = "Part ID";
            clmPartsAssociatedPartID.Name = "clmPartsAssociatedPartID";
            // 
            // clmPartsAssociatedName
            // 
            clmPartsAssociatedName.HeaderText = "Name";
            clmPartsAssociatedName.Name = "clmPartsAssociatedName";
            // 
            // clmPartsAssociatedInventory
            // 
            clmPartsAssociatedInventory.HeaderText = "Inventory";
            clmPartsAssociatedInventory.Name = "clmPartsAssociatedInventory";
            // 
            // clmPartsAssociatedPrice
            // 
            clmPartsAssociatedPrice.HeaderText = "Price";
            clmPartsAssociatedPrice.Name = "clmPartsAssociatedPrice";
            // 
            // clmPartsAssociatedMin
            // 
            clmPartsAssociatedMin.HeaderText = "Minimum";
            clmPartsAssociatedMin.Name = "clmPartsAssociatedMin";
            // 
            // clmPartsAssociatedMax
            // 
            clmPartsAssociatedMax.HeaderText = "Maximum";
            clmPartsAssociatedMax.Name = "clmPartsAssociatedMax";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 731);
            Controls.Add(CancelAddProduct);
            Controls.Add(btnDeletePartAssociatedWithProduct);
            Controls.Add(btnSavePartAssociatedWithProduct);
            Controls.Add(btnAddCandidatePart);
            Controls.Add(lblAddProduct);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox7);
            Controls.Add(dvgPartsAssociatedWithProduct);
            Controls.Add(label1);
            Controls.Add(dvgAllCandidateParts);
            Controls.Add(PartsLabel);
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
        private Label PartsLabel;
        private Button btnSearchAllCandidateParts;
        private TextBox txtSearchAllCandidateParts;
        private DataGridView dvgPartsAssociatedWithProduct;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox7;
        private Label lblAddProduct;
        private Button btnAddCandidatePart;
        private Button btnSavePartAssociatedWithProduct;
        private Button btnDeletePartAssociatedWithProduct;
        private Button CancelAddProduct;
        private DataGridViewTextBoxColumn clmAllCandidatePartsPartID;
        private DataGridViewTextBoxColumn clmAllCandidatePartsName;
        private DataGridViewTextBoxColumn clmAllCandidatePartsInventory;
        private DataGridViewTextBoxColumn clmAllCandidatePartsPrice;
        private DataGridViewTextBoxColumn clmAllCandidatePartsMin;
        private DataGridViewTextBoxColumn clmAllCandidatePartsMax;
        private DataGridViewTextBoxColumn clmPartsAssociatedPartID;
        private DataGridViewTextBoxColumn clmPartsAssociatedName;
        private DataGridViewTextBoxColumn clmPartsAssociatedInventory;
        private DataGridViewTextBoxColumn clmPartsAssociatedPrice;
        private DataGridViewTextBoxColumn clmPartsAssociatedMin;
        private DataGridViewTextBoxColumn clmPartsAssociatedMax;
    }
}