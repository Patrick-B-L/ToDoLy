using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Methods for managing tasks in the application
    class ToDoTaskManager
    {
        // Method for adding a new task to the list
        public static void AddNewToDoTask()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add New Task");
            Console.ResetColor();

            // Prompt user for task details
            string title = InputValidator.GetValidTitle(); // Get the task title
            DateOnly dueDate = InputValidator.GetValidDueDate(); // Get the due date
            string status = InputValidator.GetValidStatus(); // Get the task status
            string project = InputValidator.GetValidProject(); // Get the project name

            // Display the entered details for user confirmation
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have entered the following:");
            Console.ResetColor();

            Console.WriteLine($"Title: \t\t {title}");
            Console.WriteLine($"Due date: \t {dueDate}");
            Console.WriteLine($"Status: \t {status}");
            Console.WriteLine($"Project: \t {project}");

            // Present Save Menu to confirm task creation
            Display.SaveMenu();

            // Handle user's choice from Save Menu
            switch (InputValidator.GetOptionSaveMenu())
            {
                case 1:
                    {
                        // Add task to the task list
                        ListManager.AddTasktoDoTaskList(new ToDoTask(title, dueDate, status, project));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("New Task Saved!");
                        Console.ResetColor();
                        break;
                    }
                case 2:
                    {
                        // Notify user that the task was not saved
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("New Task Is Not Saved!");
                        Console.ResetColor();
                        break;
                    }
            }
        }

        // Method for editing an existing task in the list
        public static void EditToDoTask()
        {
            // Display menu for selecting a task to edit
            Display.SelectTaskToEditMenu();

            // Get the index of the task to be edited
            int selectedTaskToEdit = (InputValidator.GetOptionSelectTaskToEditMenu() - 1);

            // Display the details of the selected task for editing
            Console.WriteLine("\n---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Selected Task For Editing:");
            Console.ResetColor();

            Console.WriteLine((selectedTaskToEdit + 1).ToString().PadRight(20)
                + ListManager.toDoTaskList[selectedTaskToEdit].Title.PadRight(30)
                + ListManager.toDoTaskList[selectedTaskToEdit].DueDate.ToString().PadRight(20)
                + ListManager.toDoTaskList[selectedTaskToEdit].Status.PadRight(20)
                + ListManager.toDoTaskList[selectedTaskToEdit].Project);

            // Display the edit menu with available options
            Display.EditTaskMenu();

            // Get user's choice from the edit menu
            int optionEditTaskMenu = InputValidator.GetOptionEditTaskMenu();

            switch (optionEditTaskMenu)
            {
                case 1:
                    // Update the selected task's details
                    Console.WriteLine("\n---------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Update Task");
                    Console.ResetColor();

                    // Prompt user for updated task details
                    string title = InputValidator.GetValidTitle();
                    DateOnly dueDate = InputValidator.GetValidDueDate();
                    string status = InputValidator.GetValidStatus();
                    string project = InputValidator.GetValidProject();

                    // Display the updated details for confirmation
                    Console.WriteLine("\n---------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have entered the following:");
                    Console.ResetColor();

                    Console.WriteLine($"Title: \t\t {title}");
                    Console.WriteLine($"Due date: \t {dueDate}");
                    Console.WriteLine($"Status: \t {status}");
                    Console.WriteLine($"Project: \t {project}");

                    // Show Save Menu to confirm updates
                    Display.SaveMenu();

                    // Handle user's choice to save or discard updates
                    switch (InputValidator.GetOptionSaveMenu())
                    {
                        case 1:
                            {
                                ListManager.toDoTaskList[selectedTaskToEdit] = new ToDoTask(title, dueDate, status, project);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Task Updates Saved!");
                                Console.ResetColor();
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Task Updates Are Not Saved!");
                                Console.ResetColor();
                                break;
                            }
                    }
                    break;

                case 2:
                    // Mark the selected task as "Done"
                    Console.WriteLine("\n---------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Mark As Done");
                    Console.ResetColor();

                    Console.WriteLine("The Task Is Marked As Done");

                    // Show Save Menu to confirm the status change
                    Display.SaveMenu();

                    // Handle user's choice to save or discard the status change
                    switch (InputValidator.GetOptionSaveMenu())
                    {
                        case 1:
                            {
                                ListManager.toDoTaskList[selectedTaskToEdit].Status = "Done";
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Task Updates Saved!");
                                Console.ResetColor();
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Task Updates Are Not Saved!");
                                Console.ResetColor();
                                break;
                            }
                    }
                    break;

                case 3:
                    // Remove the selected task from the list
                    Console.WriteLine("\n---------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Remove Task");
                    Console.ResetColor();

                    Console.WriteLine("The Task Is Removed");

                    // Show Save Menu to confirm the removal
                    Display.SaveMenu();

                    // Handle user's choice to save or discard the removal
                    switch (InputValidator.GetOptionSaveMenu())
                    {
                        case 1:
                            {
                                ListManager.toDoTaskList.RemoveAt(selectedTaskToEdit);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Task Updates Saved!");
                                Console.ResetColor();
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Task Updates Are Not Saved!");
                                Console.ResetColor();
                                break;
                            }
                    }
                    break;
            }
        }
    }
}
