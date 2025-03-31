using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // The InputValidator class is responsible for validating user input and ensuring correctness
    class InputValidator
    {
        // Validates the user's menu option input based on the number of available options
        public static int ValidateOption(int numberOfOptions)
        {
            while (true)
            {
                try
                {
                    // Attempt to parse the user's input and ensure it's within the valid range
                    if (int.TryParse(Console.ReadLine().Trim(), out int option) && option > 0 && option <= numberOfOptions)
                    {
                        return option; // Return the validated option
                    }
                    else
                    {
                        // Throw an exception if the input is invalid
                        throw new ArgumentException("Invalid option. Please try again");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Display error message in red for clarity
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        // Retrieves the user's selected option from the Main Menu
        public static int GetOptionMainMenu()
        {
            return InputValidator.ValidateOption(4); // Main menu has 4 options
        }

        // Retrieves the user's selected option from the Task List Sorting Menu
        public static int GetOptionSortTaskListMenu()
        {
            return InputValidator.ValidateOption(3); // Sorting menu has 3 options
        }

        // Retrieves the user's selected option for setting task status
        public static int GetOptionSelectTaskStausMenu()
        {
            return InputValidator.ValidateOption(4); // Task status menu has 4 options
        }

        // Retrieves the user's choice from the Save Menu
        public static int GetOptionSaveMenu()
        {
            return InputValidator.ValidateOption(2); // Save menu has 2 options
        }

        // Retrieves the user's selected task for editing by its index
        public static int GetOptionSelectTaskToEditMenu()
        {
            // Uses the number of tasks in the list to determine valid range
            return InputValidator.ValidateOption(ListManager.toDoTaskList.Count());
        }

        // Retrieves the user's selected option from the Task Editing Menu
        public static int GetOptionEditTaskMenu()
        {
            return InputValidator.ValidateOption(3); // Edit task menu has 3 options
        }

        // Validates and retrieves a non-empty title for a new or updated task
        public static string GetValidTitle()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine().Trim(); // Read and trim user input
                    if (!string.IsNullOrEmpty(title))
                    {
                        return title; // Return the validated title
                    }
                    else
                    {
                        // Throw an exception for empty titles
                        throw new ArgumentException("The title can't be empty. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Display error message in red for clarity
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        // Validates and retrieves a correctly formatted due date for a new or updated task
        public static DateOnly GetValidDueDate()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Due Date (In the Format: YYYY-MM-DD): ");
                    if (DateOnly.TryParse(Console.ReadLine().Trim(), out DateOnly dueDate))
                    {
                        return dueDate; // Return the validated due date
                    }
                    else
                    {
                        // Throw an exception for invalid date formats
                        throw new ArgumentException("Invalid Due Date. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Display error message in red for clarity
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        // Allows the user to select and retrieve a valid task status from predefined options
        public static string GetValidStatus()
        {
            Display.SelectTaskStatusMenu(); // Show status selection menu
            switch (InputValidator.GetOptionSelectTaskStausMenu())
            {
                case 1:
                    return "Pending"; // Status: Pending
                case 2:
                    return "Scheduled"; // Status: Scheduled
                case 3:
                    return "In Process"; // Status: In Process
                default:
                    return "Done"; // Status: Done
            }
        }

        // Validates and retrieves a non-empty project name associated with a task
        public static string GetValidProject()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter The Name of the Project Associated with the Task: ");
                    string project = Console.ReadLine().Trim(); // Read and trim user input
                    if (!string.IsNullOrEmpty(project))
                    {
                        return project; // Return the validated project name
                    }
                    else
                    {
                        // Throw an exception for empty project names
                        throw new ArgumentException("The name of the project can't be empty. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Display error message in red for clarity
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
    }
}
