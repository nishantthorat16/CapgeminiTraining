using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoItemsLibrary
{
    public interface ITodoItemService
    {
        void Add(TodoItem item);
        List<TodoItem> GetTodoItems();
    }


    public class ToDoListService : ITodoItemService
    {
        static List<TodoItem> list = new List<TodoItem>();

        public void Add(TodoItem item)
        {
            if (list.Contains(item))
                throw new Exception($"Item {item.Title} " +
                    $" is already in the list");

             list.Add(item);
        }

        public List<TodoItem> GetTodoItems()
        {
            return list;
        }
    }
}
