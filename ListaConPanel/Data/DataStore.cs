using System.Collections.Generic;
using System.ComponentModel;
using ListaConPanel.Models;

namespace ListaConPanel.Data
{
    public class DataStore
    {
        public static BindingList<Task> Tasks { get; set; } = new BindingList<Task>();
        public static User User { get; set; } = new User();
    }
}