using System;

namespace ToDoItemList.Model
{
    public class TodoItem
    {
        public string Title { get; set; }
        public DateTime CompletedByWhen { get; set; }
        public bool IsCompleted { get; set; }
    }
}
