using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Parts
{
    public abstract class Part 
    {

        public int PartID;
        public string? Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        protected Part(int partID, string? name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }


    }
}
