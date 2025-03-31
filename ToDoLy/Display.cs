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
            Console.WriteLine("Welcome to ToDoLy");
        }

        // Show status of the tasks
        public static void ShowStatus()
        {
            // Show the total number of tasks to do and the total number of completed tasks
            Console.WriteLine($"You have {ListManager.GetCountTotalNumberOfTasksToDo()} tasks todo and {ListManager.GetCountTotalNumberOfTasksDone()} tasks are done!");
        }
        // Present the main menu with available actions to the user
        public static void MainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("(1): Show Task List (by date or project)");
            Console.WriteLine("(2): Add New Task");
            Console.WriteLine("(3): Edit Task (update, mark as done, remove)");
            Console.WriteLine("(4): Save and Quit");
            Console.WriteLine("Enter Option");
        }

        // Present sorting options for organizing the task list
        public static void SortTaskListMenu()
        {
            Console.WriteLine("Show Task List Sorted By:");
            Console.WriteLine("(1): Due Date");
            Console.WriteLine("(2): Project");
            Console.WriteLine("(3): Task Number (The Latest Added Task Is Shown Last)");
            Console.WriteLine("Enter option:");
        }

        // Present options for setting a task's status
        public static void SelectTaskStatusMenu()
        {
            Console.WriteLine("Set Task Status to:");
            Console.WriteLine("(1): \"Pending\"");
            Console.WriteLine("(2): \"Scheduled\"");
            Console.WriteLine("(3): \"In Progress\"");
            Console.WriteLine("(4): \"Completed\"");
            Console.WriteLine("Enter option:");
        }
        // Method to display the save menu with options to save or discard changes
        public static void SaveMenu()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("(1): Save Changes");
            Console.WriteLine("(2): Discard Changes");
            Console.WriteLine("Enter option:");
        }

        // Display an input prompt to specify the task to edit
        public static void SelectTaskToEditMenu()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Edit Task:");
            Console.WriteLine("Enter The Task Number of the Task To Edit:");
        }

        // Present options for editing a selected task
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
