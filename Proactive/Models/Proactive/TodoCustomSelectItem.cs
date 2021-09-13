using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoCustomSelectItem
    {
        public TodoCustomSelectItem()
        {
            TodoCustomSelectValues = new HashSet<TodoCustomSelectValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int SelectId { get; set; }

        public virtual TodoCustomSelect Select { get; set; }
        public virtual ICollection<TodoCustomSelectValue> TodoCustomSelectValues { get; set; }
    }
}
