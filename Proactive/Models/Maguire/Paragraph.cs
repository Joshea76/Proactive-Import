using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Paragraph
    {
        public Paragraph()
        {
            DropsOptions = new HashSet<DropsOption>();
        }

        public Guid PaId { get; set; }
        public bool? PaDeleted { get; set; }
        public string Tag { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }

        public virtual ICollection<DropsOption> DropsOptions { get; set; }
    }
}
