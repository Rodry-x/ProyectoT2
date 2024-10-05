using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Helpers;
using Models;

namespace Stores
{
    public abstract class TasksStore
    {
        public static BindingList<TaskItem> Tasks { get; set; } = new BindingList<TaskItem>();
        public static async Task getTasks()
        {
            try
            {
                var response = await FetchHelper.GetAsync<List<GetTasksItem>>("tasks");
                response.ForEach(task => {
                    var taskItem = new TaskItem
                    {
                        Id = task.id,
                        Name = task.name,
                        Description = task.description,
                        Deadline = task.Deadline
                    };
                    Tasks.Add(taskItem);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void Clear()
        {
            Tasks.Clear();
        }
    }

}