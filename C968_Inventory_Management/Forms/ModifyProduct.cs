using C968_Inventory_Management.Main.InHouse;
using C968_Inventory_Management.Main.Inventory;
using C968_Inventory_Management.Main.Parts;
using C968_Inventory_Management.Main.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Inventory_Management
{
    public partial class ModifyProduct : Form
    {

        private readonly BindingList<Part> AssociatedPartsQue = [];
        public ModifyProduct(Product product)
        {
            InitializeComponent();


            dvgAllCandidateParts.DataSource = Inventory.AllParts;
            dvgAllCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgAllCandidateParts.ReadOnly = true;
            dvgAllCandidateParts.MultiSelect = false;
            dvgAllCandidateParts.AllowUserToAddRows = false;

            foreach (Part part in product.AssociatedParts)
            {
                AssociatedPartsQue.Add(part);
            }

            dvgPartsAssociatedWithProduct.DataSource = AssociatedPartsQue;
            dvgPartsAssociatedWithProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgPartsAssociatedWithProduct.ReadOnly = true;
            dvgPartsAssociatedWithProduct.MultiSelect = false;
            dvgPartsAssociatedWithProduct.AllowUserToAddRows = false;

            txtModProductID.Text = product.ProductID.ToString();
            txtModProductName.Text = product.Name;
            txtModInventory.Text = product.InStock.ToString();
            txtModPriceOrCost.Text = product.Price.Substring(1).ToString();
            txtModMin.Text = product.Min.ToString();
            txtModMax.Text = product.Max.ToString();

        }


        private void BtnSearchAllCandidateParts_Click(object sender, EventArgs e)
        {
            dvgAllCandidateParts.ClearSelection();
            bool found = false;
            if (txtAllCandidateParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name?.ToLower().Contains(txtAllCandidateParts.Text.ToLower()) ?? false)
                    {
                        dvgAllCandidateParts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void BtnAddCandidateParts_Click(object sender, EventArgs e)
        {
            if (dvgAllCandidateParts.CurrentRow == null || !dvgAllCandidateParts.CurrentRow.Selected)
            {
                MessageBox.Show("No part selected. Please select a part to add.");
                return;
            }

            if (dvgAllCandidateParts.CurrentRow.DataBoundItem is Part partAssociatedWithProduct)
            {
                AssociatedPartsQue.Add(partAssociatedWithProduct);
            }
            else
            {
                MessageBox.Show("Unable to add the selected part.");
            }
        }

        private void BtnSavePartAssociatedWithProduct_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int inventoryStock;
            decimal price;
            string name = txtModProductName.Text;
            int productID = int.Parse(txtModProductID.Text);

            try
            {
                minStock = int.Parse(txtModMin.Text);
                maxStock = int.Parse(txtModMax.Text);
                inventoryStock = int.Parse(txtModInventory.Text);
                price = decimal.Parse(txtModPriceOrCost.Text);

            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Min, and Max must ALL be numeric values.");
                return;

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

            if (AssociatedPartsQue.Count == 0)
            {
                MessageBox.Show("You must have at least ONE part associated before saving.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product updatedProduct = new(productID, name, inventoryStock, price, minStock, maxStock);
            foreach (Part newPart in AssociatedPartsQue)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }
            Inventory.UpdateProduct(productID, updatedProduct);

            Close();

        }

        private void BtnDeletePartAssociatedWithProduct_Click(object sender, EventArgs e)
        {
            if (dvgPartsAssociatedWithProduct.CurrentRow == null || !dvgPartsAssociatedWithProduct.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please select something!");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the association of this part to the product?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dvgPartsAssociatedWithProduct.CurrentRow.DataBoundItem is Part selectedPart)
                {
                    AssociatedPartsQue.Remove(selectedPart);
                }
                else
                {
                    MessageBox.Show("Unable to delete the selected part.");
                }
            }
            else return;
        }
        private void TxtModProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtModProductName.Text.Length > 0)
            {
                txtModProductName.BackColor = Color.White;
            }
            else
            {
                txtModProductName.BackColor = Color.Salmon;
            }
        }

        private void TxtModInventory_TextChanged(object sender, EventArgs e)
        {
            if (txtModInventory.Text.Length > 0)
            {
                txtModInventory.BackColor = Color.White;
            }
            else
            {
                txtModInventory.BackColor = Color.Salmon;
            }
        }

        private void TxtModPriceOrCost_TextChanged(object sender, EventArgs e)
        {
            if (txtModPriceOrCost.Text.Length > 0)
            {
                txtModPriceOrCost.BackColor = Color.White;
            }
            else
            {
                txtModPriceOrCost.BackColor = Color.Salmon;
            }
        }

        private void TxtModMin_TextChanged(object sender, EventArgs e)
        {
            if (txtModMin.Text.Length > 0)
            {
                txtModMin.BackColor = Color.White;
            }
            else
            {
                txtModMin.BackColor = Color.Salmon;
            }
        }

        private void TxtModMax_TextChanged(object sender, EventArgs e)
        {
            if (txtModMax.Text.Length > 0)
            {
                txtModMax.BackColor = Color.White;
            }
            else
            {
                txtModMax.BackColor = Color.Salmon;
            }
        }

        private void BtnCancelModifyProduct_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
