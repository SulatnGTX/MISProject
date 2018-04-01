using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] CustomerID = new string[5];
            CustomerID[0] = "0001";
            CustomerID[1] = "0002";
            CustomerID[2] = "0003";
            CustomerID[3] = "0004";
            CustomerID[4] = "0005";

            List<Customer> customers = new List<Customer>();

            Customer cust1 = new Customer();
            cust1.ID = "0001";
            cust1.Name = "Foo";
            cust1.Phone = "316 555 5050";
            cust1.Email = "foo@gmail.com";
            cust1.Address = "555 Mulberry Ln, Wichita, KS 67212";

            customers.Add(cust1);

            Customer cust2 = new Customer();
            cust2.ID = "0002";
            cust2.Name = "Pho";
            cust2.Phone = "316 555 1010";
            cust2.Email = "pho@gmail.com";
            cust2.Address = "532 Mulberry Ln, Wichita, KS 67212";

            customers.Add(cust2);



            string[] ProductID = new string[5];
            ProductID[0] = "0001";
            ProductID[1] = "0002";
            ProductID[2] = "0003";
            ProductID[3] = "0004";
            ProductID[4] = "0005";

            List<Product> Products = new List<Product>();

            Product prod1 = new Product();
            prod1.ID = "0001";
            prod1.Name = "iPhone";
            prod1.Category = "Phone";
            prod1.Description = "smartphone";
            prod1.Price = "1099";

            Products.Add(prod1);


            WriteLine("Chose from the options:");
            WriteLine();
            WriteLine("New Cosumter = 1, New Product = 2, Order/Sales = 3, Search Csutomer ID = 4, Search Csutomer Name =5, Search Product ID = 6, Search Product Name = 7, Calculate total sales by product = 8, Calculate total sales for customer by entering name =9");
            WriteLine();
            WriteLine("Enter your option:");
            int Info = ToInt32(ReadLine());

            if (Info == 1)
            {
                WriteLine("The Customer information");
                WriteLine();
                WriteLine("The Customer's ID:");
                String CID = ReadLine();
                WriteLine();
                WriteLine("The Customer's First and Last Name:");
                String CName = ReadLine();
                WriteLine();
                WriteLine("The Customer's Email:");
                String CEmail = ReadLine();
                WriteLine();
                WriteLine("The Customer's Address:");
                String CAddress = ReadLine();
                WriteLine();
                WriteLine("The Customer's Phone Number in this format (###)###-### :");
                String CPhoneNumber = ReadLine();
            }


            else if (Info == 2)
            {
                WriteLine("The Product information");
                WriteLine();
                WriteLine("The Product ID:");
                String PID = ReadLine();
                WriteLine();
                WriteLine("The Product Name:");
                String PName = ReadLine();
                WriteLine();
                WriteLine("The Product Category:");
                String PCategory = ReadLine();
                WriteLine();
                WriteLine("The Product Description:");
                String PDescription = ReadLine();
                WriteLine();
                WriteLine("The Price(don't write the $ sgin):");
                String PPrice = ReadLine();
            }


            else if (Info == 3)
            {

                double first;
                WriteLine("What is the first Product?");
                String Name1 = ReadLine();
                WriteLine("How much is the first product?");
                first = ToDouble(ReadLine());

                double second;
                WriteLine("What is the second Product?");
                String Name2 = ReadLine();
                WriteLine("How much is the second product?");
                second = ToDouble(ReadLine());

                WriteLine("The total : {2}", first, second, first + second);

            }


            else if (Info == 4)
            {

                WriteLine("Enter CustomerID:");
                string Customer = ReadLine();
                bool authenticated = false;

                foreach (var customer in customers)
                {
                    if (customer.ID == Customer)
                    {
                        WriteLine($"{customer.ID}");
                        WriteLine($"{customer.Name}");
                        WriteLine($"{customer.Phone}");
                        WriteLine($"{customer.Email}");
                        WriteLine($"{customer.Address}");
                        authenticated = true;
                    }
                }

                if (!authenticated)
                {
                    WriteLine("You have entered incorrect CustomerID. Please try again.");

                }
            }
            else if(Info == 5)
            {
                WriteLine("Enter CustomerName:");
                string Customer = ReadLine();
                bool authenticated = false;

                foreach (var customer in customers)
                {
                    if (customer.Name == Customer)
                    {
                        WriteLine($"{customer.ID}");
                        WriteLine($"{customer.Name}");
                        WriteLine($"{customer.Phone}");
                        WriteLine($"{customer.Email}");
                        WriteLine($"{customer.Address}");
                        authenticated = true;
                    }
                }

                if (!authenticated)
                {
                    WriteLine("You have entered incorrect CustomerID. Please try again.");

                }
            }

            else if(Info == 6)
            {

                    WriteLine("Enter ProductID:");
                    string Product = ReadLine();
                    bool authenticated = false;

                    foreach (var product in Products)
                    {
                        if (product.ID == Product)
                        {
                        WriteLine($"{product.ID}");
                        WriteLine($"{product.Name}");
                        WriteLine($"{product.Category}");
                        WriteLine($"{product.Description}");
                        WriteLine($"{product.Price}");
                            authenticated = true;
                        }
                    }

                    if (!authenticated)
                    {
                        WriteLine("You have entered incorrect ProductID. Please try again.");

                    }

            }

        }
    }
}
