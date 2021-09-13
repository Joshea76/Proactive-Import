using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Country
    {
        public Guid CtId { get; set; }
        public int? SortOrder { get; set; }
        public string Summary { get; set; }
        public bool? CtDeleted { get; set; }
        public string Iso2code { get; set; }
        public string Iso3code { get; set; }
        public string IsoNumeric { get; set; }
        public string OtherCode { get; set; }
        public string DialingCode { get; set; }
        public string IddPrefix { get; set; }
        public string NddPrefix { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string CtSoundex { get; set; }
    }
}
