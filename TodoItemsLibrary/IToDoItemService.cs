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
}
