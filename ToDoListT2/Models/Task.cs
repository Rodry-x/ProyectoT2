using System;
using System.ComponentModel;

namespace Models
{
    public class TaskItem: INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string name;
        private string description;
        private DateTime deadline;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set
            {
                if (deadline != value)
                {
                    deadline = value;
                    OnPropertyChanged("Deadline");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class GetTasksItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime Deadline { get; set; }

    }
    public class PutTaskBodyRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
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