using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VJob
    {
        public Guid JobId { get; set; }
        public string Summary { get; set; }
        public string JobType { get; set; }
        public string ObjectType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Command { get; set; }
        public DateTime? RunDate { get; set; }
        public string Result { get; set; }
        public string ObjId { get; set; }
        public short? Jobstatus { get; set; }
        public string Statustext { get; set; }
        public string Readytext { get; set; }
        public string Deletetext { get; set; }
        public string Detailstext { get; set; }
        public string Holdtext { get; set; }
        public int Failed { get; set; }
        public string Accountname { get; set; }
    }
}
