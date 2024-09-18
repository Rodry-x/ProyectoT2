using System.Collections.Generic;
using System.ComponentModel;
using Models;

namespace Data
{
    public abstract class DataStore
    {
        public static BindingList<Task> Tasks { get; set; } = new BindingList<Task>();
        public static User User { get; set; } = new User();
        public static string Token { get; set; } = "";
    }
}