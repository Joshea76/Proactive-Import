using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntAnagramDespatch
    {
        public Guid AngDpId { get; set; }
        public string Summary { get; set; }
        public string ExternalReference { get; set; }
        public string Reference { get; set; }
        public Guid AngTrId { get; set; }
        public Guid OpqId { get; set; }
        public Guid AcId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? AngDpDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string AngDpUd1 { get; set; }
        public string AngDpUd2 { get; set; }
        public string AngDpUd3 { get; set; }
        public string AngDpUd4 { get; set; }
        public string AngDpUd5 { get; set; }
        public string AngDpUd6 { get; set; }
        public string AngDpUd7 { get; set; }
        public string AngDpUd8 { get; set; }
        public string AngDpUd9 { get; set; }
        public string AngDpUd10 { get; set; }
        public decimal? AngDpUd1Numeric { get; set; }
        public decimal? AngDpUd2Numeric { get; set; }
        public decimal? AngDpUd3Numeric { get; set; }
        public decimal? AngDpUd4Numeric { get; set; }
        public decimal? AngDpUd5Numeric { get; set; }
        public decimal? AngDpUd6Numeric { get; set; }
        public decimal? AngDpUd7Numeric { get; set; }
        public decimal? AngDpUd8Numeric { get; set; }
        public decimal? AngDpUd9Numeric { get; set; }
        public decimal? AngDpUd10Numeric { get; set; }
        public DateTime? AngDpUd1Date { get; set; }
        public DateTime? AngDpUd2Date { get; set; }
        public DateTime? AngDpUd3Date { get; set; }
        public DateTime? AngDpUd4Date { get; set; }
        public DateTime? AngDpUd5Date { get; set; }
        public DateTime? AngDpUd6Date { get; set; }
        public DateTime? AngDpUd7Date { get; set; }
        public DateTime? AngDpUd8Date { get; set; }
        public DateTime? AngDpUd9Date { get; set; }
        public DateTime? AngDpUd10Date { get; set; }
        public Guid? AngDpUd1Id { get; set; }
        public Guid? AngDpUd2Id { get; set; }
        public Guid? AngDpUd3Id { get; set; }
        public Guid? AngDpUd4Id { get; set; }
        public Guid? AngDpUd5Id { get; set; }
        public Guid? AngDpUd6Id { get; set; }
        public Guid? AngDpUd7Id { get; set; }
        public Guid? AngDpUd8Id { get; set; }
        public Guid? AngDpUd9Id { get; set; }
        public Guid? AngDpUd10Id { get; set; }
        public bool? AngDpUd1Bit { get; set; }
        public bool? AngDpUd2Bit { get; set; }
        public bool? AngDpUd3Bit { get; set; }
        public bool? AngDpUd4Bit { get; set; }
        public bool? AngDpUd5Bit { get; set; }
        public bool? AngDpUd6Bit { get; set; }
        public bool? AngDpUd7Bit { get; set; }
        public bool? AngDpUd8Bit { get; set; }
        public bool? AngDpUd9Bit { get; set; }
        public bool? AngDpUd10Bit { get; set; }
        public string AngDpUd1IdHlight { get; set; }
        public string AngDpUd2IdHlight { get; set; }
        public string AngDpUd3IdHlight { get; set; }
        public string AngDpUd4IdHlight { get; set; }
        public string AngDpUd5IdHlight { get; set; }
        public string AngDpUd6IdHlight { get; set; }
        public string AngDpUd7IdHlight { get; set; }
        public string AngDpUd8IdHlight { get; set; }
        public string AngDpUd9IdHlight { get; set; }
        public string AngDpUd10IdHlight { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual IntAnagramTransaction AngTr { get; set; }
        public virtual OpportunitiesQuote Opq { get; set; }
    }
}
