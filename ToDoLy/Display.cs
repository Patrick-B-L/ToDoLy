using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    class Display
    {
        // Welcome the user
        public static void Greeting()
        {
            Console.WriteLine("Welcome to ToDoLy");
        }

        // Show status of the tasks
        public static void ShowStatus()
        {
            Console.WriteLine($"You have {ListManager.GetCountTotalNumberOfTasksToDo()} tasks todo and {ListManager.GetCountTotalNumberOfTasksDone()} tasks are done!");
        }
        // Show main menu 
        public static void MainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("(1): Show Task List (by date or project)");
            Console.WriteLine("(2): Add New Task");
            Console.WriteLine("(3): Edit Task (update, mark as done, remove)");
            Console.WriteLine("(4): Save and Quit");
            Console.WriteLine("Enter Option");
        }

        // Show Task List menu
        public static void SortTaskListMenu()
        {
            Console.WriteLine("Show Task List Sorted By:");
            Console.WriteLine("(1): Due Date");
            Console.WriteLine("(2): Project");
            Console.WriteLine("(3): Task Number (The Latest Added Task Is Shown Last)");
            Console.WriteLine("Enter option:");
        }

        // Shows the user a menu to select status of the task
        public static void SelectTaskStatusMenu()
        {
            Console.WriteLine("Set Task Status to:");
            Console.WriteLine("(1): \"Pending\"");
            Console.WriteLine("(2): \"Scheduled\"");
            Console.WriteLine("(3): \"In Progress\"");
            Console.WriteLine("(4): \"Completed\"");
            Console.WriteLine("Enter option:");
        }

        public static void SaveMenu()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("(1): Save");
            Console.WriteLine("(2): Do Not Save");
            Console.WriteLine("Enter option:");
        }

        // Menu for selecting task
        public static void SelectTaskToEditMenu()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Edit Task:");
            Console.WriteLine("Enter The Task Number of the Task To Edit:");
        }

        // Menu for Editing Task
        public static void EditTaskMenu()
        {
            Console.WriteLine("Edit Task:");
            Console.WriteLine("(1): Update");
            Console.WriteLine("(2): Mark as done");
            Console.WriteLine("(3): Remove");
            Console.WriteLine("Enter Option");
        }
    }
}
