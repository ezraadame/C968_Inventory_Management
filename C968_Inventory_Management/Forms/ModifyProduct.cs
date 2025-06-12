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
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void CancelInModifyProduct_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void AddButtoninModifyProduct_Click(object sender, EventArgs e)
        {

        }

        private void SaveInModifyProduct_Click(object sender, EventArgs e)
        {

        }

        private void DeleteInModifyProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
