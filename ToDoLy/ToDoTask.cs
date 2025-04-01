using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLy
{   // The ToDoTask class: Constructor with properties for task objects.  
    class ToDoTask
    {
        public ToDoTask(string title, DateOnly dueDate, string status, string project) 
        {
            Title = title;
            DueDate = dueDate;
            Status = status;
            Project = project;

        }
        public string Title { get; set; }
        public DateOnly DueDate { get; set; }
        public string Status { get; set; }
        public string Project { get; set; }
        
    }
}
