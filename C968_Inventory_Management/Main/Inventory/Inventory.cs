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

        public void AddProduct(Product product) => Products.Add(product);

        public bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Removal failure.");
                    return false;

                }

            }
            return success;
        }

        public Product? LookupProduct(int productID)
        {
            return Products.FirstOrDefault(product => product.ProductID == productID);
        }

        public void UpdateProduct(int productID, Product product)
        {
            RemoveProduct(productID);
            AddProduct(product);
        }



        public void AddPart(Part part) => AllParts.Add(part);

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);

            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }

        public static Part? LookupPart(int partID)
        {
            return AllParts.FirstOrDefault(part => part.PartID == partID);
        }

        public void UpdateParts(int partID, Part part)
        {
            DeletePart(partID);
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

            // Add parts to respective Products
            dummyProd1.AssociatedParts.Add(dummyPart1A);
            dummyProd1.AssociatedParts.Add(dummyPart1B);
            dummyProd2.AssociatedParts.Add(dummyPart2A);
            dummyProd2.AssociatedParts.Add(dummyPart2B);
            dummyProd3.AssociatedParts.Add(dummyPart3A);
            dummyProd3.AssociatedParts.Add(dummyPart3B);
            dummyProd4.AssociatedParts.Add(dummyPart4A);
            dummyProd4.AssociatedParts.Add(dummyPart4B);

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
