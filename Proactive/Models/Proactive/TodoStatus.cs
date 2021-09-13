using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoStatus
    {
        public TodoStatus()
        {
            Todos = new HashSet<Todo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
