using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Products
{
    public class Product
    {
        public int ProductID;
        public string? Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        public List<Part> AssociatedParts = new List<Part>();

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart() => true;

        public Part LookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartID == partID);
        }
    }

}
