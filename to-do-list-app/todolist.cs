using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ToDoList 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to To Do List APP");
            List<string> list = new List<string>();
            string option="";

            while (option != "e"){
                Console.WriteLine("Please select an option.");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task to the list.");
                Console.WriteLine("Enter 3 to view to the list.");
                Console.WriteLine("Enter e to exit the APP.");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please enter the name of the task to add to the list.");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("Task added to the list.");
                        break;
                    case "2":
                        for (int i = 0; i < list.Count; i++) 
                        {
                            Console.WriteLine(i + ": " + list[i]);
                        }
                        Console.WriteLine("Please enter the number of the task to remove from the list");
                        int numberTask = Convert.ToInt32(Console.ReadLine());
                        list.RemoveAt(numberTask);
                        Console.WriteLine("Task removed from the list");
                        break;
                    case "3":
                        for (int i = 0; i < list.Count; i++) 
                        {
                            Console.WriteLine(i + ": " + list[i]);
                        }
                        Console.WriteLine("Press any key to go back to the menu.");
                        Console.ReadKey();
                        break;
                }               
            }
            Console.WriteLine("Thank you for using To Do List APP. Press any key to exit the APP");
            Console.ReadKey();
        }
    }
}