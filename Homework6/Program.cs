using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6
{
    class Program
    {
        public static List<String> list;
        
        static void Main(string[] args)
        {
            list = GetStrings();

            string command = "";

            while (command != "1")
            {
                PrintList();
                Console.WriteLine("Enter 1 to exit. You do not want to add anything. Shopinglist is done.");
                Console.WriteLine("Enter 2 to add something. You want to your list.");
                Console.WriteLine("Enter 3 to remove something. You want to remove something from your list.");
                
                command= Console.ReadLine();
                if (command=="1")
                {
                    break;
                }
                else if(command=="2")
                {
                    NewItem();
                }
                else if (command=="3")
                {
                    RemoveItem();
                }
                else
                {
                    Console.WriteLine("This command does not exist!!!");
                }
                
            }

            Console.WriteLine("Shop wisely!!!");
            Console.ReadLine();

        }

        public static List<string> GetStrings ()
        {
            Console.WriteLine("Hello! Insert goods you would like to buy:");
            string goods = Console.ReadLine();

            List<string> products = goods.Split(", ").ToList();
            return products;
        }
        
        public static void PrintList ()
        {
            Console.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Item {i+1} {list[i]}");
            }
        }

        public static void NewItem()
        {
            Console.WriteLine("Enter the item you would like to add: ");
            string newItem = Console.ReadLine();
            list.Add(newItem);
        }

        public static void RemoveItem()
        {
            Console.WriteLine($"Enter the item number (1-{list.Count}) you would like to remove: ");
            string removeItem = Console.ReadLine();
            int answer = Int32.Parse(removeItem);
            list.RemoveAt(answer-1);
            
        }
        
        
    }
    
}