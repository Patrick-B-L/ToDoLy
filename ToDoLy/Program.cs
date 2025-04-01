using Microsoft.VisualBasic;
using System.Linq.Expressions;
using ToDoLy;

// Continue with: cleaning up the code. 
//Remember to commit and push to Github every now and then

// This application is a task management system allowing users to manage and organize tasks.
// Features include sorting tasks by due date or project, adding and editing tasks, and saving them persistently.

// Only for demonstration purposes
//Listmanager.InitializeSampleData();

// Load existing tasks from a file
FileManager.LoadFromFile();

// Welcome the user and display the current task status
Display.Greeting();
Display.ShowStatus();

// Main loop: Present the user with options to proceed until they choose to exit
while (true)
{
    // Display the main menu options
    Display.MainMenu();

    // Get the user's selected option from the main menu
    int mainMenuOption = InputValidator.GetOptionMainMenu();
    switch (mainMenuOption)
    {
        case 1:

            // Provide sorting options for the task list
            Display.SortTaskListMenu();

            // Handle the user's selection for sorting tasks
            switch (InputValidator.GetOptionSortTaskListMenu())
            {
                case 1:
                    // Sort and display tasks ordered by their due dates
                    ListManager.ShowDiagramToDoTasksOrderedByDueDate();
                    break;
                case 2:
                    // Sort and display tasks grouped by project
                    ListManager.ShowDiagramToDoTasksOrderedByProject();
                    break;
                case 3:
                    // Display all tasks with their index numbers
                    ListManager.ShowDiagramToDoTasksWithIndex();
                    break;
            }
            break;
        case 2:
            // Allow the user to add a new task to the list
            ToDoTaskManager.AddNewToDoTask();
            break;
        case 3:

            // Display all tasks with index numbers
            ListManager.ShowDiagramToDoTasksWithIndex();

            // Allow the user to edit an existing task
            ToDoTaskManager.EditToDoTask();
            break;
        case 4:
            // Save all tasks to a file and exit the application
            FileManager.SaveToFile();
            Environment.Exit(0);
            break;

    }
}











