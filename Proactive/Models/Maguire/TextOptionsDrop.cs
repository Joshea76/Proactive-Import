using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TextOptionsDrop
    {
        public TextOptionsDrop()
        {
            TextOptionsDropsOptions = new HashSet<TextOptionsDropsOption>();
        }

        public Guid TodrId { get; set; }
        public string Summary { get; set; }
        public bool? Issoftdrop { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<TextOptionsDropsOption> TextOptionsDropsOptions { get; set; }
    }
}
