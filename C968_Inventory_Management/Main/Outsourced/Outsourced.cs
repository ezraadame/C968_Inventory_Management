using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Outsourced
{
    internal class OutsourcedPart : Part
    {
        public int PartID;
        public string? Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        public string CompanyName;

        public OutsourcedPart(int partID,
                          string? name,
                          decimal price,
                          int inStock,
                          int min,
                          int max,
                          string? companyName) : base(partID, name, price, inStock, min, max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }

}
