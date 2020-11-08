using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Models
{
    public class Todo : DbContext
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
