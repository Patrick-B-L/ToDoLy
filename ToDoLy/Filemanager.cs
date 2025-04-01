using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ToDoLy
{
    // Class for managing file operations such as saving and loading tasks
    class FileManager
    {
        // Saves the task list to a JSON file
        public static void SaveToFile()
        {
            // Configure JSON options to format the output with indentation for readability
            var jsonoptions = new JsonSerializerOptions { WriteIndented = true };

            // Serialize the task list to a JSON string
            string json = JsonSerializer.Serialize(ListManager.toDoTaskList, jsonoptions);

            // Write the JSON string to a file named "ToDoLy.json"
            File.WriteAllText("ToDoLy.json", json);

            // Inform the user that tasks have been saved successfully
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Tasks Are Saved To File");
            Console.ResetColor();
        }

        // Loads the task list from a JSON file, if it exists
        public static List<ToDoTask> LoadFromFile()
        {
            // Check if the file "ToDoLy.json" exists in the directory
            if (File.Exists("ToDoLy.json"))
            {
                // Read the content of the JSON file into a string
                string json = File.ReadAllText("ToDoLy.json");

                // Deserialize the JSON string into a list of ToDoTask objects
                // If deserialization fails, assign an empty list to prevent null reference errors
                ListManager.toDoTaskList = JsonSerializer.Deserialize<List<ToDoTask>>(json) ?? new List<ToDoTask>();

                // Return the deserialized task list
                return ListManager.toDoTaskList;
            }

            // If the file does not exist, return an empty task list
            return new List<ToDoTask>();
        }
    }
}
