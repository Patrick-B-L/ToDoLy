using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // The Display class handles all user interface components, such as menus and status messages
    class Display
    {
        // Method to welcome the user to the application
        public static void Greeting()
        {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to ToDoLy");
            Console.ResetColor();
        }

        // Show status of the tasks
        public static void ShowStatus()
        {
            // Show the total number of tasks to do and the total number of completed tasks
            Console.Write("\nYou have ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{ListManager.GetCountTotalNumberOfTasksToDo()} ");
            Console.ResetColor();
            Console.Write("tasks todo and ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{ListManager.GetCountTotalNumberOfTasksDone()} ");
            Console.ResetColor();
            Console.Write("tasks are done!");
        }

        // Present the main menu with available actions to the user
        public static void MainMenu()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Main Menu:");
            Console.ResetColor();
            Console.WriteLine("(1): Show Task List (by due date, project or added)");
            Console.WriteLine("(2): Add New Task");
            Console.WriteLine("(3): Edit Task (update, mark as done, remove)");
            Console.WriteLine("(4): Save and Quit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Option");
            Console.ResetColor();
        }

        // Present sorting options for organizing the task list
        public static void SortTaskListMenu()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Show Task List Ordered By:");
            Console.ResetColor();
            Console.WriteLine("(1): Due Date");
            Console.WriteLine("(2): Project");
            Console.WriteLine("(3): Added (The Most Recently Added Task Is Shown Last))");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter option:");
            Console.ResetColor();
        }

        // Present options for setting a task's status
        public static void SelectTaskStatusMenu()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Set Task Status to:");
            Console.ResetColor();
            Console.WriteLine("(1): \"Pending\"");
            Console.WriteLine("(2): \"Scheduled\"");
            Console.WriteLine("(3): \"In Progress\"");
            Console.WriteLine("(4): \"Completed\"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter option:");
            Console.ResetColor();
        }
        // Method to display the save menu with options to save or discard changes
        public static void SaveMenu()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.WriteLine("(1): Save Changes");
            Console.WriteLine("(2): Discard Changes");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter option:");
            Console.ResetColor();
        }

        // Display an input prompt to specify the task to edit
        public static void SelectTaskToEditMenu()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Edit Task:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter The Task Number of the Task To Edit:");
            Console.ResetColor();
        }

        // Present options for editing a selected task
        public static void EditTaskMenu()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Edit Task:");
            Console.ResetColor();
            Console.WriteLine("(1): Update");
            Console.WriteLine("(2): Mark as done");
            Console.WriteLine("(3): Remove");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Option");
            Console.ResetColor();
        }
    }
}
