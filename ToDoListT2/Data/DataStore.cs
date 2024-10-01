using System.Collections.Generic;
using System.ComponentModel;
using Models;

namespace Data
{
    public abstract class DataStore
    {
        public static BindingList<TaskItem> Tasks { get; set; } = new BindingList<TaskItem>();
        public static User User { get; set; } = new User();
        public static string Token { get; set; } = "";
        public static object SelectedTask { get; internal set; }

        public static void Clear()
        {
            DataStore.Tasks.Clear();
            DataStore.User = new User();
            DataStore.Token = "";
        }
    }

}