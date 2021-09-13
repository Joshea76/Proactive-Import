using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoCategory
    {
        public TodoCategory()
        {
            Todos = new HashSet<Todo>();
        }

        public int TodoTypeId { get; set; }
        public string TodoTypeName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }
        public string Color { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
