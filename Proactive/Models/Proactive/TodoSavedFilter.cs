using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoSavedFilter
    {
        public TodoSavedFilter()
        {
            TodoSavedFilterCustomFields = new HashSet<TodoSavedFilterCustomField>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Contact { get; set; }
        public string Org { get; set; }
        public string Category { get; set; }
        public string AssignedTo { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<TodoSavedFilterCustomField> TodoSavedFilterCustomFields { get; set; }
    }
}
