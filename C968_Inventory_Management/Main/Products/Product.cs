using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Products
{
    public class Product : Part
    {
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

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
