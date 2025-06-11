using C968_Inventory_Management.Main.Parts;
using C968_Inventory_Management.Main.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Inventory
{
    public class Inventory
    {
        public List<Product> Products = new List<Product>();
        public List<Part> AllParts = new List<Part>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int productID)
        {
            return true;
        }

        public Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault();
        }

        public void UpdateProduct(int productID, Product product)
        {
            Console.WriteLine("HI");
        }

        ///

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            return true;
        }

        public Part LookupPart(int partID)
        {
            return AllParts.FirstOrDefault();
        }

        public void UpdateParts(int partID, Part part)
        {
            Console.WriteLine("Temporary");
        }
    }
}
