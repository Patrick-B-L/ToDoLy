using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Methods for managing the task list
    class ListManager
    {
        // List that stores all ToDoTask objects
        public static List<ToDoTask> toDoTaskList = new List<ToDoTask>();

        // Adds a task to the list
        public static void AddTasktoDoTaskList(ToDoTask toDoTask)
        {
            toDoTaskList.Add(toDoTask); // Adds the provided task to the list
        }

        // Returns a sorted copy of the task list by due date
        public static List<ToDoTask> ToDoTaskListOrderedByDueDate()
        {
            return toDoTaskList.OrderBy(toDoTask => toDoTask.DueDate).ToList();
        }

        // Returns a sorted copy of the task list by project name
        public static List<ToDoTask> ToDoTaskListOrderedByProject()
        {
            return toDoTaskList.OrderBy(toDoTask => toDoTask.Project).ToList();
        }

        // Displays the task list sorted by due date
        public static void ShowDiagramToDoTasksOrderedByDueDate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTask List Ordered By Due Date");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------------------------------");

            // Print table headers
            Console.WriteLine("Title".PadRight(30) + "Due Date".PadRight(20) + "Status".PadRight(20) + "Project");
            Console.WriteLine("-----".PadRight(30) + "--------".PadRight(20) + "------".PadRight(20) + "-------");

            // Loop through sorted list and display each task
            foreach (var task in ToDoTaskListOrderedByDueDate())
            {
                Console.WriteLine(task.Title.PadRight(30) + task.DueDate.ToString().PadRight(20) + task.Status.PadRight(20) + task.Project);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // Displays the task list sorted by project
        public static void ShowDiagramToDoTasksOrderedByProject()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTask List Ordered By Project");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------------------------------"); 

            // Print table headers
            Console.WriteLine("Title".PadRight(30) + "Due Date".PadRight(20) + "Status".PadRight(20) + "Project");
            Console.WriteLine("-----".PadRight(30) + "--------".PadRight(20) + "------".PadRight(20) + "-------");

            // Loop through sorted list and display each task
            foreach (var task in ToDoTaskListOrderedByProject())
            {
                Console.WriteLine(task.Title.PadRight(30) + task.DueDate.ToString().PadRight(20) + task.Status.PadRight(20) + task.Project);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // Displays all tasks with their index in the list
        public static void ShowDiagramToDoTasksWithIndex()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTask List Ordered By Task Number (The Latest Added Task Is Shown Last)");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            // Print table headers
            Console.WriteLine("Task Number".PadRight(20) + "Title".PadRight(30) + "Due Date".PadRight(20) + "Status".PadRight(20) + "Project");
            Console.WriteLine("-----------".PadRight(20) + "--------".PadRight(30) + "------".PadRight(20) + "-------");

            // Display each task along with its index
            int index = 1;
            foreach (var task in toDoTaskList)
            {
                Console.WriteLine(index.ToString().PadRight(20) + task.Title.PadRight(30) + task.DueDate.ToString().PadRight(20) + task.Status.PadRight(20) + task.Project);
                index++;
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        }

        // Returns the total number of tasks in the list
        public static int GetCountTotalNumberOfTasks()
        {
            return toDoTaskList.Count(); // Counts all tasks in the list
        }

        // Returns the number of completed tasks
        public static int GetCountTotalNumberOfTasksDone()
        {
            return toDoTaskList.Where(task => task.Status.Contains("Done")).Count();
        }

        // Returns the number of tasks yet to be completed
        public static int GetCountTotalNumberOfTasksToDo()
        {
            return GetCountTotalNumberOfTasks() - GetCountTotalNumberOfTasksDone();
        }

        // Initializes the task list with sample data for demonstration purposes
        public static void InitializeSampleData()
        {
            // Adds a collection of predefined tasks to the list
            ListManager.AddTasktoDoTaskList(new ToDoTask("Buy groceries", new DateOnly(2025, 3, 28), "Pending", "Personal"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Submit report", new DateOnly(2025, 3, 27), "In Progress", "Work"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Book dentist appointment", new DateOnly(2025, 4, 1), "Pending", "Health"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Prepare presentation", new DateOnly(2025, 3, 30), "Pending", "Work"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Walk the dog", new DateOnly(2025, 3, 27), "Done", "Personal"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Team meeting", new DateOnly(2025, 3, 29), "Scheduled", "Work"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Renew gym membership", new DateOnly(2025, 3, 31), "Pending", "Health"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Review budget", new DateOnly(2025, 3, 27), "Done", "Finance"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Clean garage", new DateOnly(2025, 4, 2), "Pending", "Home"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Write blog post", new DateOnly(2025, 3, 30), "In Progress", "Hobby"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Attend webinar", new DateOnly(2025, 4, 3), "Scheduled", "Learning"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Fix bike", new DateOnly(2025, 4, 1), "Pending", "Personal"));
            ListManager.AddTasktoDoTaskList(new ToDoTask("Organize bookshelf", new DateOnly(2025, 3, 29), "Pending", "Home"));
        }
    }
}
