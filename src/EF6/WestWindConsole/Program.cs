﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.DAL;
using WestWindConsole.Entities;

namespace WestWindConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.CheckTables();
        }

        private void CheckTables()
        {
            int menuChoice = 0;
            do
            {
                menuChoice = ChooseTable();
                switch (menuChoice)
                {
                    case 1:
                        DisplayProducts();
                        break;
                    case 2:
                        DisplayCategories();
                        break;
                    case 3:
                        DisplaySuppliers();
                        break;
                    case 4:
                        DisplayOrderDetails();
                        break;
                    case 5:
                        DisplayEmployees();
                        break;
                    case 6:
                        DisplayEmployeeTerritories();
                        break;
                    case 7:
                        DisplayShipments();
                        break;
                    case 8:
                        DisplayShippers();
                        break;
                    // TODO: Practice - Display methods for remaining tables
                    case 9:
                        //DisplayRegions();
                        break;
                    case 10:
                        DisplayPaymentTypes();
                        break;
                    case 11:
                        DisplayPayments();
                        break;
                    case 12:
                        DisplayOrders();
                        break;
                    case 13:
                        DisplayManifestItems();
                        break;
                    case 14:
                        DisplayTerritories();
                        break;
                    case 15:
                        DisplayCustomers();
                        break;
                    case 16:
                        DisplayAdresses();
                        break;
                }
                Pause();
            } while (menuChoice > 0 && menuChoice <= 15);
        }

        private void Pause()
        {
            Console.WriteLine("-- Press [Enter] to continue --");
            Console.ReadLine();
            Console.Clear();
        }

        private void DisplayShippers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Shippers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Shippers");
            }
        }

        

        private void DisplayShipments()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Shipments.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Shipments");
            }
        }

        private void DisplayEmployeeTerritories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.EmployeeTerritories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Employee Territories");
            }
        }

        private void DisplayEmployees()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Employees.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Employees");
            }
        }

        private void DisplayOrderDetails()
        {
            using (var context = new WestWindContext())
            {
                int count = context.OrderDetails.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} order details");
            }
        }

        private void DisplaySuppliers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Suppliers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} suppliers");
            }
        }

        private void DisplayCategories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Categories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} categories");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                var data = context.Categories.Include(nameof(Category.Products));
                foreach (var item in data)
                {
                    Console.WriteLine($"\t{item.CategoryName} has {item.Products.Count()} products");
                }
                Console.ResetColor();
            }
        }

        private void DisplayProducts()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Products.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} products");
            }
        }

        /*private void DisplayRegions()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Regions.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Regions ");
            }
        }*/
        private void DisplayPaymentTypes()
        {
            using (var context = new WestWindContext())
            {
                int count = context.PaymentTypes.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} PaymentTypes ");
            }
        }
        private void DisplayPayments()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Payments.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Payments ");
            }
        }
        private void DisplayOrders()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Orders.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Orders ");
            }
        }
        private void DisplayManifestItems()
        {
            using (var context = new WestWindContext())
            {
                int count = context.ManifestItems.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Manifestitems ");
            }
        }
        private void DisplayTerritories()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Territories.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Territories ");
            }
        }
        private void DisplayCustomers()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Customers.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Customers ");
            }
        }
        private void DisplayAdresses()
        {
            using (var context = new WestWindContext())
            {
                int count = context.Addressesses.Count();
                // $ - String Interpolation
                Console.WriteLine($"There are {count} Adresses ");
            }
        }





        private int ChooseTable()
        {
            Console.WriteLine("1) Products");
            Console.WriteLine("2) Categories");
            Console.WriteLine("3) Suppliers");
            Console.WriteLine("4) Order Details");
            Console.WriteLine("5) Employees");
            Console.WriteLine("6) Employee Territories");
            Console.WriteLine("7) Shipments");
            Console.WriteLine("8) Shippers");
            // TODO: Practice - Menu options for remaining tables
            Console.WriteLine("9) Regions");
            Console.WriteLine("10) PaymentTypes");
            Console.WriteLine("11) Payments");
            Console.WriteLine("12) Orders");
            Console.WriteLine("13) ManifestItems");
            Console.WriteLine("14) Territories");
            Console.WriteLine("15) Customers");
            Console.WriteLine("16) Adresses");


            Console.Write("Select a table (or 0 to exit): ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
