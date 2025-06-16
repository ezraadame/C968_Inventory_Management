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
    public partial class AddProduct : Form
    {

        private BindingList<Part> AssociatedPartsQue = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();

            dvgAllCandidateParts.DataSource = Inventory.AllParts;
            dvgAllCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgAllCandidateParts.ReadOnly = true;
            dvgAllCandidateParts.MultiSelect = false;
            dvgAllCandidateParts.AllowUserToAddRows = false;

            dvgPartsAssociatedWithProduct.DataSource = AssociatedPartsQue;
            dvgPartsAssociatedWithProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgPartsAssociatedWithProduct.ReadOnly = true;
            dvgPartsAssociatedWithProduct.MultiSelect = false;
            dvgPartsAssociatedWithProduct.AllowUserToAddRows = false;

        }

        private void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void dvgAllCandidateParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dvgAllCandidateParts.ClearSelection();
        }

        private void btnAddCandidatePart_Click(object sender, EventArgs e)
        {
            if (dvgAllCandidateParts.CurrentRow == null || !dvgAllCandidateParts.CurrentRow.Selected)
            {
                MessageBox.Show("No part selected. Please select a part to add.");
                return;
            }

            Part partAssociatedWithProduct = (Part)dvgAllCandidateParts.CurrentRow.DataBoundItem;
            AssociatedPartsQue.Add(partAssociatedWithProduct);
        }

        private void btnDeletePartAssociatedWithProduct_Click(object sender, EventArgs e)
        {
            if (dvgPartsAssociatedWithProduct.CurrentRow == null || !dvgPartsAssociatedWithProduct.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please select something!");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the association of this part to the product?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part? selectedPart = dvgPartsAssociatedWithProduct.CurrentRow.DataBoundItem as Part;
                if (selectedPart != null)
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

        private void btnSavePartAssociatedWithProduct_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int inventoryStock;
            decimal price;
            string name = txtProductName.Text;

            try
            {
                minStock = int.Parse(txtProductMin.Text);
                maxStock = int.Parse(txtProductMax.Text);
                inventoryStock = int.Parse(txtProductInventory.Text);
                price = decimal.Parse(txtProductPriceOrCost.Text);

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


            Product productToAdd = new Product(
                (Inventory.Products.Count + 1), name, inventoryStock, price, minStock, maxStock);

            Inventory.AddProduct(productToAdd);

            foreach (Part part in AssociatedPartsQue)
            {
                productToAdd.AddAssociatedPart(part);
            }

            MainForm main = new MainForm();
            main.Show();
            this.Hide();

        }

        private void btnSearchAllCandidateParts_Click(object sender, EventArgs e)
        {
            dvgAllCandidateParts.ClearSelection();
            bool found = false;
            if (txtSearchAllCandidateParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToLower().Contains(txtSearchAllCandidateParts.Text.ToLower()))
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

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text.Length > 0)
            {
                txtProductName.BackColor = Color.White;
            }
            else
            {
                txtProductName.BackColor = Color.Salmon;
            }
        }

        private void txtProductInventory_TextChanged(object sender, EventArgs e)
        {
            if (txtProductInventory.Text.Length > 0)
            {
                txtProductInventory.BackColor = Color.White;
            }
            else
            {
                txtProductInventory.BackColor = Color.Salmon;
            }
        }

        private void txtProductPriceOrCost_TextChanged(object sender, EventArgs e)
        {
            if (txtProductPriceOrCost.Text.Length > 0)
            {
                txtProductPriceOrCost.BackColor = Color.White;
            }
            else
            {
                txtProductPriceOrCost.BackColor = Color.Salmon;
            }
        }

        private void txtProductMin_TextChanged(object sender, EventArgs e)
        {
            if (txtProductMin.Text.Length > 0)
            {
                txtProductMin.BackColor = Color.White;
            }
            else
            {
                txtProductMin.BackColor = Color.Salmon;
            }
        }

        private void txtProductMax_TextChanged(object sender, EventArgs e)
        {
            if (txtProductMax.Text.Length > 0)
            {
                txtProductMax.BackColor = Color.White;
            }
            else
            {
                txtProductMax.BackColor = Color.Salmon;
            }
        }

    }
}
