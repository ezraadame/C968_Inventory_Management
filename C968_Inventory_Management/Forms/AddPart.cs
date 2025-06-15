using C968_Inventory_Management.Main.InHouse;
using C968_Inventory_Management.Main.Inventory;
using C968_Inventory_Management.Main.Outsourced;
using C968_Inventory_Management.Main.Parts;
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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }


        private void CancelInHouse_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void CancelOutSourced_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void rdbtnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
            
        }

        private void rdbtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
            
        }

        private void btnSaveInHousePart_Click(object sender, EventArgs e)
        {

            int minStock;
            int maxStock;
            int inventoryStock;
            decimal price;

            minStock = int.Parse(txtMin.Text);
            maxStock = int.Parse(txtMax.Text);
            inventoryStock = int.Parse(txtAddPartInventory.Text);
            price = decimal.Parse(txtAddPartPriceOrCost.Text);
            string name = txtAddPartName.Text;




            if (rdbtnInHouse.Checked)
            {
                InHousePart inHouse = new InHousePart(
                    (Inventory.AllParts.Count + 1), name, inventoryStock, price, minStock, maxStock, int.Parse(txtBox8.Text));

                Inventory.AllParts.Add(inHouse);

                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                OutsourcedPart outsourced = new OutsourcedPart(
                    (Inventory.AllParts.Count + 1), name, inventoryStock, price, minStock, maxStock, txtBox8.Text);
                Inventory.AllParts.Add(outsourced);

                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }

        }
    }
}
