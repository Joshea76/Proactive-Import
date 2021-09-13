using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Template
    {
        public Template()
        {
            Roles = new HashSet<Role>();
        }

        public Guid TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateAlias { get; set; }
        public int TemplateType { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
