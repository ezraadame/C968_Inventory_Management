using C968_Inventory_Management.Main.Inventory;
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

            // Correctly cast the selected item to Part instead of Inventory
            Part selectedPart = dvgParts.CurrentRow.DataBoundItem as Part;
            if (selectedPart != null)
            {
                Inventory.AllParts.Remove(selectedPart);
            }
            else
            {
                MessageBox.Show("Unable to delete the selected part.");
            }
        }

        private void ModifyPartsButton_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.Show();
            this.Hide();
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

            // Correctly cast the selected item to Part instead of Inventory
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

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct();
            modifyProduct.Show();
            this.Hide();
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
