using System;

namespace TodoItemsLibrary
{
    public class TodoItem : IEquatable<TodoItem>
    {
        public string Title { get; set; }
        public DateTime CompletedByWhen { get; set; }
        public bool IsCompleted { get; set; }

        public bool Equals(TodoItem other)
        {
            return Title.Equals(other.Title, StringComparison.OrdinalIgnoreCase);
        }
    }
}
