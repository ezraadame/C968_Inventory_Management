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
        public AddProduct()
        {
            InitializeComponent();
        }

        private void CancelAddProduct_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void AddCandidateParts_Click(object sender, EventArgs e)
        {

        }

        private void SavePartsAssociated_Click(object sender, EventArgs e)
        {

        }

        private void DeletePartsAssociated_Click(object sender, EventArgs e)
        {

        }
    }
}
