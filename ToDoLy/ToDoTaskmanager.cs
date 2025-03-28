using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Methods for managing ToDoTask
    class ToDoTaskManager
    {
        // Method for adding a new task
        public static void AddNewToDoTask()
        {
            Console.WriteLine("Add New Task");

            string title = InputValidator.GetValidTitle();
            DateOnly dueDate = InputValidator.GetValidDueDate();
            string status = InputValidator.GetValidStatus();
            string project = InputValidator.GetValidProject();

            Console.WriteLine("You have entered the following:");
            Console.WriteLine($"Title: \t\t {title}");
            Console.WriteLine($"Due date: \t {dueDate}");
            Console.WriteLine($"Status: \t {status}");
            Console.WriteLine($"Project: \t {project}");

            Display.SaveMenu();

            switch (InputValidator.GetOptionSaveMenu())
            {
                case 1:
                    {
                        ListManager.AddTasktoDoTaskList(new ToDoTask(title, dueDate, status, project));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("New Task Saved!");
                        Console.ResetColor();
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" New Task Is Not Saved!");
                        Console.ResetColor();
                        break;
                    }
            }
        }
        // Method for updating a task
        public static void EditToDoTask()
        {
            // Menu for selecting task
            Display.SelectTaskToEditMenu();

            // Get selected task to edit
            int selectedTaskToEdit = (InputValidator.GetOptionSelectTaskToEditMenu() - 1);

            // Show the task to edit
            Console.WriteLine((selectedTaskToEdit + 1).ToString().PadRight(20) + ListManager.toDoTaskList[selectedTaskToEdit].Title.PadRight(30) + ListManager.toDoTaskList[selectedTaskToEdit].DueDate.ToString().PadRight(20) + ListManager.toDoTaskList[selectedTaskToEdit].Status.PadRight(20) + ListManager.toDoTaskList[selectedTaskToEdit].Project);

            // Show Edit Task Menu
            Display.EditTaskMenu();

            // Get Users Choice from Edit Task Menu
            int optionEditTaskMenu = InputValidator.GetOptionEditTaskMenu();

            switch (optionEditTaskMenu)
            {
                case 1:
                    // Prompt the properties of the task and ask for input
                    Console.WriteLine("Update Task");

                    string title = InputValidator.GetValidTitle();
                    DateOnly dueDate = InputValidator.GetValidDueDate();
                    string status = InputValidator.GetValidStatus();
                    string project = InputValidator.GetValidProject();

                    Console.WriteLine("You have entered the following:");
                    Console.WriteLine($"Title: \t\t {title}");
                    Console.WriteLine($"Due date: \t {dueDate}");
                    Console.WriteLine($"Status: \t {status}");
                    Console.WriteLine($"Project: \t {project}");

                    // Show Save Menu
                    Display.SaveMenu();

                    // Exit With Save or Do Not Save
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Task Updates Is Not Saved!");
                                Console.ResetColor();
                                break;
                            }
                    }
                    break;
                case 2:
                    Console.WriteLine("Mark As Done");
                    Console.WriteLine("The Task Is Marked As Done");
                    // Show Save Menu
                    Display.SaveMenu();

                    // Exit With Save or Do Not Save
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Task Updates Is Not Saved!");
                                Console.ResetColor();
                                break;
                            }
                    }

                    break;
                case 3:
                    Console.WriteLine("Remove Task");
                    Console.WriteLine("The Task Is Removed");
                    // Show Save Menu
                    Display.SaveMenu();

                    // Exit With Save or Do Not Save
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Task Updates Is Not Saved!");
                                Console.ResetColor();
                                break;
                            }
                    }
                    break;
            }
            
            }
                        
            






    }
}
