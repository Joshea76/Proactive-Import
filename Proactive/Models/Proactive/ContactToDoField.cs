using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactToDoField
    {
        public ContactToDoField()
        {
            ContactToDoFieldValues = new HashSet<ContactToDoFieldValue>();
            Todos = new HashSet<Todo>();
        }

        public int ContactToDoFieldId { get; set; }
        public string Name { get; set; }
        public bool Display { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ContactToDoFieldValue> ContactToDoFieldValues { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
