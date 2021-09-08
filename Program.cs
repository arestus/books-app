using DatabaseFirstApproch.Models;
using System;
using System.Collections.Generic;

namespace DatabaseFirstApproch
{
    class Program
    {
        pubsContext pubs;
        public Program()
        {
            pubs = new pubsContext();
        }
        void PrintAllAuthors()
        {
            Console.WriteLine("Please enter the author first name");
            string name = Console.ReadLine();
            string auid = "";
            List<string> titleids = new List<string>();
            foreach (var item in pubs.Authors)
            {
                if (name == item.AuFname)
                {
                    auid = item.AuId;
                }
            }
            if (auid.Length > 0)
            {
                try
                {
                    foreach (var id in pubs.Titleauthors)
                    {
                        if (auid == id.AuId)
                        {
                            titleids.Add(id.TitleId);
                        }
                    }
                    if (titleids.Count > 0)
                    {
                        Console.WriteLine("The Books Published by Author " + name);
                        Console.WriteLine("-------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Author yet to start");
                    }
                    foreach (var title in pubs.Titles)
                    {
                        foreach (string id in titleids)
                        {
                            if (id == title.TitleId)
                            {
                                Console.WriteLine(title.Title1);
                            }
                        }
                    }
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Sales Done by Each Book\n");
                    for (int i = 0; i < titleids.Count; i++)
                    {
                        var title = pubs.Titles.Find(titleids[i]);
                        Console.WriteLine("Title Id - " + title.TitleId);
                        Console.WriteLine("Book Name - " + title.Title1);
                        Console.WriteLine("Total Sales - " + title.YtdSales);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine($"There is no such Author name '{name}'");
            }
            
        }
        void PrintAuthorAndBookDetails()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Get Books by Author");
                Console.WriteLine("0. Exit");
                Console.WriteLine("----------------------");
                Console.WriteLine("Please select a option");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("please enter 1 or 0");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                switch (choice)
                {
                    case 1:
                        PrintAllAuthors();
                        break;
                    case 0:
                        Console.WriteLine("You entered exit!!");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (choice != 0);
        }
        static void Main(string[] args)
        {
            new Program().PrintAuthorAndBookDetails();
            Console.ReadKey();
        }
    }
}
