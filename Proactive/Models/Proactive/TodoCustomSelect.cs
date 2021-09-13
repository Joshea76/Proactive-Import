using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoCustomSelect
    {
        public TodoCustomSelect()
        {
            TodoCustomSelectItems = new HashSet<TodoCustomSelectItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool ShowInTable { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<TodoCustomSelectItem> TodoCustomSelectItems { get; set; }
    }
}
