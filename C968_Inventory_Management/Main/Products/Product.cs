using C968_Inventory_Management.Main.Parts;
using System.ComponentModel;

namespace C968_Inventory_Management.Main.Products
{
    public class Product 
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }

        public decimal price;
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
                    success = true;
                    return success;
                }
            }
            MessageBox.Show("Removal failure.");
            return false;
        }

        public Part? LookupAssociatedPart(int partID)
        {
            var associatedPart = AssociatedParts.FirstOrDefault(part => part.PartID == partID);
            return associatedPart;
        }

    }

}
