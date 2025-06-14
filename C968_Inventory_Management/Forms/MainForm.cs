using C968_Inventory_Management.Main.Inventory;
using C968_Inventory_Management.Main.Parts;
using C968_Inventory_Management.Main.Products;
using System.Windows.Forms;


namespace C968_Inventory_Management
{
    public partial class MainForm : Form
    {
        private Inventory inventory = new Inventory();
        public MainForm()
        {
            InitializeComponent();
            txtSearchParts.Text += txtSearchParts_TextChanged;

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
            // Existing code remains unchanged  
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            // Existing code remains unchanged  
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            string searchParts = txtSearchParts.Text.ToLower();

            var filteredItem = Inventory.AllParts
                .Where(item => item.Name != null && item.Name.ToLower().Contains(searchParts))
                .ToList();
            dvgParts.DataSource = filteredItem;
        }

        private void AddPartsButton_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
            this.Hide();
        }

        private void ModifyPartsButton_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.Show();
            this.Hide();
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
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



        private void DeletePartsButton_Click(object sender, EventArgs e)
        {
            if (dvgParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                Inventory.AllParts.Remove(selectedPart);
            }
            else
            {
                MessageBox.Show("Invalid selection.");
            }
        }

        private void DeleteProductsButton_Click(object sender, EventArgs e)
        {
            if (dvgProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                Inventory.Products.Remove(selectedProduct);
            }
            else
            {
                MessageBox.Show("Invalid selection.");
            }
        }



        private void dvgParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dvgParts.ClearSelection();
        }

        private void dvgProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dvgProducts.ClearSelection();
        }

        private void txtSearchParts_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
