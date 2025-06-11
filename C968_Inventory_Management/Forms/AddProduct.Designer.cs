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
            PartsTable = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            NameOfParts = new DataGridViewTextBoxColumn();
            PartsInventory = new DataGridViewTextBoxColumn();
            PriceOfParts = new DataGridViewTextBoxColumn();
            MininumParts = new DataGridViewTextBoxColumn();
            MaximumParts = new DataGridViewTextBoxColumn();
            PartsLabel = new Label();
            SearchPartButton = new Button();
            SearchBoxParts = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
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
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PartsTable
            // 
            PartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID, NameOfParts, PartsInventory, PriceOfParts, MininumParts, MaximumParts });
            PartsTable.Location = new Point(548, 68);
            PartsTable.Name = "PartsTable";
            PartsTable.RowHeadersVisible = false;
            PartsTable.Size = new Size(603, 220);
            PartsTable.TabIndex = 11;
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
            // PartsInventory
            // 
            PartsInventory.HeaderText = "Inventory";
            PartsInventory.Name = "PartsInventory";
            // 
            // PriceOfParts
            // 
            PriceOfParts.HeaderText = "Price";
            PriceOfParts.Name = "PriceOfParts";
            // 
            // MininumParts
            // 
            MininumParts.HeaderText = "Minimum";
            MininumParts.Name = "MininumParts";
            // 
            // MaximumParts
            // 
            MaximumParts.HeaderText = "Maximum";
            MaximumParts.Name = "MaximumParts";
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
            // SearchPartButton
            // 
            SearchPartButton.Location = new Point(911, 32);
            SearchPartButton.Name = "SearchPartButton";
            SearchPartButton.Size = new Size(74, 25);
            SearchPartButton.TabIndex = 9;
            SearchPartButton.Text = "Search";
            SearchPartButton.UseVisualStyleBackColor = true;
            // 
            // SearchBoxParts
            // 
            SearchBoxParts.Location = new Point(991, 33);
            SearchBoxParts.Name = "SearchBoxParts";
            SearchBoxParts.Size = new Size(160, 23);
            SearchBoxParts.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView1.Location = new Point(548, 398);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(603, 230);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Minimum";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Maximum";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 29);
            label8.Name = "label8";
            label8.Size = new Size(188, 35);
            label8.TabIndex = 30;
            label8.Text = "Add Product";
            // 
            // button2
            // 
            button2.Font = new Font("Gadugi", 9F);
            button2.Location = new Point(455, 159);
            button2.Name = "button2";
            button2.Size = new Size(61, 39);
            button2.TabIndex = 31;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Gadugi", 9F);
            button3.Location = new Point(455, 471);
            button3.Name = "button3";
            button3.Size = new Size(61, 39);
            button3.TabIndex = 32;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Gadugi", 9F);
            button4.Location = new Point(455, 530);
            button4.Name = "button4";
            button4.Size = new Size(61, 39);
            button4.TabIndex = 33;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Gadugi", 9F);
            button5.Location = new Point(1090, 661);
            button5.Name = "button5";
            button5.Size = new Size(61, 39);
            button5.TabIndex = 34;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 731);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
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
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(PartsTable);
            Controls.Add(PartsLabel);
            Controls.Add(SearchPartButton);
            Controls.Add(SearchBoxParts);
            Font = new Font("Gadugi", 9F);
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)PartsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PartsTable;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn NameOfParts;
        private DataGridViewTextBoxColumn PartsInventory;
        private DataGridViewTextBoxColumn PriceOfParts;
        private DataGridViewTextBoxColumn MininumParts;
        private DataGridViewTextBoxColumn MaximumParts;
        private Label PartsLabel;
        private Button SearchPartButton;
        private TextBox SearchBoxParts;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
        private Label label8;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}