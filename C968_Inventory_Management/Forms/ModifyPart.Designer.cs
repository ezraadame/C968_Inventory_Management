namespace C968_Inventory_Management
{
    partial class ModifyPart
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
            pnlModifyPart = new Panel();
            btnModifyPartsSave = new Button();
            lblMachOrComp = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnModifyPartCancel = new Button();
            txtModifyMachOrComp = new TextBox();
            txtModifyMax = new TextBox();
            txtModifyMin = new TextBox();
            txtModifyInventory = new TextBox();
            txtModifyPriceOrCost = new TextBox();
            txtModifyName = new TextBox();
            txtModifyID = new TextBox();
            rdbtnOutsourced = new RadioButton();
            rdbtnInHouse = new RadioButton();
            lblModifyPartInHouse = new Label();
            pnlModifyPart.SuspendLayout();
            SuspendLayout();
            // 
            // pnlModifyPart
            // 
            pnlModifyPart.Controls.Add(btnModifyPartsSave);
            pnlModifyPart.Controls.Add(lblMachOrComp);
            pnlModifyPart.Controls.Add(label7);
            pnlModifyPart.Controls.Add(label6);
            pnlModifyPart.Controls.Add(label5);
            pnlModifyPart.Controls.Add(label4);
            pnlModifyPart.Controls.Add(label3);
            pnlModifyPart.Controls.Add(label2);
            pnlModifyPart.Controls.Add(btnModifyPartCancel);
            pnlModifyPart.Controls.Add(txtModifyMachOrComp);
            pnlModifyPart.Controls.Add(txtModifyMax);
            pnlModifyPart.Controls.Add(txtModifyMin);
            pnlModifyPart.Controls.Add(txtModifyInventory);
            pnlModifyPart.Controls.Add(txtModifyPriceOrCost);
            pnlModifyPart.Controls.Add(txtModifyName);
            pnlModifyPart.Controls.Add(txtModifyID);
            pnlModifyPart.Controls.Add(rdbtnOutsourced);
            pnlModifyPart.Controls.Add(rdbtnInHouse);
            pnlModifyPart.Controls.Add(lblModifyPartInHouse);
            pnlModifyPart.Font = new Font("Gadugi", 9.75F);
            pnlModifyPart.Location = new Point(26, 12);
            pnlModifyPart.Name = "pnlModifyPart";
            pnlModifyPart.Size = new Size(388, 433);
            pnlModifyPart.TabIndex = 1;
            // 
            // btnModifyPartsSave
            // 
            btnModifyPartsSave.BackColor = SystemColors.GradientInactiveCaption;
            btnModifyPartsSave.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifyPartsSave.Location = new Point(222, 381);
            btnModifyPartsSave.Name = "btnModifyPartsSave";
            btnModifyPartsSave.Size = new Size(62, 34);
            btnModifyPartsSave.TabIndex = 18;
            btnModifyPartsSave.Text = "Save";
            btnModifyPartsSave.UseVisualStyleBackColor = false;
            btnModifyPartsSave.Click += BtnModifyPartsSave_Click;
            // 
            // lblMachOrComp
            // 
            lblMachOrComp.AutoSize = true;
            lblMachOrComp.Font = new Font("Gadugi", 9.75F);
            lblMachOrComp.Location = new Point(44, 333);
            lblMachOrComp.Name = "lblMachOrComp";
            lblMachOrComp.Size = new Size(72, 16);
            lblMachOrComp.TabIndex = 17;
            lblMachOrComp.Text = "Machine ID";
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
            // btnModifyPartCancel
            // 
            btnModifyPartCancel.BackColor = SystemColors.ControlDark;
            btnModifyPartCancel.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifyPartCancel.Location = new Point(290, 381);
            btnModifyPartCancel.Name = "btnModifyPartCancel";
            btnModifyPartCancel.Size = new Size(74, 34);
            btnModifyPartCancel.TabIndex = 10;
            btnModifyPartCancel.Text = "Cancel";
            btnModifyPartCancel.UseVisualStyleBackColor = false;
            btnModifyPartCancel.Click += BtnModifyPartCancel_Click;
            // 
            // txtModifyMachOrComp
            // 
            txtModifyMachOrComp.BackColor = Color.Salmon;
            txtModifyMachOrComp.Location = new Point(147, 330);
            txtModifyMachOrComp.Name = "txtModifyMachOrComp";
            txtModifyMachOrComp.Size = new Size(155, 25);
            txtModifyMachOrComp.TabIndex = 9;
            txtModifyMachOrComp.TextChanged += TxtModifyMachOrComp_TextChanged;
            // 
            // txtModifyMax
            // 
            txtModifyMax.BackColor = Color.Salmon;
            txtModifyMax.Location = new Point(250, 273);
            txtModifyMax.Name = "txtModifyMax";
            txtModifyMax.Size = new Size(102, 25);
            txtModifyMax.TabIndex = 8;
            txtModifyMax.TextChanged += TxtModifyMax_TextChanged;
            // 
            // txtModifyMin
            // 
            txtModifyMin.BackColor = Color.Salmon;
            txtModifyMin.Location = new Point(79, 273);
            txtModifyMin.Name = "txtModifyMin";
            txtModifyMin.Size = new Size(102, 25);
            txtModifyMin.TabIndex = 7;
            txtModifyMin.TextChanged += TxtModifyMin_TextChanged;
            // 
            // txtModifyInventory
            // 
            txtModifyInventory.BackColor = Color.Salmon;
            txtModifyInventory.Location = new Point(147, 177);
            txtModifyInventory.Name = "txtModifyInventory";
            txtModifyInventory.Size = new Size(155, 25);
            txtModifyInventory.TabIndex = 6;
            txtModifyInventory.TextChanged += TxtModifyInventory_TextChanged;
            // 
            // txtModifyPriceOrCost
            // 
            txtModifyPriceOrCost.BackColor = Color.Salmon;
            txtModifyPriceOrCost.Location = new Point(147, 221);
            txtModifyPriceOrCost.Name = "txtModifyPriceOrCost";
            txtModifyPriceOrCost.Size = new Size(155, 25);
            txtModifyPriceOrCost.TabIndex = 5;
            txtModifyPriceOrCost.TextChanged += TxtModifyPriceOrCost_TextChanged;
            // 
            // txtModifyName
            // 
            txtModifyName.BackColor = Color.Salmon;
            txtModifyName.Location = new Point(147, 135);
            txtModifyName.Name = "txtModifyName";
            txtModifyName.Size = new Size(155, 25);
            txtModifyName.TabIndex = 4;
            txtModifyName.TextChanged += TxtModifyName_TextChanged;
            // 
            // txtModifyID
            // 
            txtModifyID.BackColor = SystemColors.InactiveCaption;
            txtModifyID.Location = new Point(147, 93);
            txtModifyID.Name = "txtModifyID";
            txtModifyID.ReadOnly = true;
            txtModifyID.Size = new Size(155, 25);
            txtModifyID.TabIndex = 3;
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
            // lblModifyPartInHouse
            // 
            lblModifyPartInHouse.AutoSize = true;
            lblModifyPartInHouse.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModifyPartInHouse.Location = new Point(12, 9);
            lblModifyPartInHouse.Name = "lblModifyPartInHouse";
            lblModifyPartInHouse.Size = new Size(179, 35);
            lblModifyPartInHouse.TabIndex = 0;
            lblModifyPartInHouse.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 479);
            Controls.Add(pnlModifyPart);
            Name = "ModifyPart";
            Text = "ModifyPart";
            pnlModifyPart.ResumeLayout(false);
            pnlModifyPart.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlModifyPart;
        private Button btnModifyPartsSave;
        private Label lblMachOrComp;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnModifyPartCancel;
        private TextBox txtModifyMachOrComp;
        private TextBox txtModifyMax;
        private TextBox txtModifyMin;
        private TextBox txtModifyInventory;
        private TextBox txtModifyPriceOrCost;
        private TextBox txtModifyName;
        private TextBox txtModifyID;
        private RadioButton rdbtnOutsourced;
        private RadioButton rdbtnInHouse;
        private Label lblModifyPartInHouse;
    }
}