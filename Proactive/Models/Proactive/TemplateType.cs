using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TemplateType
    {
        public TemplateType()
        {
            Templates = new HashSet<Template>();
        }

        public int TemplateTypeId { get; set; }
        public string TemplateTypeName { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}
