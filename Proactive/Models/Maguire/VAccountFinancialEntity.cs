using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAccountFinancialEntity
    {
        public Guid AcfneId { get; set; }
        public Guid AcId { get; set; }
        public Guid FneId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? IsDefault { get; set; }
        public bool? AcfneDeleted { get; set; }
        public string Summary { get; set; }
        public string FneExternal { get; set; }
        public string ShortCode { get; set; }
    }
}
