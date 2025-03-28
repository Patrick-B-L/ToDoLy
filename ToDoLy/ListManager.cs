using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Methods for managing lists

    class ListManager
    {
        // Creates a list from the ToDoTask class
        public static List<ToDoTask> toDoTaskList = new List<ToDoTask>();

        // Adds ToDoTask to toDoTaskList
        public static void AddTasktoDoTaskList(ToDoTask toDoTask)
        {
            toDoTaskList.Add(toDoTask);
        }

        // Sort toDoTaskList

        public static List<ToDoTask> ToDoTaskListOrderedByDueDate()
        {
            return toDoTaskList.OrderBy(toDoTask => toDoTask.DueDate).ToList();
        }

        public static List<ToDoTask> ToDoTaskListOrderedByProject()
        {
            return toDoTaskList.OrderBy(toDoTask => toDoTask.Project).ToList();
        }

        // Show items in list
        public static void ShowDiagramToDoTasksOrderedByDueDate()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            // Diagram header
            Console.WriteLine("Title".PadRight(30) + "Due Date".PadRight(20) + "Status".PadRight(20) + "Project");
            Console.WriteLine("-----".PadRight(30) + "--------".PadRight(20) + "------".PadRight(20) + "-------");

            foreach (var task in ToDoTaskListOrderedByDueDate())
            {
                Console.WriteLine(task.Title.PadRight(30) + task.DueDate.ToString().PadRight(20) + task.Status.PadRight(20) + task.Project);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public static void ShowDiagramToDoTasksOrderedByProject()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            // Diagram header
            Console.WriteLine("Title".PadRight(30) + "Due Date".PadRight(20) + "Status".PadRight(20) + "Project");
            Console.WriteLine("-----".PadRight(30) + "--------".PadRight(20) + "------".PadRight(20) + "-------");

            foreach (var task in ToDoTaskListOrderedByProject())
            {
                Console.WriteLine(task.Title.PadRight(30) + task.DueDate.ToString().PadRight(20) + task.Status.PadRight(20) + task.Project);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public static void ShowDiagramToDoTasksWithIndex()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            // Diagram header
            Console.WriteLine("Task Number".PadRight(20) + "Title".PadRight(30) + "Due Date".PadRight(20) + "Status".PadRight(20) + "Project");
            Console.WriteLine("-----------".PadRight(20) + "--------".PadRight(30) + "------".PadRight(20) + "-------");

            int index = 1;
            foreach (var task in toDoTaskList)
            {
                Console.WriteLine(index.ToString().PadRight(20) + task.Title.PadRight(30) + task.DueDate.ToString().PadRight(20) + task.Status.PadRight(20) + task.Project);
                index++;
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public static int GetCountTotalNumberOfTasks()
        { 
            int totalNumberOfTasks = toDoTaskList.Count();
            return totalNumberOfTasks;
        }

        public static int GetCountTotalNumberOfTasksDone()
        {
            int totalNumberOfTasksDone = toDoTaskList.Where(task => task.Status.Contains("Done")).Count();
            return totalNumberOfTasksDone;
        }

        public static int GetCountTotalNumberOfTasksToDo()
        {
            int totalNumberOfTasksToDo = GetCountTotalNumberOfTasks() - GetCountTotalNumberOfTasksDone();
            return totalNumberOfTasksToDo;
        }

        public static void InitializeSampleData()
        {
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
