using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Template
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateContent { get; set; }
        public int TemplateTypeId { get; set; }
        public string UserId { get; set; }

        public virtual TemplateType TemplateType { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
