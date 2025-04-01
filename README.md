# ToDoLy - Task Management Application

## Overview
ToDoLy is a feature-rich task management application designed to help users organize, sort, and manage their tasks effectively. It provides functionality for creating, updating, sorting, and deleting tasks, all while maintaining a user-friendly and modular design.

## Features
1. **Task Creation**:
   - Add new tasks with properties such as title, due date, status, and project assignment.
   - Flexible input validation ensures high data integrity.

2. **Task Management**:
   - Edit existing tasks, including title, due date, status, and project.
   - Mark tasks as "Done" for better tracking.
   - Remove tasks from the task list if no longer needed.

3. **Sorting**:
   - Sort tasks by due date to prioritize deadlines.
   - Group tasks by project for better categorization.
   - View tasks in indexed diagrams for a clear overview.

4. **Persistence**:
   - Load tasks automatically from a file at startup.
   - Save tasks back to the file to ensure progress is never lost.

5. **Interactive Menus**:
   - User-friendly text-based menus for seamless navigation.
   - Multiple submenus for sorting, editing, and saving tasks.

## How to Use
1. Run the application, which automatically loads saved tasks from `ToDoLy.json`.
2. Follow the main menu prompts:
   - Add a new task using the detailed input process.
   - Sort tasks based on due date or project via sorting options.
   - Edit, mark as done, or delete tasks using the edit menu.
   - Save changes using the save menu, ensuring all updates are written to the `ToDoLy.json` file.
   - Exit the application safely by saving your progress.

## Project Structure
- **ToDoTaskManager.cs**:
  - Handles creating, editing, and deleting tasks.
  - Includes methods for validating user inputs and managing the task list.
- **ListManager**:
  - Manages the overall task list, including adding and displaying tasks.
  - Provides diagram views for tasks in various formats.
- **InputValidator**:
  - Ensures robust input validation for all user entries.
- **Display**:
  - Handles user interface components, such as menus and messages.
- **FileManager**:
  - Manages saving and loading tasks from the persistent storage file.

## Requirements
- .NET runtime environment (version 6 or higher recommended).
- Compatible with Windows, macOS, or Linux operating systems.

## File Structure
- `ToDoLy.json`: Persistent storage file for saving tasks across sessions.

## Notes
- Save your tasks regularly to prevent data loss.
- Editing and removing tasks are only accessible through the task index provided in the application.

## Future Enhancements
- Adding reminders or notifications for tasks approaching their deadlines.
- Implementing a graphical user interface (GUI) for easier interaction.
- Introducing user authentication for managing multiple users and their task lists.
- Enabling advanced search and filter options.


