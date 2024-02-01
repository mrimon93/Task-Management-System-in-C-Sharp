using System;
using System.Collections.Generic;

namespace TaskManagementSystem.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string ?Title { get; set; }
        public string ?Description { get; set; }
        public DateTime DueDate { get; set; }
        public string ?Status { get; set; }

        // Example: Assuming SubTasks is a collection of SubTask
        public List<SubTask> ?SubTasks { get; set; }
    }

    public class SubTask
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        // Other properties of SubTask
    }
}
