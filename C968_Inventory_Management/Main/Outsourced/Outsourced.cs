using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Outsourced
{
    internal class OutsourcedPart : Part
    {
        private string companyName;

        public string CompanyName { get; set; }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int min , int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;

        }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int min, int max, string compName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;
            CompanyName = compName;

        }



    }
}
