using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Models;

namespace Stores
{
    public abstract class TasksStore
    {
        public static BindingList<TaskItem> Tasks { get; set; } = new BindingList<TaskItem>();
        public static async Task getTasks()
        {
            AppHelper.SetLoading();
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
            finally
            {
                AppHelper.RemoveLoading();
            }
        }

        public static async Task<bool> addTask(
            string name,
            string description,
            DateTime deadline
        ) {
            AppHelper.SetFloatingLoading();
            try
            {
                var body = new CreateTaskBodyRequest
                {
                    name = name,
                    description = description,
                    deadline = deadline
                };
                var response = await FetchHelper.PostAsync<CreateTaskBodyRequest, CreateTaskBodyResponse>("tasks", body);
                TaskItem task = new TaskItem
                {
                    Id = response.id,
                    Name = response.name,
                    Description = response.description,
                    Deadline = response.deadline
                };
                Tasks.Add(task);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                AppHelper.RemoveFloatingLoading();
            }
        }

        public static async Task<bool> editTask(
            int taskIndex,
            string name,
            string description,
            DateTime deadline
        ) {
            AppHelper.SetFloatingLoading();
            try
            {
                var body = new PutTaskBodyRequest
                {
                    name = name,
                    description = description,
                    deadline = deadline
                };
                await FetchHelper.PutAsync($"tasks/{TasksStore.Tasks[taskIndex].Id}", body);
                Tasks[taskIndex].Name = name;
                Tasks[taskIndex].Description = description;
                Tasks[taskIndex].Deadline = deadline;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                AppHelper.RemoveFloatingLoading();
            }
        }

        public static async Task<bool> deleteTask(int taskIndex)
        {
            AppHelper.SetLoading();
            try
            {
                await FetchHelper.DeleteAsync($"tasks/{TasksStore.Tasks[taskIndex].Id}");
                Tasks.RemoveAt(taskIndex);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                AppHelper.RemoveLoading();
            }
        }

        public static void Clear()
        {
            Tasks.Clear();
        }
    }

}