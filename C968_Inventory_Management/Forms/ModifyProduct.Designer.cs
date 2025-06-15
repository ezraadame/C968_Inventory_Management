namespace C968_Inventory_Management
{
    partial class ModifyProduct
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
            CancelInModifyProduct = new Button();
            btnDeletePartAssociatedWithProduct = new Button();
            btnSavePartAssociatedWithProduct = new Button();
            btnAddCandidateParts = new Button();
            lblModifyProduct = new Label();
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
            dvgPartAssociatedWithProduct = new DataGridView();
            clmPartsAssociatedPartID = new DataGridViewTextBoxColumn();
            clmPartsAssociatedName = new DataGridViewTextBoxColumn();
            clmPartsAssociatedInventory = new DataGridViewTextBoxColumn();
            clmPartsAssociatedPrice = new DataGridViewTextBoxColumn();
            clmPartsAssociatedMin = new DataGridViewTextBoxColumn();
            clmPartsAssociatedMax = new DataGridViewTextBoxColumn();
            lblPartAssociatedWithProduct = new Label();
            dvgAllCandidateParts = new DataGridView();
            clmAllCanidatePartsPartID = new DataGridViewTextBoxColumn();
            clmAllCanidatePartsName = new DataGridViewTextBoxColumn();
            clmAllCanidatePartsInventory = new DataGridViewTextBoxColumn();
            clmAllCanidatePartsPrice = new DataGridViewTextBoxColumn();
            clmAllCanidatePartsMin = new DataGridViewTextBoxColumn();
            clmAllCanidatePartsMax = new DataGridViewTextBoxColumn();
            lblAllCandidateParts = new Label();
            btnSearchAllCandidateParts = new Button();
            txtAllCandidateParts = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgPartAssociatedWithProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).BeginInit();
            SuspendLayout();
            // 
            // CancelInModifyProduct
            // 
            CancelInModifyProduct.Font = new Font("Gadugi", 9F);
            CancelInModifyProduct.Location = new Point(1099, 601);
            CancelInModifyProduct.Name = "CancelInModifyProduct";
            CancelInModifyProduct.Size = new Size(61, 39);
            CancelInModifyProduct.TabIndex = 59;
            CancelInModifyProduct.Text = "Cancel";
            CancelInModifyProduct.UseVisualStyleBackColor = true;
            CancelInModifyProduct.Click += CancelInModifyProduct_Click;
            // 
            // btnDeletePartAssociatedWithProduct
            // 
            btnDeletePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnDeletePartAssociatedWithProduct.Location = new Point(464, 479);
            btnDeletePartAssociatedWithProduct.Name = "btnDeletePartAssociatedWithProduct";
            btnDeletePartAssociatedWithProduct.Size = new Size(61, 39);
            btnDeletePartAssociatedWithProduct.TabIndex = 58;
            btnDeletePartAssociatedWithProduct.Text = "Delete";
            btnDeletePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnDeletePartAssociatedWithProduct.Click += DeleteInModifyProduct_Click;
            // 
            // btnSavePartAssociatedWithProduct
            // 
            btnSavePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnSavePartAssociatedWithProduct.Location = new Point(464, 420);
            btnSavePartAssociatedWithProduct.Name = "btnSavePartAssociatedWithProduct";
            btnSavePartAssociatedWithProduct.Size = new Size(61, 39);
            btnSavePartAssociatedWithProduct.TabIndex = 57;
            btnSavePartAssociatedWithProduct.Text = "Save";
            btnSavePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnSavePartAssociatedWithProduct.Click += SaveInModifyProduct_Click;
            // 
            // btnAddCandidateParts
            // 
            btnAddCandidateParts.Font = new Font("Gadugi", 9F);
            btnAddCandidateParts.Location = new Point(464, 157);
            btnAddCandidateParts.Name = "btnAddCandidateParts";
            btnAddCandidateParts.Size = new Size(61, 39);
            btnAddCandidateParts.TabIndex = 56;
            btnAddCandidateParts.Text = "Add";
            btnAddCandidateParts.UseVisualStyleBackColor = true;
            btnAddCandidateParts.Click += AddButtoninModifyProduct_Click;
            // 
            // lblModifyProduct
            // 
            lblModifyProduct.AutoSize = true;
            lblModifyProduct.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModifyProduct.Location = new Point(36, 27);
            lblModifyProduct.Name = "lblModifyProduct";
            lblModifyProduct.Size = new Size(231, 35);
            lblModifyProduct.TabIndex = 55;
            lblModifyProduct.Text = "Modify Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9.75F);
            label7.Location = new Point(258, 403);
            label7.Name = "label7";
            label7.Size = new Size(32, 16);
            label7.TabIndex = 54;
            label7.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9.75F);
            label6.Location = new Point(103, 403);
            label6.Name = "label6";
            label6.Size = new Size(29, 16);
            label6.TabIndex = 53;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9.75F);
            label5.Location = new Point(103, 351);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 52;
            label5.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9.75F);
            label4.Location = new Point(103, 300);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 51;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F);
            label3.Location = new Point(103, 255);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 50;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9.75F);
            label2.Location = new Point(103, 210);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 49;
            label2.Text = "ID";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(296, 400);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(102, 23);
            textBox6.TabIndex = 48;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 400);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(102, 23);
            textBox5.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(186, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 44;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(186, 208);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 23);
            textBox7.TabIndex = 43;
            // 
            // dvgPartAssociatedWithProduct
            // 
            dvgPartAssociatedWithProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPartAssociatedWithProduct.Columns.AddRange(new DataGridViewColumn[] { clmPartsAssociatedPartID, clmPartsAssociatedName, clmPartsAssociatedInventory, clmPartsAssociatedPrice, clmPartsAssociatedMin, clmPartsAssociatedMax });
            dvgPartAssociatedWithProduct.Location = new Point(557, 347);
            dvgPartAssociatedWithProduct.Name = "dvgPartAssociatedWithProduct";
            dvgPartAssociatedWithProduct.RowHeadersVisible = false;
            dvgPartAssociatedWithProduct.Size = new Size(603, 230);
            dvgPartAssociatedWithProduct.TabIndex = 42;
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
            // lblPartAssociatedWithProduct
            // 
            lblPartAssociatedWithProduct.AutoSize = true;
            lblPartAssociatedWithProduct.Font = new Font("Gadugi", 13.75F);
            lblPartAssociatedWithProduct.Location = new Point(557, 311);
            lblPartAssociatedWithProduct.Name = "lblPartAssociatedWithProduct";
            lblPartAssociatedWithProduct.Size = new Size(263, 22);
            lblPartAssociatedWithProduct.TabIndex = 41;
            lblPartAssociatedWithProduct.Text = "Parts Associated With Product";
            // 
            // dvgAllCandidateParts
            // 
            dvgAllCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAllCandidateParts.Columns.AddRange(new DataGridViewColumn[] { clmAllCanidatePartsPartID, clmAllCanidatePartsName, clmAllCanidatePartsInventory, clmAllCanidatePartsPrice, clmAllCanidatePartsMin, clmAllCanidatePartsMax });
            dvgAllCandidateParts.Location = new Point(557, 66);
            dvgAllCandidateParts.Name = "dvgAllCandidateParts";
            dvgAllCandidateParts.RowHeadersVisible = false;
            dvgAllCandidateParts.Size = new Size(603, 220);
            dvgAllCandidateParts.TabIndex = 38;
            // 
            // clmAllCanidatePartsPartID
            // 
            clmAllCanidatePartsPartID.HeaderText = "Part ID";
            clmAllCanidatePartsPartID.Name = "clmAllCanidatePartsPartID";
            // 
            // clmAllCanidatePartsName
            // 
            clmAllCanidatePartsName.HeaderText = "Name";
            clmAllCanidatePartsName.Name = "clmAllCanidatePartsName";
            // 
            // clmAllCanidatePartsInventory
            // 
            clmAllCanidatePartsInventory.HeaderText = "Inventory";
            clmAllCanidatePartsInventory.Name = "clmAllCanidatePartsInventory";
            // 
            // clmAllCanidatePartsPrice
            // 
            clmAllCanidatePartsPrice.HeaderText = "Price";
            clmAllCanidatePartsPrice.Name = "clmAllCanidatePartsPrice";
            // 
            // clmAllCanidatePartsMin
            // 
            clmAllCanidatePartsMin.HeaderText = "Minimum";
            clmAllCanidatePartsMin.Name = "clmAllCanidatePartsMin";
            // 
            // clmAllCanidatePartsMax
            // 
            clmAllCanidatePartsMax.HeaderText = "Maximum";
            clmAllCanidatePartsMax.Name = "clmAllCanidatePartsMax";
            // 
            // lblAllCandidateParts
            // 
            lblAllCandidateParts.AutoSize = true;
            lblAllCandidateParts.Font = new Font("Gadugi", 13.75F);
            lblAllCandidateParts.Location = new Point(557, 30);
            lblAllCandidateParts.Name = "lblAllCandidateParts";
            lblAllCandidateParts.Size = new Size(170, 22);
            lblAllCandidateParts.TabIndex = 37;
            lblAllCandidateParts.Text = "All Candidate Parts";
            // 
            // btnSearchAllCandidateParts
            // 
            btnSearchAllCandidateParts.Location = new Point(920, 30);
            btnSearchAllCandidateParts.Name = "btnSearchAllCandidateParts";
            btnSearchAllCandidateParts.Size = new Size(74, 25);
            btnSearchAllCandidateParts.TabIndex = 36;
            btnSearchAllCandidateParts.Text = "Search";
            btnSearchAllCandidateParts.UseVisualStyleBackColor = true;
            // 
            // txtAllCandidateParts
            // 
            txtAllCandidateParts.Location = new Point(1000, 31);
            txtAllCandidateParts.Name = "txtAllCandidateParts";
            txtAllCandidateParts.Size = new Size(160, 23);
            txtAllCandidateParts.TabIndex = 35;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 668);
            Controls.Add(CancelInModifyProduct);
            Controls.Add(btnDeletePartAssociatedWithProduct);
            Controls.Add(btnSavePartAssociatedWithProduct);
            Controls.Add(btnAddCandidateParts);
            Controls.Add(lblModifyProduct);
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
            Controls.Add(dvgPartAssociatedWithProduct);
            Controls.Add(lblPartAssociatedWithProduct);
            Controls.Add(dvgAllCandidateParts);
            Controls.Add(lblAllCandidateParts);
            Controls.Add(btnSearchAllCandidateParts);
            Controls.Add(txtAllCandidateParts);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)dvgPartAssociatedWithProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelInModifyProduct;
        private Button btnDeletePartAssociatedWithProduct;
        private Button btnSavePartAssociatedWithProduct;
        private Button btnAddCandidateParts;
        private Label lblModifyProduct;
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
        private DataGridView dvgPartAssociatedWithProduct;
        private Label lblPartAssociatedWithProduct;
        private DataGridView dvgAllCandidateParts;
        private Label lblAllCandidateParts;
        private Button btnSearchAllCandidateParts;
        private TextBox txtAllCandidateParts;
        private DataGridViewTextBoxColumn clmAllCanidatePartsPartID;
        private DataGridViewTextBoxColumn clmAllCanidatePartsName;
        private DataGridViewTextBoxColumn clmAllCanidatePartsInventory;
        private DataGridViewTextBoxColumn clmAllCanidatePartsPrice;
        private DataGridViewTextBoxColumn clmAllCanidatePartsMin;
        private DataGridViewTextBoxColumn clmAllCanidatePartsMax;
        private DataGridViewTextBoxColumn clmPartsAssociatedPartID;
        private DataGridViewTextBoxColumn clmPartsAssociatedName;
        private DataGridViewTextBoxColumn clmPartsAssociatedInventory;
        private DataGridViewTextBoxColumn clmPartsAssociatedPrice;
        private DataGridViewTextBoxColumn clmPartsAssociatedMin;
        private DataGridViewTextBoxColumn clmPartsAssociatedMax;
    }
}