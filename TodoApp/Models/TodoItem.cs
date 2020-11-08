using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TodoApp.Models
{
    public class TodoItem : DbContext
    {
        public int Id { get; set; }
        public string Task { get; set; }
        
        [Column(TypeName="text")]
        public string Description { get; set; }

        public Todo Todo { get; set; }
    }
}
