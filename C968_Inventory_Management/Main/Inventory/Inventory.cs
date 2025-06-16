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

        public static void AddProduct(Product product) => Products.Add(product);

        public static bool RemoveProduct(int productID)
        {
            
            Product productToDelete = LookupProduct(productID);

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



        private static bool _isPopulated = false;
        public static void PopulateDummyLists()
        {
            if (_isPopulated) return; 
            _isPopulated = true;

            Product dummyProd1 = new Product(1, "Product 1", 10, 12, 20, 5);
            Product dummyProd2 = new Product(2, "Product 2", 10, 8, 25, 5);
            Product dummyProd3 = new Product(3, "Product 3", 10, 5, 25, 5);
            Product dummyProd4 = new Product(4, "Product 4", 10, 3, 25, 5);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);

            // add mach ids and comp names
            Part dummyPart1A = new InHousePart(1, "Part 1.A", 15, 15, 30, 10, 9001);
            Part dummyPart1B = new InHousePart(2, "Part 1.B", 10, 12, 25, 10, 9001);
            Part dummyPart2A = new InHousePart(3, "Part 2.A", 12, 10, 25, 10, 9002);
            Part dummyPart2B = new InHousePart(4, "Part 2.B", 15, 5, 25, 10, 9002);
            Part dummyPart3A = new OutsourcedPart(5, "Part 3.A", 15, 15, 30, 10, "ShopCorp");
            Part dummyPart3B = new OutsourcedPart(6, "Part 3.B", 10, 12, 25, 10, "ShopCorp");
            Part dummyPart4A = new OutsourcedPart(7, "Part 4.A", 12, 10, 25, 10, "PPI, LLC");
            Part dummyPart4B = new OutsourcedPart(8, "Part 4.B", 15, 5, 25, 10, "PPI, LLC");

            AllParts.Add(dummyPart1A);
            AllParts.Add(dummyPart1B);
            AllParts.Add(dummyPart2A);
            AllParts.Add(dummyPart2B);
            AllParts.Add(dummyPart3A);
            AllParts.Add(dummyPart3B);
            AllParts.Add(dummyPart4A);
            AllParts.Add(dummyPart4B);

            //Add parts to respective Products
            
            // Fix for CS0176: Member 'Product.AddAssociatedPart(Part)' cannot be accessed with an instance reference; qualify it with a type name instead

            // The issue arises because `AddAssociatedPart` is defined as a static method in the `Product` class.
            // Static methods should be called using the class name, not an instance reference.
            // Update the code to use the class name `Product` instead of the instance reference `dummyProd1`.

            //Product.AssociatedParts.Add(dummyPart1A);
            //Product.AssociatedParts.Add(dummyPart1B);
            //Product.AssociatedParts.Add(dummyPart2A);
            //Product.AssociatedParts.Add(dummyPart2B);
            //Product.AssociatedParts.Add(dummyPart3A);
            //Product.AssociatedParts.Add(dummyPart3B);
            //Product.AssociatedParts.Add(dummyPart4A);
            //Product.AssociatedParts.Add(dummyPart4B);
            

            //    public static int createPartID()
            //{
            //    int highestID = 0;
            //    foreach (Part p in allParts)
            //    {
            //        if (p.getPartID() > highestID)
            //            highestID = p.getPartID();
            //    }
            //    return highestID + 1;
            //}

        }
    }
}
