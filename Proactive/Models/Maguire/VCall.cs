using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VCall
    {
        public Guid CllId { get; set; }
        public Guid UsId { get; set; }
        public Guid AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid ObjId { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public bool Incomming { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Duration { get; set; }
        public string DialParams { get; set; }
        public string AcName { get; set; }
        public string AccName { get; set; }
        public string ParentSummary { get; set; }
        public string ParentType { get; set; }
        public string Direction { get; set; }
        public string DirectionImage { get; set; }
        public Guid? AcoId { get; set; }
        public Guid? UsIdSales { get; set; }
        public Guid? UsIdSupport { get; set; }
        public string AcGroup { get; set; }
    }
}
