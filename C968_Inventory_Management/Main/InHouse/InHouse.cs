using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.InHouse
{

    internal class InHousePart : Part
    {
        public int PartID;
        public string? Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        public int MachineID;

        public InHousePart(int partID, string? name, decimal price, int inStock, int min, int max, int machineID) : base(partID, name, price, inStock, min, max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
