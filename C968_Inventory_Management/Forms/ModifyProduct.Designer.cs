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
            txtModMax = new Label();
            txtModMin = new Label();
            txtModPriceOrCost = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            txtModInventory = new TextBox();
            textBox3 = new TextBox();
            txtModProductName = new TextBox();
            txtModProductID = new TextBox();
            dvgPartAssociatedWithProduct = new DataGridView();
            lblPartAssociatedWithProduct = new Label();
            dvgAllCandidateParts = new DataGridView();
            lblAllCandidateParts = new Label();
            btnSearchAllCandidateParts = new Button();
            txtAllCandidateParts = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgPartAssociatedWithProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgAllCandidateParts).BeginInit();
            SuspendLayout();
            // 
            // tbnCancelModifyProduct
            // 
            tbnCancelModifyProduct.Font = new Font("Gadugi", 9F);
            tbnCancelModifyProduct.Location = new Point(1099, 601);
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
            btnDeletePartAssociatedWithProduct.Location = new Point(464, 479);
            btnDeletePartAssociatedWithProduct.Name = "btnDeletePartAssociatedWithProduct";
            btnDeletePartAssociatedWithProduct.Size = new Size(61, 39);
            btnDeletePartAssociatedWithProduct.TabIndex = 58;
            btnDeletePartAssociatedWithProduct.Text = "Delete";
            btnDeletePartAssociatedWithProduct.UseVisualStyleBackColor = true;
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
            // txtModMax
            // 
            txtModMax.AutoSize = true;
            txtModMax.Font = new Font("Gadugi", 9.75F);
            txtModMax.Location = new Point(258, 403);
            txtModMax.Name = "txtModMax";
            txtModMax.Size = new Size(32, 16);
            txtModMax.TabIndex = 54;
            txtModMax.Text = "Max";
            // 
            // txtModMin
            // 
            txtModMin.AutoSize = true;
            txtModMin.Font = new Font("Gadugi", 9.75F);
            txtModMin.Location = new Point(103, 403);
            txtModMin.Name = "txtModMin";
            txtModMin.Size = new Size(29, 16);
            txtModMin.TabIndex = 53;
            txtModMin.Text = "Min";
            // 
            // txtModPriceOrCost
            // 
            txtModPriceOrCost.AutoSize = true;
            txtModPriceOrCost.Font = new Font("Gadugi", 9.75F);
            txtModPriceOrCost.Location = new Point(103, 351);
            txtModPriceOrCost.Name = "txtModPriceOrCost";
            txtModPriceOrCost.Size = new Size(66, 16);
            txtModPriceOrCost.TabIndex = 52;
            txtModPriceOrCost.Text = "Price/Cost";
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
            textBox6.BackColor = Color.Salmon;
            textBox6.Location = new Point(296, 400);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(102, 23);
            textBox6.TabIndex = 48;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Salmon;
            textBox5.Location = new Point(138, 400);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(102, 23);
            textBox5.TabIndex = 47;
            // 
            // txtModInventory
            // 
            txtModInventory.BackColor = Color.Salmon;
            txtModInventory.Location = new Point(186, 297);
            txtModInventory.Name = "txtModInventory";
            txtModInventory.Size = new Size(155, 23);
            txtModInventory.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Salmon;
            textBox3.Location = new Point(186, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 45;
            // 
            // txtModProductName
            // 
            txtModProductName.BackColor = Color.Salmon;
            txtModProductName.Location = new Point(186, 253);
            txtModProductName.Name = "txtModProductName";
            txtModProductName.Size = new Size(155, 23);
            txtModProductName.TabIndex = 44;
            // 
            // txtModProductID
            // 
            txtModProductID.BackColor = SystemColors.InactiveCaption;
            txtModProductID.Location = new Point(186, 208);
            txtModProductID.Name = "txtModProductID";
            txtModProductID.Size = new Size(155, 23);
            txtModProductID.TabIndex = 43;
            // 
            // dvgPartAssociatedWithProduct
            // 
            dvgPartAssociatedWithProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPartAssociatedWithProduct.Location = new Point(557, 347);
            dvgPartAssociatedWithProduct.Name = "dvgPartAssociatedWithProduct";
            dvgPartAssociatedWithProduct.RowHeadersVisible = false;
            dvgPartAssociatedWithProduct.Size = new Size(603, 230);
            dvgPartAssociatedWithProduct.TabIndex = 42;
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
            Controls.Add(tbnCancelModifyProduct);
            Controls.Add(btnDeletePartAssociatedWithProduct);
            Controls.Add(btnSavePartAssociatedWithProduct);
            Controls.Add(btnAddCandidateParts);
            Controls.Add(lblModifyProduct);
            Controls.Add(txtModMax);
            Controls.Add(txtModMin);
            Controls.Add(txtModPriceOrCost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(txtModInventory);
            Controls.Add(textBox3);
            Controls.Add(txtModProductName);
            Controls.Add(txtModProductID);
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

        private Button tbnCancelModifyProduct;
        private Button btnDeletePartAssociatedWithProduct;
        private Button btnSavePartAssociatedWithProduct;
        private Button btnAddCandidateParts;
        private Label lblModifyProduct;
        private Label txtModMax;
        private Label txtModMin;
        private Label txtModPriceOrCost;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox txtModInventory;
        private TextBox textBox3;
        private TextBox txtModProductName;
        private TextBox txtModProductID;
        private DataGridView dvgPartAssociatedWithProduct;
        private Label lblPartAssociatedWithProduct;
        private DataGridView dvgAllCandidateParts;
        private Label lblAllCandidateParts;
        private Button btnSearchAllCandidateParts;
        private TextBox txtAllCandidateParts;
    }
}