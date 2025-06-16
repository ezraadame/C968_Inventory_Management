namespace C968_Inventory_Management
{
    partial class AddPart
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
            panelInHouse = new Panel();
            btnSaveInHousePart = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInHouseCancel = new Button();
            txtBox8 = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            txtAddPartInventory = new TextBox();
            txtAddPartPriceOrCost = new TextBox();
            txtAddPartName = new TextBox();
            txtAddPartID = new TextBox();
            rdbtnOutsourced = new RadioButton();
            rdbtnInHouse = new RadioButton();
            lblAddPartInHouse = new Label();
            panelInHouse.SuspendLayout();
            SuspendLayout();
            // 
            // panelInHouse
            // 
            panelInHouse.Controls.Add(btnSaveInHousePart);
            panelInHouse.Controls.Add(label8);
            panelInHouse.Controls.Add(label7);
            panelInHouse.Controls.Add(label6);
            panelInHouse.Controls.Add(label5);
            panelInHouse.Controls.Add(label4);
            panelInHouse.Controls.Add(label3);
            panelInHouse.Controls.Add(label2);
            panelInHouse.Controls.Add(btnInHouseCancel);
            panelInHouse.Controls.Add(txtBox8);
            panelInHouse.Controls.Add(txtMax);
            panelInHouse.Controls.Add(txtMin);
            panelInHouse.Controls.Add(txtAddPartInventory);
            panelInHouse.Controls.Add(txtAddPartPriceOrCost);
            panelInHouse.Controls.Add(txtAddPartName);
            panelInHouse.Controls.Add(txtAddPartID);
            panelInHouse.Controls.Add(rdbtnOutsourced);
            panelInHouse.Controls.Add(rdbtnInHouse);
            panelInHouse.Controls.Add(lblAddPartInHouse);
            panelInHouse.Font = new Font("Gadugi", 9.75F);
            panelInHouse.Location = new Point(12, 13);
            panelInHouse.Name = "panelInHouse";
            panelInHouse.Size = new Size(388, 433);
            panelInHouse.TabIndex = 0;
            // 
            // btnSaveInHousePart
            // 
            btnSaveInHousePart.BackColor = SystemColors.GradientInactiveCaption;
            btnSaveInHousePart.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveInHousePart.Location = new Point(222, 381);
            btnSaveInHousePart.Name = "btnSaveInHousePart";
            btnSaveInHousePart.Size = new Size(62, 34);
            btnSaveInHousePart.TabIndex = 18;
            btnSaveInHousePart.Text = "Save";
            btnSaveInHousePart.UseVisualStyleBackColor = false;
            btnSaveInHousePart.Click += BtnSaveInHousePart_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 9.75F);
            label8.Location = new Point(44, 333);
            label8.Name = "label8";
            label8.Size = new Size(72, 16);
            label8.TabIndex = 17;
            label8.Text = "Machine ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9.75F);
            label7.Location = new Point(212, 276);
            label7.Name = "label7";
            label7.Size = new Size(32, 16);
            label7.TabIndex = 16;
            label7.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9.75F);
            label6.Location = new Point(44, 276);
            label6.Name = "label6";
            label6.Size = new Size(29, 16);
            label6.TabIndex = 15;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9.75F);
            label5.Location = new Point(75, 224);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 14;
            label5.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9.75F);
            label4.Location = new Point(81, 180);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 13;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F);
            label3.Location = new Point(99, 138);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9.75F);
            label2.Location = new Point(122, 96);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // btnInHouseCancel
            // 
            btnInHouseCancel.BackColor = SystemColors.ControlDark;
            btnInHouseCancel.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInHouseCancel.Location = new Point(290, 381);
            btnInHouseCancel.Name = "btnInHouseCancel";
            btnInHouseCancel.Size = new Size(74, 34);
            btnInHouseCancel.TabIndex = 10;
            btnInHouseCancel.Text = "Cancel";
            btnInHouseCancel.UseVisualStyleBackColor = false;
            btnInHouseCancel.Click += CancelInHouse_Click;
            // 
            // txtBox8
            // 
            txtBox8.BackColor = Color.Salmon;
            txtBox8.Location = new Point(147, 330);
            txtBox8.Name = "txtBox8";
            txtBox8.Size = new Size(155, 25);
            txtBox8.TabIndex = 9;
            txtBox8.TextChanged += TxtMachOrComp_TextChanged;
            // 
            // txtMax
            // 
            txtMax.BackColor = Color.Salmon;
            txtMax.Location = new Point(250, 273);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(102, 25);
            txtMax.TabIndex = 8;
            txtMax.TextChanged += TxtMax_TextChanged;
            // 
            // txtMin
            // 
            txtMin.BackColor = Color.Salmon;
            txtMin.Location = new Point(79, 273);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(102, 25);
            txtMin.TabIndex = 7;
            txtMin.TextChanged += TxtMin_TextChanged;
            // 
            // txtAddPartInventory
            // 
            txtAddPartInventory.BackColor = Color.Salmon;
            txtAddPartInventory.Location = new Point(147, 177);
            txtAddPartInventory.Name = "txtAddPartInventory";
            txtAddPartInventory.Size = new Size(155, 25);
            txtAddPartInventory.TabIndex = 6;
            txtAddPartInventory.TextChanged += TxtAddPartInventory_TextChanged;
            // 
            // txtAddPartPriceOrCost
            // 
            txtAddPartPriceOrCost.BackColor = Color.Salmon;
            txtAddPartPriceOrCost.Location = new Point(147, 221);
            txtAddPartPriceOrCost.Name = "txtAddPartPriceOrCost";
            txtAddPartPriceOrCost.Size = new Size(155, 25);
            txtAddPartPriceOrCost.TabIndex = 5;
            txtAddPartPriceOrCost.TextChanged += TxtAddPartPriceOrCost_TextChanged;
            // 
            // txtAddPartName
            // 
            txtAddPartName.BackColor = Color.Salmon;
            txtAddPartName.Location = new Point(147, 135);
            txtAddPartName.Name = "txtAddPartName";
            txtAddPartName.Size = new Size(155, 25);
            txtAddPartName.TabIndex = 4;
            txtAddPartName.TextChanged += TxtAddPartName_TextChanged;
            // 
            // txtAddPartID
            // 
            txtAddPartID.BackColor = SystemColors.InactiveCaption;
            txtAddPartID.Location = new Point(147, 93);
            txtAddPartID.Name = "txtAddPartID";
            txtAddPartID.ReadOnly = true;
            txtAddPartID.Size = new Size(155, 25);
            txtAddPartID.TabIndex = 3;
            // 
            // rdbtnOutsourced
            // 
            rdbtnOutsourced.AutoSize = true;
            rdbtnOutsourced.BackColor = SystemColors.Control;
            rdbtnOutsourced.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtnOutsourced.Location = new Point(250, 48);
            rdbtnOutsourced.Name = "rdbtnOutsourced";
            rdbtnOutsourced.Size = new Size(114, 23);
            rdbtnOutsourced.TabIndex = 2;
            rdbtnOutsourced.TabStop = true;
            rdbtnOutsourced.Text = "Out Sourced";
            rdbtnOutsourced.UseVisualStyleBackColor = false;
            rdbtnOutsourced.CheckedChanged += RdbtnOutsourced_CheckedChanged;
            // 
            // rdbtnInHouse
            // 
            rdbtnInHouse.AutoSize = true;
            rdbtnInHouse.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtnInHouse.Location = new Point(250, 21);
            rdbtnInHouse.Name = "rdbtnInHouse";
            rdbtnInHouse.Size = new Size(90, 23);
            rdbtnInHouse.TabIndex = 1;
            rdbtnInHouse.TabStop = true;
            rdbtnInHouse.Text = "In-House";
            rdbtnInHouse.UseVisualStyleBackColor = true;
            rdbtnInHouse.CheckedChanged += RdbtnInHouse_CheckedChanged;
            // 
            // lblAddPartInHouse
            // 
            lblAddPartInHouse.AutoSize = true;
            lblAddPartInHouse.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddPartInHouse.Location = new Point(12, 9);
            lblAddPartInHouse.Name = "lblAddPartInHouse";
            lblAddPartInHouse.Size = new Size(136, 35);
            lblAddPartInHouse.TabIndex = 0;
            lblAddPartInHouse.Text = "Add Part";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 482);
            Controls.Add(panelInHouse);
            Font = new Font("Gadugi", 9.75F);
            Name = "AddPart";
            Text = "Parts";
            panelInHouse.ResumeLayout(false);
            panelInHouse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInHouse;
        private Label lblAddPartInHouse;
        private RadioButton rdbtnOutsourced;
        private RadioButton rdbtnInHouse;
        private TextBox txtBox8;
        private TextBox txtMax;
        private TextBox txtMin;
        private TextBox txtAddPartInventory;
        private TextBox txtAddPartPriceOrCost;
        private TextBox txtAddPartName;
        private TextBox txtAddPartID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnInHouseCancel;
        private Button btnSaveInHousePart;
    }
}