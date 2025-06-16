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

        private BindingList<Part> AssociatedPartsQue = new BindingList<Part>();
        public ModifyProduct(Product product)
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

            txtModProductID.Text = product.ProductID.ToString();
            txtModProductName.Text = product.Name;
            txtModInventory.Text = product.InStock.ToString();
            txtModPriceOrCost.Text = product.Price.Substring(1).ToString();
            txtModMin.Text = product.Min.ToString();
            txtModMax.Text = product.Max.ToString();

        }


        private void btnSearchAllCandidateParts_Click(object sender, EventArgs e)
        {
            dvgAllCandidateParts.ClearSelection();
            bool found = false;
            if (txtAllCandidateParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToLower().Contains(txtAllCandidateParts.Text.ToLower()))
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

        private void btnAddCandidateParts_Click(object sender, EventArgs e)
        {
            if (dvgAllCandidateParts.CurrentRow == null || !dvgAllCandidateParts.CurrentRow.Selected)
            {
                MessageBox.Show("No part selected. Please select a part to add.");
                return;
            }

            Part partAssociatedWithProduct = (Part)dvgAllCandidateParts.CurrentRow.DataBoundItem;
            AssociatedPartsQue.Add(partAssociatedWithProduct);
        }

        private void btnSavePartAssociatedWithProduct_Click(object sender, EventArgs e)
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


            Product updatedProduct = new Product(
                productID, name, inventoryStock, price, minStock, maxStock);

            Inventory.UpdateProduct(productID, updatedProduct);

            foreach (Part part in AssociatedPartsQue)
            {
                updatedProduct.AddAssociatedPart(part);
            }
            Close();

        }

        private void btnDeletePartAssociatedWithProduct_Click(object sender, EventArgs e)
        {

        }



















        private void txtModProductName_TextChanged(object sender, EventArgs e)
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

        private void txtModInventory_TextChanged(object sender, EventArgs e)
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

        private void txtModPriceOrCost_TextChanged(object sender, EventArgs e)
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

        private void txtModMin_TextChanged(object sender, EventArgs e)
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

        private void txtModMax_TextChanged(object sender, EventArgs e)
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



        private void btnCancelModifyProduct_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
