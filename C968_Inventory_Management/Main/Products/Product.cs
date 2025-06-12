using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Products
{
    public class Product(
        int productID, string? name, int price, int inStock, int min, int max)
    {
        public int ProductID = productID;
        public string? Name = name;
        public decimal Price = price;
        public int InStock = inStock;
        public int Min = min;
        public int Max = max;



        public List<Part> AssociatedParts = new List<Part>();
        

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
