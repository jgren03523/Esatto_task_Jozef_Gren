using System;
using System.Collections.Generic;
using System.IO;


namespace Esatto_zad_Jozef_Gren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to customer data app ");
            Console.WriteLine("--------------------------------------------------");

            List<Customer> Customers = new List<Customer>();
            List<string> CustomersList = new List<string>();

            List<string> MenuList = new List<string>
            {

            "Please press 1 to add new customer",
            "Please press 2 to edit already existing customer",
            "Please press 3 to list all customers ",
            "Please press 4 to delete already existing customer",
            "Please press any other key to leave application",
            "--------------------------------------------------"
            };
            bool IsDone = false;
            string Key;
                    do
                    {
                        foreach (string listElement in MenuList) Console.WriteLine(listElement);

                        Console.WriteLine("Please choose what you want to do ");

                        Key = Console.ReadLine();
                        IsDone = false;
                        string Name;
                        string Address;
                        string Vat;
                        switch (Key)
                        {


                            case "1":
                                Console.WriteLine("Please enter the name: ");

                                Name = Console.ReadLine();
                                Console.WriteLine("Please enter customer addres: ");
                                Address = Console.ReadLine();
                                Console.WriteLine("Please enter the VAT number: ");
                                Vat = Console.ReadLine();
                                Customers.Add(new Customer(Name, Address, Vat));

                                Console.WriteLine("user added");

                                break;

                            case "2":
                                Console.WriteLine("Search customer you wanna edit - Enter 1 - by name - Enter 2 - by address - 3 by Vat number");
                                string Key2;
                                Key2 = Console.ReadLine();

                                switch (Key2)
                                {
                                    case "1":
                                        Console.WriteLine("please enter searched name: ");
                                        string SearchedName = Console.ReadLine();
                                        foreach (Customer customer in Customers)
                                        {
                                            if (customer.Name == SearchedName)
                                            {
                                                Console.WriteLine("Do you want to change customer name? Enter 1 if yes | any other key if no:");
                                                string YesNo = Console.ReadLine();


                                                if (YesNo == "1")
                                                {
                                                    Console.WriteLine("Please write new name: ");
                                                    string NewName = Console.ReadLine();
                                                    customer.Name = NewName;
                                                }
                                                Console.WriteLine("Do you want to change customer address? Enter 1 if yes | any other key if no:");
                                                YesNo = Console.ReadLine();
                                                if (YesNo == "1")
                                                {


                                                    Console.WriteLine("Please write new address: ");
                                                    string NewAddress = Console.ReadLine();
                                                    customer.Address = NewAddress;

                                                }
                                                Console.WriteLine("Do you want to change customer VAT number? Enter 1 if yes | any other key if no:");
                                                YesNo = Console.ReadLine();
                                                if (YesNo == "1")
                                                {
                                                    Console.WriteLine("Please write new VAT number: ");
                                                    string NewVat = Console.ReadLine();
                                                    customer.Vat = NewVat;
                                                }



                                            }
                                            else Console.WriteLine("there is no such customer");
                                        }
                                        break;
                                    case "2":
                                        Console.WriteLine("please enter searched address: ");
                                        string SearchedAddress = Console.ReadLine();
                                        foreach (Customer customer in Customers)
                                        {
                                            if (customer.Address == SearchedAddress)
                                            {
                                                Console.WriteLine("Do you want to change customer name? Enter 1 if yes | any other key if no:");
                                                string YesNo = Console.ReadLine();


                                                if (YesNo == "1")
                                                {
                                                    Console.WriteLine("Please write new name: ");
                                                    string NewName = Console.ReadLine();
                                                    customer.Name = NewName;
                                                }
                                                Console.WriteLine("Do you want to change customer address? Enter 1 if yes | any other key if no:");
                                                YesNo = Console.ReadLine();
                                                if (YesNo == "1")
                                                {


                                                    Console.WriteLine("Please write new address: ");
                                                    string NewAddress = Console.ReadLine();
                                                    customer.Address = NewAddress;

                                                }
                                                Console.WriteLine("Do you want to change customer VAT number? Enter 1 if yes | any other key if no:");
                                                YesNo = Console.ReadLine();
                                                if (YesNo == "1")
                                                {
                                                    Console.WriteLine("Please write new VAT number: ");
                                                    string NewVat = Console.ReadLine();
                                                    customer.Vat = NewVat;
                                                }



                                            }

                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("please enter searched VAT number: ");
                                        string SearchedVat = Console.ReadLine();
                                        foreach (Customer customer in Customers)
                                        {
                                            if (customer.Vat == SearchedVat)
                                            {
                                                Console.WriteLine("Do you want to change customer name? Enter 1 if yes | any other key if no:");
                                                string YesNo = Console.ReadLine();


                                                if (YesNo == "1")
                                                {
                                                    Console.WriteLine("Please write new name: ");
                                                    string NewName = Console.ReadLine();
                                                    customer.Name = NewName;
                                                }
                                                Console.WriteLine("Do you want to change customer address? Enter 1 if yes | any other key if no:");
                                                YesNo = Console.ReadLine();
                                                if (YesNo == "1")
                                                {


                                                    Console.WriteLine("Please write new address: ");
                                                    string NewAddress = Console.ReadLine();
                                                    customer.Address = NewAddress;

                                                }
                                                Console.WriteLine("Do you want to change customer VAT number? Enter 1 if yes | any other key if no:");
                                                YesNo = Console.ReadLine();
                                                if (YesNo == "1")
                                                {
                                                    Console.WriteLine("Please write new VAT number: ");
                                                    string NewVat = Console.ReadLine();
                                                    customer.Vat = NewVat;
                                                }



                                            }


                                        }
                                        Console.WriteLine("There is no such user! ");
                                        break;

                                    default:
                                        Console.WriteLine("There is no such user! ");
                                        break;
                                }
                                break;
                            case "3":

                                Console.WriteLine("all customers: ");
                                foreach (Customer cust in Customers)
                                {
                                    Console.WriteLine(cust.ToString());


                                }
                                break;

                            case "4":

                                Console.WriteLine("Search customer you wanna delete - Enter 1 - by name - Enter 2 - by address - 3 by Vat number");

                                string Key3;
                                Key3 = Console.ReadLine();
                                switch (Key3)
                                {
                                    case "1":
                                        Console.WriteLine("please enter searched name: ");
                                        string SearchedName = Console.ReadLine();

                                        Customers.Remove(Customers.Find(customer => customer.Name == SearchedName));

                                        break;
                                    case "2":
                                        Console.WriteLine("please enter searched address: ");
                                        string SearchedAddress = Console.ReadLine();
                                        Customers.Remove(Customers.Find(customer => customer.Address == SearchedAddress));

                                        break;
                                    case "3":
                                        Console.WriteLine("please enter searched VAT number: ");
                                        string SearchedVat = Console.ReadLine();

                                        Customers.Remove(Customers.Find(customer => customer.Vat == SearchedVat));



                                        break;

                                    default:

                                        break;
                                }

                                break;


                            default:
                                Console.WriteLine("Goodbye!");
                                IsDone = true;
                                break;

                        }
                        if (!IsDone)
                        {
                            Console.WriteLine("U wish to continue? - press 1 to go back to menu or press any other key to leave program");

                            Key = Console.ReadLine();

                        }
                    } while ((Key == "1") && (!IsDone));



        }
    }
    
}
    

