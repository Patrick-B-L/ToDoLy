using Microsoft.VisualBasic;
using System.Linq.Expressions;
using ToDoLy;

// Continue with: updating comments, cleaning up the code and make the user experience more intuitive by adding lines and changing text colors etc... 
//Remember to commit and push to Github every now and then

// Only for testing purposes
//Listmanager.InitializeSampleData();

FileManager.LoadFromFile();

//Welcome the user and show status for the existing tasks
Display.Greeting();
Display.ShowStatus();

//Present choices on how to proceed.
while (true)
{
    Display.MainMenu();
    int mainMenuOption = InputValidator.GetOptionMainMenu();
    switch (mainMenuOption)
    {
        case 1:


            Display.SortTaskListMenu();

            ;
            switch(InputValidator.GetOptionSortTaskListMenu())
            {
                case 1:
                    ListManager.ShowDiagramToDoTasksOrderedByDueDate();
                    break;
                case 2:
                    ListManager.ShowDiagramToDoTasksOrderedByProject();
                    break;
                case 3:
                    ListManager.ShowDiagramToDoTasksWithIndex();
                    break;
            }
            break;
        case 2:

            ToDoTaskManager.AddNewToDoTask();
            break;
        case 3:

            // Show Diagram with index
            ListManager.ShowDiagramToDoTasksWithIndex();

            ToDoTaskManager.EditToDoTask();

            break;
        case 4:

            FileManager.SaveToFile();
            Environment.Exit(0);
            break;

    }
}











