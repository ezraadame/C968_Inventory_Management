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
            tbnCancelModifyProduct = new Button();
            btnDeletePartAssociatedWithProduct = new Button();
            btnSavePartAssociatedWithProduct = new Button();
            btnAddCandidateParts = new Button();
            lblModifyProduct = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtModMax = new TextBox();
            txtModMin = new TextBox();
            txtModInventory = new TextBox();
            txtModPriceOrCost = new TextBox();
            txtModProductName = new TextBox();
            txtModProductID = new TextBox();
            dvgPartsAssociatedWithProduct = new DataGridView();
            lblPartAssociatedWithProduct = new Label();
            dvgAllCandidateParts = new DataGridView();
            lblAllCandidateParts = new Label();
            btnSearchAllCandidateParts = new Button();
            txtAllCandidateParts = new TextBox();
            lblModPriceOrCost = new Label();
            lblModMin = new Label();
            lblModMax = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgPartsAssociatedWithProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).BeginInit();
            SuspendLayout();
            // 
            // tbnCancelModifyProduct
            // 
            tbnCancelModifyProduct.Font = new Font("Gadugi", 9F);
            tbnCancelModifyProduct.Location = new Point(1099, 587);
            tbnCancelModifyProduct.Name = "tbnCancelModifyProduct";
            tbnCancelModifyProduct.Size = new Size(61, 39);
            tbnCancelModifyProduct.TabIndex = 59;
            tbnCancelModifyProduct.Text = "Cancel";
            tbnCancelModifyProduct.UseVisualStyleBackColor = true;
            tbnCancelModifyProduct.Click += btnCancelModifyProduct_Click;
            // 
            // btnDeletePartAssociatedWithProduct
            // 
            btnDeletePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnDeletePartAssociatedWithProduct.Location = new Point(464, 465);
            btnDeletePartAssociatedWithProduct.Name = "btnDeletePartAssociatedWithProduct";
            btnDeletePartAssociatedWithProduct.Size = new Size(61, 39);
            btnDeletePartAssociatedWithProduct.TabIndex = 58;
            btnDeletePartAssociatedWithProduct.Text = "Delete";
            btnDeletePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnDeletePartAssociatedWithProduct.Click += btnDeletePartAssociatedWithProduct_Click;
            // 
            // btnSavePartAssociatedWithProduct
            // 
            btnSavePartAssociatedWithProduct.Font = new Font("Gadugi", 9F);
            btnSavePartAssociatedWithProduct.Location = new Point(464, 406);
            btnSavePartAssociatedWithProduct.Name = "btnSavePartAssociatedWithProduct";
            btnSavePartAssociatedWithProduct.Size = new Size(61, 39);
            btnSavePartAssociatedWithProduct.TabIndex = 57;
            btnSavePartAssociatedWithProduct.Text = "Save";
            btnSavePartAssociatedWithProduct.UseVisualStyleBackColor = true;
            btnSavePartAssociatedWithProduct.Click += btnSavePartAssociatedWithProduct_Click;
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
            btnAddCandidateParts.Click += btnAddCandidateParts_Click;
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
            // txtModMax
            // 
            txtModMax.BackColor = Color.Salmon;
            txtModMax.Location = new Point(296, 400);
            txtModMax.Name = "txtModMax";
            txtModMax.Size = new Size(102, 23);
            txtModMax.TabIndex = 48;
            txtModMax.TextChanged += txtModMax_TextChanged;
            // 
            // txtModMin
            // 
            txtModMin.BackColor = Color.Salmon;
            txtModMin.Location = new Point(138, 400);
            txtModMin.Name = "txtModMin";
            txtModMin.Size = new Size(102, 23);
            txtModMin.TabIndex = 47;
            txtModMin.TextChanged += txtModMin_TextChanged;
            // 
            // txtModInventory
            // 
            txtModInventory.BackColor = Color.Salmon;
            txtModInventory.Location = new Point(186, 297);
            txtModInventory.Name = "txtModInventory";
            txtModInventory.Size = new Size(155, 23);
            txtModInventory.TabIndex = 46;
            txtModInventory.TextChanged += txtModInventory_TextChanged;
            // 
            // txtModPriceOrCost
            // 
            txtModPriceOrCost.BackColor = Color.Salmon;
            txtModPriceOrCost.Location = new Point(186, 344);
            txtModPriceOrCost.Name = "txtModPriceOrCost";
            txtModPriceOrCost.Size = new Size(155, 23);
            txtModPriceOrCost.TabIndex = 45;
            txtModPriceOrCost.TextChanged += txtModPriceOrCost_TextChanged;
            // 
            // txtModProductName
            // 
            txtModProductName.BackColor = Color.Salmon;
            txtModProductName.Location = new Point(186, 253);
            txtModProductName.Name = "txtModProductName";
            txtModProductName.Size = new Size(155, 23);
            txtModProductName.TabIndex = 44;
            txtModProductName.TextChanged += txtModProductName_TextChanged;
            // 
            // txtModProductID
            // 
            txtModProductID.BackColor = SystemColors.InactiveCaption;
            txtModProductID.Location = new Point(186, 208);
            txtModProductID.Name = "txtModProductID";
            txtModProductID.ReadOnly = true;
            txtModProductID.Size = new Size(155, 23);
            txtModProductID.TabIndex = 43;
            // 
            // dvgPartsAssociatedWithProduct
            // 
            dvgPartsAssociatedWithProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPartsAssociatedWithProduct.Location = new Point(557, 333);
            dvgPartsAssociatedWithProduct.Name = "dvgPartsAssociatedWithProduct";
            dvgPartsAssociatedWithProduct.RowHeadersVisible = false;
            dvgPartsAssociatedWithProduct.Size = new Size(603, 230);
            dvgPartsAssociatedWithProduct.TabIndex = 42;
            // 
            // lblPartAssociatedWithProduct
            // 
            lblPartAssociatedWithProduct.AutoSize = true;
            lblPartAssociatedWithProduct.Font = new Font("Gadugi", 13.75F);
            lblPartAssociatedWithProduct.Location = new Point(557, 297);
            lblPartAssociatedWithProduct.Name = "lblPartAssociatedWithProduct";
            lblPartAssociatedWithProduct.Size = new Size(263, 22);
            lblPartAssociatedWithProduct.TabIndex = 41;
            lblPartAssociatedWithProduct.Text = "Parts Associated With Product";
            // 
            // dvgAllCandidateParts
            // 
            dvgAllCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAllCandidateParts.Location = new Point(557, 66);
            dvgAllCandidateParts.Name = "dvgAllCandidateParts";
            dvgAllCandidateParts.RowHeadersVisible = false;
            dvgAllCandidateParts.Size = new Size(603, 220);
            dvgAllCandidateParts.TabIndex = 38;
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
            btnSearchAllCandidateParts.Click += btnSearchAllCandidateParts_Click;
            // 
            // txtAllCandidateParts
            // 
            txtAllCandidateParts.Location = new Point(1000, 31);
            txtAllCandidateParts.Name = "txtAllCandidateParts";
            txtAllCandidateParts.Size = new Size(160, 23);
            txtAllCandidateParts.TabIndex = 35;
            // 
            // lblModPriceOrCost
            // 
            lblModPriceOrCost.AutoSize = true;
            lblModPriceOrCost.Font = new Font("Gadugi", 9.75F);
            lblModPriceOrCost.Location = new Point(103, 346);
            lblModPriceOrCost.Name = "lblModPriceOrCost";
            lblModPriceOrCost.Size = new Size(66, 16);
            lblModPriceOrCost.TabIndex = 60;
            lblModPriceOrCost.Text = "Price/Cost";
            // 
            // lblModMin
            // 
            lblModMin.AutoSize = true;
            lblModMin.Font = new Font("Gadugi", 9.75F);
            lblModMin.Location = new Point(90, 402);
            lblModMin.Name = "lblModMin";
            lblModMin.Size = new Size(29, 16);
            lblModMin.TabIndex = 61;
            lblModMin.Text = "Min";
            // 
            // lblModMax
            // 
            lblModMax.AutoSize = true;
            lblModMax.Font = new Font("Gadugi", 9.75F);
            lblModMax.Location = new Point(258, 402);
            lblModMax.Name = "lblModMax";
            lblModMax.Size = new Size(32, 16);
            lblModMax.TabIndex = 62;
            lblModMax.Text = "Max";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 638);
            Controls.Add(lblModMax);
            Controls.Add(lblModMin);
            Controls.Add(lblModPriceOrCost);
            Controls.Add(tbnCancelModifyProduct);
            Controls.Add(btnDeletePartAssociatedWithProduct);
            Controls.Add(btnSavePartAssociatedWithProduct);
            Controls.Add(btnAddCandidateParts);
            Controls.Add(lblModifyProduct);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModMax);
            Controls.Add(txtModMin);
            Controls.Add(txtModInventory);
            Controls.Add(txtModPriceOrCost);
            Controls.Add(txtModProductName);
            Controls.Add(txtModProductID);
            Controls.Add(dvgPartsAssociatedWithProduct);
            Controls.Add(lblPartAssociatedWithProduct);
            Controls.Add(dvgAllCandidateParts);
            Controls.Add(lblAllCandidateParts);
            Controls.Add(btnSearchAllCandidateParts);
            Controls.Add(txtAllCandidateParts);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)dvgPartsAssociatedWithProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tbnCancelModifyProduct;
        private Button btnDeletePartAssociatedWithProduct;
        private Button btnSavePartAssociatedWithProduct;
        private Button btnAddCandidateParts;
        private Label lblModifyProduct;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtModMax;
        private TextBox txtModMin;
        private TextBox txtModInventory;
        private TextBox txtModPriceOrCost;
        private TextBox txtModProductName;
        private TextBox txtModProductID;
        private DataGridView dvgPartsAssociatedWithProduct;
        private Label lblPartAssociatedWithProduct;
        private DataGridView dvgAllCandidateParts;
        private Label lblAllCandidateParts;
        private Button btnSearchAllCandidateParts;
        private TextBox txtAllCandidateParts;
        private Label lblModPriceOrCost;
        private Label lblModMin;
        private Label lblModMax;
    }
}