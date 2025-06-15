using C968_Inventory_Management.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.InHouse
{

    public class InHousePart : Part
    {
        private int machineID;
        public int MachineID { get; set; }

        
        public InHousePart(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;


        }

        public InHousePart(int partID, string name, int inStock, decimal price, int min, int max, int machineID)
        {

            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Min = min;
            Max = max;
            MachineID = machineID;

        }
    }
}
