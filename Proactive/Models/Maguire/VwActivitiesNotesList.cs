using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwActivitiesNotesList
    {
        public string Account { get; set; }
        public string Summary { get; set; }
        public Guid AcId { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string TypeHlight { get; set; }
        public Guid? TypeId { get; set; }
        public string Owner { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
        public byte StatusId { get; set; }
        public double PercentComplete { get; set; }
        public byte Priority { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string Notes { get; set; }
    }
}
