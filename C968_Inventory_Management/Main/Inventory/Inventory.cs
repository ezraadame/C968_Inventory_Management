using C968_Inventory_Management.Main.Parts;
using C968_Inventory_Management.Main.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Inventory
{
    public class InventoryProducts : Product
    {
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product product) => Products.Add(Products.FirstOrDefault());

        public bool RemoveProduct() => true;

        public Product LookupProduct(int id) => Products.FirstOrDefault();

        public void UpdateProduct(int ProductID, Product product) => Products.Remove(product);


    }

    public class InventoryParts : Part
    {
        public List<Part> Parts = new List<Part>();

        public void AddPart(Part part) => Parts.Add(part);

        public bool DeletePart() => true;

        public Part LookupPart(int PartID) => Parts?.FirstOrDefault();

        public void UpdatePart(int PartID, Part part) => Parts.Remove(part);


    }
}
