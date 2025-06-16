using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C968_Inventory_Management.Main.Products
{
    public class Product 
    {
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();
        
        private int productID;
        private string name;
        private int inStock;
        private decimal price;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }

        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }

        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;

        }

        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);

        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
            }
            MessageBox.Show("Removal failure.");
            return false;
        }

        public Part? LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }

}
