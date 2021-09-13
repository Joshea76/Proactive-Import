using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Purpose
    {
        public Purpose()
        {
            PrivacyRules = new HashSet<PrivacyRule>();
        }

        public Guid PuId { get; set; }
        public Guid? LawfulBasis { get; set; }
        public int? Duration { get; set; }
        public string Summary { get; set; }
        public bool? PuDeleted { get; set; }
        public bool Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string PuUd1 { get; set; }
        public string PuUd2 { get; set; }
        public string PuUd3 { get; set; }
        public string PuUd4 { get; set; }
        public string PuUd5 { get; set; }
        public string PuUd6 { get; set; }
        public string PuUd7 { get; set; }
        public string PuUd8 { get; set; }
        public string PuUd9 { get; set; }
        public string PuUd10 { get; set; }
        public Guid? PuUd1Id { get; set; }
        public Guid? PuUd2Id { get; set; }
        public Guid? PuUd3Id { get; set; }
        public Guid? PuUd4Id { get; set; }
        public Guid? PuUd5Id { get; set; }
        public Guid? PuUd6Id { get; set; }
        public Guid? PuUd7Id { get; set; }
        public Guid? PuUd8Id { get; set; }
        public Guid? PuUd9Id { get; set; }
        public Guid? PuUd10Id { get; set; }
        public DateTime? PuUd1Date { get; set; }
        public DateTime? PuUd2Date { get; set; }
        public DateTime? PuUd3Date { get; set; }
        public DateTime? PuUd4Date { get; set; }
        public DateTime? PuUd5Date { get; set; }
        public DateTime? PuUd6Date { get; set; }
        public DateTime? PuUd7Date { get; set; }
        public DateTime? PuUd8Date { get; set; }
        public DateTime? PuUd9Date { get; set; }
        public DateTime? PuUd10Date { get; set; }
        public bool? PuUd1Bit { get; set; }
        public bool? PuUd2Bit { get; set; }
        public bool? PuUd3Bit { get; set; }
        public bool? PuUd4Bit { get; set; }
        public bool? PuUd5Bit { get; set; }
        public bool? PuUd6Bit { get; set; }
        public bool? PuUd7Bit { get; set; }
        public bool? PuUd8Bit { get; set; }
        public bool? PuUd9Bit { get; set; }
        public bool? PuUd10Bit { get; set; }
        public decimal? PuUd1Numeric { get; set; }
        public decimal? PuUd2Numeric { get; set; }
        public decimal? PuUd3Numeric { get; set; }
        public decimal? PuUd4Numeric { get; set; }
        public decimal? PuUd5Numeric { get; set; }
        public decimal? PuUd6Numeric { get; set; }
        public decimal? PuUd7Numeric { get; set; }
        public decimal? PuUd8Numeric { get; set; }
        public decimal? PuUd9Numeric { get; set; }
        public decimal? PuUd10Numeric { get; set; }
        public byte? RemovalDateMode { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual ICollection<PrivacyRule> PrivacyRules { get; set; }
    }
}
