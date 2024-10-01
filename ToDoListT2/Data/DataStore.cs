using System.ComponentModel;
using Models;

namespace Data
{
    public abstract class DataStore
    {
        public static BindingList<TaskItem> Tasks { get; set; } = new BindingList<TaskItem>();
        public static User User { get; set; } = new User();
        public static void Clear()
        {
            Tasks.Clear();
            User = new User();
        }
    }

}