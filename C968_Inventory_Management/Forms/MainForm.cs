using C968_Inventory_Management.Main.InHouse;
using C968_Inventory_Management.Main.Inventory;
using C968_Inventory_Management.Main.Outsourced;
using C968_Inventory_Management.Main.Parts;
using C968_Inventory_Management.Main.Products;
using System.Windows.Forms;


namespace C968_Inventory_Management
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Inventory.PopulateDummyLists();


            dvgParts.DataSource = Inventory.AllParts;
            dvgParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgParts.ReadOnly = true;
            dvgParts.MultiSelect = false;
            dvgParts.AllowUserToAddRows = false;

            dvgProducts.DataSource = Inventory.Products;
            dvgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProducts.ReadOnly = true;
            dvgProducts.MultiSelect = false;
            dvgProducts.AllowUserToAddRows = false;
        }

        public void MainFormLoad(object sender, EventArgs e)
        {

        }


        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            dvgParts.ClearSelection();
            bool found = false;
            if (txtSearchParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToLower().Contains(txtSearchParts.Text.ToLower()))
                    {
                        dvgParts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
            


        }

        private void AddPartsButton_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
            this.Hide();
        }

        private void btnDeleteParts_Click(object sender, EventArgs e)
        {

            if (dvgParts.CurrentRow == null || !dvgParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please select something!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item forever?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part selectedPart = dvgParts.CurrentRow.DataBoundItem as Part;
                if (Inventory.DeletePart(selectedPart) == false)
                {
                    MessageBox.Show($"Unable to delete. Ensure that the selected part is not associated with a current product before deletion!"
                        , "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ModifyPartsButton_Click(object sender, EventArgs e)
        {

            if (dvgParts.CurrentRow == null || !dvgParts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please select something!");
                return;
            }

            var part = dvgParts.CurrentRow.DataBoundItem;
            Form modifyPartForm = null;

            if (part is InHousePart inHousePart)
            {
                modifyPartForm = new ModifyPart(inHousePart);
            }
            else if (part is OutsourcedPart outsourcedPart)
            {
                modifyPartForm = new ModifyPart(outsourcedPart);
            }

            if (modifyPartForm != null)
            {
                this.Hide();
                modifyPartForm.ShowDialog();
                this.Show();
            }
        }


        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            dvgParts.ClearSelection();
            bool found = false;
            if (txtSearchProducts.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToLower().Contains(txtSearchProducts.Text.ToLower()))
                    {
                        dvgProducts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (dvgProducts.CurrentRow == null || !dvgProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please select something!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item forever?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product selectedProduct = dvgProducts.CurrentRow.DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    Inventory.Products.Remove(selectedProduct);
                }
                else
                {
                    MessageBox.Show("Unable to delete the selected part.");
                }
            }
            else return;

        }

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            if (dvgProducts.CurrentRow == null || !dvgProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please select something!");
                return;
            }

            var selectedProduct = dvgProducts.CurrentRow.DataBoundItem;
            Form modifyProductForm = null;

            if (selectedProduct is Product product)
            {
                modifyProductForm = new ModifyProduct(product);
            }

            if (modifyProductForm != null)
            {
                this.Hide();
                modifyProductForm.ShowDialog();
                this.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dvgParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dvgParts.ClearSelection();
        }

        private void dvgProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dvgProducts.ClearSelection();
        }

        
    }
}
