using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Validates and returns user input
    class InputValidator
    {

        public static int ValidateOption(int numberOfOptions)
        {
            while (true)
            {
                try
                {
                    if (int.TryParse(Console.ReadLine().Trim(), out int option) && option > 0 && option <= numberOfOptions)
                    {
                        return option;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid option. Please try again");
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
        public static int GetOptionMainMenu()
        {
            return InputValidator.ValidateOption(4);
        }

        public static int GetOptionSortTaskListMenu()
        {
            return InputValidator.ValidateOption(3);
        }

        public static int GetOptionSelectTaskStausMenu()
        {
            return InputValidator.ValidateOption(4);
        }

        public static int GetOptionSaveMenu()
        {
            return InputValidator.ValidateOption(2);
        }

        public static int GetOptionSelectTaskToEditMenu()
        {
            return InputValidator.ValidateOption(ListManager.toDoTaskList.Count());
        }

        public static int GetOptionEditTaskMenu()
        {
            return InputValidator.ValidateOption(3);
        }



        public static string GetValidTitle()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(title))
                    {
                        return title;
                    }
                    else
                    {
                        throw new ArgumentException("The title can't be empty. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }


        public static DateOnly GetValidDueDate()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Due Date (In the Format: YYYY-MM-DD): ");
                    if (DateOnly.TryParse(Console.ReadLine().Trim(), out DateOnly dueDate))
                    {
                        return dueDate;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Due Date. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }


        public static string GetValidStatus()
        {
            Display.SelectTaskStatusMenu();
            switch (InputValidator.GetOptionSelectTaskStausMenu())
            {
                case 1:
                    return "Pending";
                case 2:
                    return "Scheduled";
                case 3:
                    return "In Process";
                default:
                    return "Done";
            }
        }


        public static string GetValidProject()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter The Name of the Project Associated with the Task: ");
                    string project = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(project))
                    {
                        return project;
                    }
                    else
                    {
                        throw new ArgumentException("The name of the project can't be empty. Please try again!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
    }
}
