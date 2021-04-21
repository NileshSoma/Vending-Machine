using System;
using System.Collections.Generic;
using System.Linq;

namespace Vending_Machine
{

    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double productCost { get; set; }

        public List<Product> listprodcut { get; set; }

        public List<Product> productList()
        {
            List<Product> prodcutlist = new List<Product>
            {
                new Product{ productID = 1, productName="Coce",productCost =10.5 },
                new Product{ productID = 2, productName="Pizza",productCost =11.5 },
            };
            return prodcutlist;

        }




        class Program
        {



            public static int AcceptCoins(int ammount)
            {
                Product objProduct = new Product();
                string userChoice = string.Empty;
                do
                {
                    int totalCost = 0;
                start:
                    Console.WriteLine("please enter ur requrte product");
                    string pdocutname = Console.ReadLine();
                    objProduct.listprodcut = objProduct.productList();
                    objProduct.listprodcut.Where(x => x.productName == pdocutname);
                    switch (pdocutname)
                    {
                        case "PEPSi":
                            totalCost = ammount - 5;
                            break;
                        case "Coce":
                            totalCost = ammount - 10;
                            break;
                        default:
                            Console.WriteLine("your choice is invalid", ammount);
                            goto start;
                    }
                Decide:
                    do
                    {
                        Console.WriteLine("Do you want to buy another product");
                        userChoice = Console.ReadLine();
                        switch (userChoice.ToUpper())
                        {
                            case "YES":
                                goto start;
                            case "NO":
                                break;
                            default:
                                Console.WriteLine("your choice is invalid", userChoice);
                                goto Decide;
                        }
                    }
                    while (userChoice != "YES" && userChoice != "No");
                }
                while (userChoice.ToUpper() != "No");
            }

            static void Main(string[] args)
            {
                Console.WriteLine("enter the Ammunt");
                int ammount = Convert.ToInt32(Console.ReadLine());
                ammount = Program.AcceptCoins(ammount);
            }
        }
    }
