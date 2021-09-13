using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VDataAccessRequest
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string RequestBy { get; set; }
        public string AccessRequest { get; set; }
        public bool? Completed { get; set; }
        public string CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
        public Guid PrlId { get; set; }
    }
}
