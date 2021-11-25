using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoItemsLibrary
{
    public class ToDoItemFileService : ITodoItemService
    {

        public void Add(TodoItem item)
        {
           List<TodoItem> list = GetTodoItems();

           if (list.Contains(item))
                throw new Exception($"Item {item.Title} " +
                  $" is already in the list");

           list.Add(item);

           var serialize =  JsonSerializer.Serialize(list);

            if (!File.Exists(@"D:\Capgemini Training\mytodoitems.json"))
                File.Create(@"D:\Capgemini Training\mytodoitems.json");

           File.WriteAllText(@"D:\Capgemini Training\mytodoitems.json", serialize);
        }

        public List<TodoItem> GetTodoItems()
        {
            var fileContent = File.ReadAllText(@"D:\Capgemini Training\mytodoitems.json");

            if (fileContent.Length > 0)
            {
                var list = JsonSerializer.Deserialize<List<TodoItem>>(fileContent);

                return list;
            }
            else
                return new List<TodoItem>();
        }
    }
}
