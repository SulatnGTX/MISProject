using System;
using static System.Console;
using static System.Convert;
using ProjectMIS310;

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

            string[] ProductID = new string[5];
            ProductID[0] = "0001";
            ProductID[1] = "0002";
            ProductID[2] = "0003";
            ProductID[3] = "0004";
            ProductID[4] = "0005";


            WriteLine("Chose from the options:");
            WriteLine();
            WriteLine("New Cosumter = 1, New Product = 2, Order/Sales = 3, Search Csutomer ID = 4, Search Csutomer Name =5, Search Product ID = 5, Search Product Name = 6, Calculate total sales by product = 7, Calculate total sales for customer by entering name =8");
            WriteLine();
            WriteLine("Enter your option:");
            int Info = ToInt32(ReadLine());

            if (Info == 1)
            {
                WriteLine("The Customer information");
                WriteLine();
                WriteLine("The Customer's ID:");
                int CID = ToInt32(ReadLine());
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
                int PID = ToInt32(ReadLine());
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
                int PPrice = ToInt32(ReadLine());
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

                foreach (string CI in CustomerID)
                {
                    if (Customer == CI)
                    {

                        authenticated = true;
                    }
                }

                if (authenticated)
                {
                    string Name = string.Empty;
                    WriteLine("Enter Customer Name:");
                    Name = ReadLine();

                    if (Name != string.Empty)
                    {
                        WriteLine($"CustomerID: {Name}. You are successfully authenticated by the system.");
                    }

                }

                else
                {
                    WriteLine("You have entered incorrect CustomerID. Please try again.");
                }
            }

        }
    }
}
