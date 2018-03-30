using System;
using static System.Console;
using static System.Convert;

namespace Project1_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Chose from the options:");
            WriteLine();
            WriteLine("New Cosumter = 1, New Product = 2, Order/Sales = 3, Search Csutomer ID = 4, Search Csutomer Name =5, Search Product ID = 5, Search Product Name = 6, Calculate total sales by product = 7, Calculate total sales for customer by entering name =8");
            WriteLine();
            WriteLine("Enter your option:");
            int Info = ToInt32(ReadLine());

            if(Info == 1)
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
            else if(Info == 2)
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
            else if(Info == 3)
            {
                WriteLine("Enter the Customer ID:");
                int CustomerID = ToInt32(ReadLine());
                WriteLine();
                WriteLine("Enter the Product ID:");
                int ProductID = ToInt32(ReadLine());
                WriteLine();
            }

        }
    }
}
