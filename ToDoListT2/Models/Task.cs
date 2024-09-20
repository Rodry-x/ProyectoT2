using System;

namespace Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
    }

    public class GetTasksItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime Deadline { get; set; }

    }

    public class CreateTaskBodyRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
    }

    public class CreateTaskBodyResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
    }
}