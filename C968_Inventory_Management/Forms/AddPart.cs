using C968_Inventory_Management.Main.InHouse;
using C968_Inventory_Management.Main.Inventory;
using C968_Inventory_Management.Main.Outsourced;
using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// AddPart form for adding new parts to the inventory

namespace C968_Inventory_Management
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void CancelInHouse_Click(object sender, EventArgs e)
        {
            MainForm main = new();
            main.Show();
            this.Hide();
        }

        private void CancelOutSourced_Click(object sender, EventArgs e)
        {
            MainForm main = new();
            main.Show();
            this.Hide();
        }

        private void RdbtnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }
        private void RdbtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }
        private void BtnSaveInHousePart_Click(object sender, EventArgs e)
        {

            int minStock;
            int maxStock;
            int inventoryStock;
            decimal price;
            string name = txtAddPartName.Text;

            try
            {
                minStock = int.Parse(txtMin.Text);
                maxStock = int.Parse(txtMax.Text);
                inventoryStock = int.Parse(txtAddPartInventory.Text);
                price = decimal.Parse(txtAddPartPriceOrCost.Text);

            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Min, and Max must ALL be numeric values.");
                return;

            }


            if (label8.Text == "Machine ID")
            {
                try
                {
                    int.Parse(txtBox8.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Machine ID must be an integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (maxStock < minStock)
            {
                MessageBox.Show("Minimum cannot exceed Maximum!");
                return;
            }

            if (inventoryStock > maxStock || inventoryStock < minStock)
            {
                MessageBox.Show($"Error: Inventory must be between your min: {minStock} and your max: {maxStock}!");
                return;
            }

            if (rdbtnInHouse.Checked)
            {
                InHousePart inHouse = new(
                    (Inventory.AllParts.Count + 1), name, inventoryStock, price, minStock, maxStock, int.Parse(txtBox8.Text));

                Inventory.AllParts.Add(inHouse);

                MainForm main = new();
                main.Show();
                this.Hide();
            }
            else if (rdbtnOutsourced.Checked)
            {
                OutsourcedPart outsourced = new(
                    (Inventory.AllParts.Count + 1), name, inventoryStock, price, minStock, maxStock, txtBox8.Text);
                Inventory.AllParts.Add(outsourced);

                MainForm main = new();
                main.Show();
                this.Hide();
            }


        }



        //Color change handling
        private void TxtAddPartName_TextChanged(object sender, EventArgs e)
        {
            if (txtAddPartName.Text.Length > 0)
            {
                txtAddPartName.BackColor = Color.White;
            }
            else
            {
                txtAddPartName.BackColor = Color.Salmon;
            }
        }

        private void TxtAddPartInventory_TextChanged(object sender, EventArgs e)
        {
            if (txtAddPartInventory.Text.Length > 0)
            {
                txtAddPartInventory.BackColor = Color.White;
            }
            else
            {
                txtAddPartInventory.BackColor = Color.Salmon;
            }
        }

        private void TxtAddPartPriceOrCost_TextChanged(object sender, EventArgs e)
        {
            if (txtAddPartPriceOrCost.Text.Length > 0)
            {
                txtAddPartPriceOrCost.BackColor = Color.White;
            }
            else
            {
                txtAddPartPriceOrCost.BackColor = Color.Salmon;
            }
        }

        private void TxtMin_TextChanged(object sender, EventArgs e)
        {
            if (txtMin.Text.Length > 0)
            {
                txtMin.BackColor = Color.White;
            }
            else
            {
                txtMin.BackColor = Color.Salmon;
            }
        }

        private void TxtMax_TextChanged(object sender, EventArgs e)
        {
            if (txtMax.Text.Length > 0)
            {
                txtMax.BackColor = Color.White;
            }
            else
            {
                txtMax.BackColor = Color.Salmon;
            }
        }

        private void TxtMachOrComp_TextChanged(object sender, EventArgs e)
        {
            if (txtBox8.Text.Length > 0)
            {
                txtBox8.BackColor = Color.White;
            }
            else
            {
                txtBox8.BackColor = Color.Salmon;
            }
        }
    }
}
