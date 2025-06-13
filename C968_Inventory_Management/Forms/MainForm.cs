using C968_Inventory_Management.Main.Inventory;
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
            Inventory.PopulateDummyLists();

            dvgParts.DataSource = Inventory.AllParts;
            dvgProducts.DataSource = Inventory.Products;
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
            // Existing code remains unchanged  
        }

        private void PartsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Existing code remains unchanged  
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

        private void SearchBoxParts_TextChanged(object sender, EventArgs e)
        {
            // Existing code remains unchanged  
        }

        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Existing code remains unchanged  
        }

        private void DeletePartsButton_Click(object sender, EventArgs e)
        {
          
        }

        private void DeleteProductsButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
