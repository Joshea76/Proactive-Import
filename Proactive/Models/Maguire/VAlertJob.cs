using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAlertJob
    {
        public Guid JobId { get; set; }
        public Guid JobTypeId { get; set; }
        public string ObjId { get; set; }
        public string Summary { get; set; }
        public bool? JobDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? RunAfter { get; set; }
        public DateTime? RunDate { get; set; }
        public string Result { get; set; }
        public string Command { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string ObjectType { get; set; }
        public short? Jobstatus { get; set; }
        public Guid? AcId { get; set; }
        public Guid? FneId { get; set; }
        public string Jobtype { get; set; }
    }
}
