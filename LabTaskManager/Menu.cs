using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskManager
{
    class Menu
    {
        private const string viewList = "1";
        private const string addTask = "2";
        private const string removeTask = "3";
        private const string quit = "Q";
        //switch
        //string[] taskList = new string[5];        confusion, maybe use loop to update null values
        string[] taskList = { "1. Dishes", "2. Bills", "3. Groceries", "4. Vaccuum" };  //interpolation and indexing
        //array of tasks, index or foreach

        public void Run()
        {
            bool running = true;

            while (running)
            {
                string choice = BuildMenu().ToUpper();

                switch (choice)
                {
                    case viewList:
                        ViewList();
                        break;
                    case addTask:
                        AddTask();
                        break;
                    case removeTask:
                        RemoveTask();
                        break;
                    case quit:
                        Console.WriteLine("quit");
                        running = false;
                        break;
                    default:
                        HandleUnknownInput();
                        break;
                }

            }
        }

        private void ViewList()
        {
            Console.Clear();
            Console.WriteLine("Task List");
            Console.WriteLine("-------------");
            //need a loop here on what to write on list... missing something I feel, oh null parts of array
            for (int i = 0; i < taskList.Length; i++)
            {
                Console.WriteLine($"{taskList[i]}");
            }
            Console.WriteLine("-------------");
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        private void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Enter Task: ");
            string newTask = Console.ReadLine();

            while (string.IsNullOrEmpty(newTask))
            {
                Console.WriteLine("Enter Task: ");
                newTask = Console.ReadLine();
            }
            //add to array

            Console.WriteLine("It's on the list!");
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
            //return array
        }

        private void RemoveTask()
        {
            Console.Clear();
            Console.WriteLine("Task List");
            Console.WriteLine("-------------");
            for (int i = 0; i < taskList.Length; i++)
            {
                Console.WriteLine($"{taskList[i]}");
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Enter item to be removed: ");
            //use string.IsNullOrEmpty()
            //remove from array
            Console.WriteLine("has been removed");  //interpolation
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
            //return array
        }

        private void HandleUnknownInput()
        {
            Console.WriteLine("Wrong");         //adapt to request valid input
        }

        private string BuildMenu()
        {
        Console.WriteLine("Menu List");
        Console.WriteLine("-------------");
        Console.WriteLine($"{viewList}: View List");
        Console.WriteLine($"{addTask}: Add a task");
        Console.WriteLine($"{removeTask}: Remove a task\n");
        Console.WriteLine($"{quit}: Press Q to quit\n");
        Console.WriteLine("-------------");
        Console.Write("Enter Choice: ");
        return Console.ReadLine();
        }
    }
}
