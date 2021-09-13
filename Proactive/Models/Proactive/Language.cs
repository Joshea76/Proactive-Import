using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Language
    {
        public Language()
        {
            Days = new HashSet<Day>();
        }

        public int LanguagesId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Day> Days { get; set; }
    }
}
