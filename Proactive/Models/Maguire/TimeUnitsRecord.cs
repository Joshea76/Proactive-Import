using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TimeUnitsRecord
    {
        public Guid TurId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Guid UsId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? TurDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? AcId { get; set; }
        public Guid? AcaId { get; set; }
        public Guid? AccaId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? OpaId { get; set; }
        public Guid? PjId { get; set; }
        public Guid? PjaId { get; set; }
        public int TimeUnitValue { get; set; }
        public DateTime? DateRecorded { get; set; }
        public Guid? OpqdId { get; set; }
        public Guid? Owner { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual Activity Aca { get; set; }
        public virtual Activity Acca { get; set; }
        public virtual Opportunity Op { get; set; }
        public virtual Activity Opa { get; set; }
        public virtual OpportunitiesQuotesDetail Opqd { get; set; }
        public virtual Project Pj { get; set; }
        public virtual Activity Pja { get; set; }
        public virtual User Us { get; set; }
    }
}
