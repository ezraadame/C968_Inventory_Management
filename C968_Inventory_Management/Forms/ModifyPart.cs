using C968_Inventory_Management.Main.InHouse;
using C968_Inventory_Management.Main.Inventory;
using C968_Inventory_Management.Main.Outsourced;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_Inventory_Management
{
    public partial class ModifyPart : Form
    {
        public ModifyPart(InHousePart inHousePart)
        {
            InitializeComponent();
            txtModifyID.Text = inHousePart.PartID.ToString();
            txtModifyName.Text = inHousePart.Name;
            txtModifyInventory.Text = inHousePart.InStock.ToString();
            txtModifyPriceOrCost.Text = inHousePart.Price.Substring(1).ToString();
            txtModifyMin.Text = inHousePart.Min.ToString();
            txtModifyMax.Text = inHousePart.Max.ToString();
            txtModifyMachOrComp.Text = inHousePart.MachineID.ToString();

        }

        public ModifyPart(OutsourcedPart outsourcedPart)
        {
            InitializeComponent();
            txtModifyID.Text = outsourcedPart.PartID.ToString();
            txtModifyName.Text = outsourcedPart.Name;
            txtModifyInventory.Text = outsourcedPart.InStock.ToString();
            txtModifyPriceOrCost.Text = outsourcedPart.Price.Substring(1).ToString();
            txtModifyMin.Text = outsourcedPart.Min.ToString();
            txtModifyMax.Text = outsourcedPart.Max.ToString();
            txtModifyMachOrComp.Text = outsourcedPart.CompanyName.ToString();
            rdbtnOutsourced.Checked = true;
        }





        private void txtModifyName_TextChanged(object sender, EventArgs e)
        {
            if (txtModifyName.Text.Length > 0)
            {
                txtModifyName.BackColor = Color.White;
            }
            else
            {
                txtModifyName.BackColor = Color.Salmon;
            }
        }

        private void txtModifyInventory_TextChanged(object sender, EventArgs e)
        {
            if (txtModifyInventory.Text.Length > 0)
            {
                txtModifyInventory.BackColor = Color.White;
            }
            else
            {
                txtModifyInventory.BackColor = Color.Salmon;
            }
        }

        private void txtModifyPriceOrCost_TextChanged(object sender, EventArgs e)
        {
            if (txtModifyPriceOrCost.Text.Length > 0)
            {
                txtModifyPriceOrCost.BackColor = Color.White;
            }
            else
            {
                txtModifyPriceOrCost.BackColor = Color.Salmon;
            }
        }

        private void txtModifyMin_TextChanged(object sender, EventArgs e)
        {
            if (txtModifyMin.Text.Length > 0)
            {
                txtModifyMin.BackColor = Color.White;
            }
            else
            {
                txtModifyMin.BackColor = Color.Salmon;
            }
        }

        private void txtModifyMax_TextChanged(object sender, EventArgs e)
        {
            if (txtModifyMax.Text.Length > 0)
            {
                txtModifyMax.BackColor = Color.White;
            }
            else
            {
                txtModifyMax.BackColor = Color.Salmon;
            }
        }

        private void txtModifyMachOrComp_TextChanged(object sender, EventArgs e)
        {
            if (txtModifyMachOrComp.Text.Length > 0)
            {
                txtModifyMachOrComp.BackColor = Color.White;
            }
            else
            {
                txtModifyMachOrComp.BackColor = Color.Salmon;
            }
        }

        private void rdbtnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachOrComp.Text = "Machine ID";
        }

        private void rdbtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachOrComp.Text = "Company Name";
        }

        private void btnModifyPartsSave_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int inventoryStock;
            decimal price;


            try
            {
                minStock = int.Parse(txtModifyMin.Text);
                maxStock = int.Parse(txtModifyMax.Text);
                inventoryStock = int.Parse(txtModifyInventory.Text);
                price = decimal.Parse(txtModifyPriceOrCost.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Min, and Max must ALL be numeric values.");
                return;
            }

            int partID = int.Parse(txtModifyID.Text);
            string name = txtModifyName.Text;
            inventoryStock = int.Parse(txtModifyInventory.Text);
            price = decimal.Parse(txtModifyPriceOrCost.Text);
            minStock = int.Parse(txtModifyMin.Text);
            maxStock = int.Parse(txtModifyMax.Text);


            if (lblMachOrComp.Text == "Machine ID")
            {
                try
                {
                    int.Parse(txtModifyMachOrComp.Text);
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
                InHousePart inHousePart = new InHousePart(
                    partID, name, inventoryStock, price, minStock, maxStock, int.Parse(txtModifyMachOrComp.Text));
                Inventory.UpdateParts(partID, inHousePart);
                rdbtnInHouse.Checked = true;
            }
            else
            {
                OutsourcedPart outsourcedPart = new OutsourcedPart(
                    partID, name, inventoryStock, price, minStock, maxStock, txtModifyMachOrComp.Text);
                Inventory.UpdateParts(partID, outsourcedPart);
                rdbtnInHouse.Checked = true;
            }
            Close();

        }

        private void btnModifyPartCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
