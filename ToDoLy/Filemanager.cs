using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Methods for managing files
    class FileManager
    {
        // Method For Saving Tasks To File
        public static void SaveToFile()
        {
            var jsonoptions = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(ListManager.toDoTaskList, jsonoptions);

            File.WriteAllText("ToDoLy.json", json);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Tasks Are Saved To File");
            Console.ResetColor();
        }

        // Method For Loading File With Saved Tasks
        public static List<ToDoTask> LoadFromFile()
        { 
            if (File.Exists("ToDoLy.json"))
            {
                string json = File.ReadAllText("ToDoLy.json");
                // Deserialize Json Code And Add To ListManager.toDoTaskList
                //Alternative Code 1
                //var toDoTaskList = JsonSerializer.Deserialize<List<ToDoTask>>(json);
                //Listmanager.toDoTaskList = toDoTaskList ?? new List<ToDoTask>();
                //Alternative Code 2
                ListManager.toDoTaskList = JsonSerializer.Deserialize<List<ToDoTask>>(json) ?? new List<ToDoTask>();
                return ListManager.toDoTaskList;
            }
            return new List<ToDoTask>();
        }

        //Console.WriteLine($"{task1.Title}, {task1.DueDate}, {task1.Status}, {task1.Project} ");
        //File.AppendAllLines("testfiltask1.txt", task11);


        //{
        //    File.WriteAllText("testfil.txt", title);
        //    File.AppendAllText("testfil.txt", Convert.ToString(dueDate));
        //    File.AppendAllText("testfil.txt", status);
        //    File.AppendAllText("testfil.txt", project);
        //}

    }
}
