using C968_Inventory_Management.Main.InHouse;
using C968_Inventory_Management.Main.Outsourced;
using C968_Inventory_Management.Main.Parts;
using C968_Inventory_Management.Main.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Inventory_Management.Main.Inventory
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();
        
        //Product section
        public static void AddProduct(Product product) => Products.Add(product);

        public static bool RemoveProduct(int productID)
        {
            Product? productToDelete = LookupProduct(productID);

            if (productToDelete == null)
            {
                return false;
            }
            else
            {
                Products.Remove(productToDelete);
                return true;
            }
        }

        public static Product? LookupProduct(int productID)
        {
            return Products.FirstOrDefault(product => product.ProductID == productID);
        }

        public static void UpdateProduct(int productID, Product product)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = product.Name;
                    currentProduct.InStock = product.InStock;
                    currentProduct.Price = product.Price;
                    currentProduct.Min = product.Min;
                    currentProduct.Max = product.Max;
                    currentProduct.AssociatedParts = product.AssociatedParts;
                    return;
                }
            }
        }

        //End of product section

        //Part section
        public static void AddPart(Part part) => AllParts.Add(part);

        public static bool DeletePart(Part part)
        {
            foreach (var product in Products)
            {
                if (product.LookupAssociatedPart(part.PartID) != null)
                {
                    return false;
                }
            }
            AllParts.Remove(part);
            return true;
        }

        public static Part? LookupPart(int partID)
        {
            return AllParts.FirstOrDefault(part => part.PartID == partID);
        }

        public static void UpdateParts(int partID, Part part)
        {
            Part? existingPart = LookupPart(partID);
            if (existingPart != null)
            {
                AllParts.Remove(existingPart);
            }
            AddPart(part);
        }

        //End of part section
    }
}
