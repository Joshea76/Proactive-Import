using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TextOptionsDropsOption
    {
        public Guid TodroId { get; set; }
        public Guid TodrId { get; set; }
        public string Summary { get; set; }
        public string Value { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? Deleted { get; set; }
        public int? Order { get; set; }

        public virtual TextOptionsDrop Todr { get; set; }
    }
}
