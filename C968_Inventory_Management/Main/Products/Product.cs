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
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public int InStock {  get; set; }
        public decimal Price { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        

        public Product(int productID, string? name, int price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;

        }

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts?.Add(part);
        }

        public bool RemoveAssociatedPart() => true;


        public Part LookupAssociatedPart(int partID, Part? part)
        {
            return part;
        }
    }

}
