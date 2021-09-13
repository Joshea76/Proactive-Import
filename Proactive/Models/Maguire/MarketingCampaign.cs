﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaign
    {
        public MarketingCampaign()
        {
            MarketingCampaignStages = new HashSet<MarketingCampaignStage>();
            Touchpoints = new HashSet<Touchpoint>();
        }

        public Guid McaId { get; set; }
        public Guid? UsId { get; set; }
        public string Summary { get; set; }
        public Guid? Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string LastRunBy { get; set; }
        public string Reference { get; set; }
        public decimal? CCostVal { get; set; }
        public decimal? COpenVal { get; set; }
        public decimal? CWonVal { get; set; }
        public decimal? CLostVal { get; set; }
        public decimal? CProfitVal { get; set; }
        public int? CTltAppointments { get; set; }
        public int? CUnqAppointments { get; set; }
        public int? CCompleteAppointments { get; set; }
        public int? CTltOpportunities { get; set; }
        public int? COpenOpportunities { get; set; }
        public int? CWonOpportunities { get; set; }
        public int? CLostOpportunities { get; set; }
        public int? CTotalAct { get; set; }
        public int? CUniqueAct { get; set; }
        public int? CCompleteAct { get; set; }
        public int? CBookings { get; set; }
        public int? CBookingsConfirmed { get; set; }
        public decimal? CBookingsWonVal { get; set; }
        public decimal? CBookingsOpenVal { get; set; }
        public string McaUd1 { get; set; }
        public string McaUd2 { get; set; }
        public string McaUd3 { get; set; }
        public string McaUd4 { get; set; }
        public string McaUd5 { get; set; }
        public string McaUd6 { get; set; }
        public string McaUd7 { get; set; }
        public string McaUd8 { get; set; }
        public string McaUd9 { get; set; }
        public string McaUd10 { get; set; }
        public Guid? McaUd1Id { get; set; }
        public Guid? McaUd2Id { get; set; }
        public Guid? McaUd3Id { get; set; }
        public Guid? McaUd4Id { get; set; }
        public Guid? McaUd5Id { get; set; }
        public Guid? McaUd6Id { get; set; }
        public Guid? McaUd7Id { get; set; }
        public Guid? McaUd8Id { get; set; }
        public Guid? McaUd9Id { get; set; }
        public Guid? McaUd10Id { get; set; }
        public DateTime? McaUd1Date { get; set; }
        public DateTime? McaUd2Date { get; set; }
        public DateTime? McaUd3Date { get; set; }
        public DateTime? McaUd4Date { get; set; }
        public DateTime? McaUd5Date { get; set; }
        public DateTime? McaUd6Date { get; set; }
        public DateTime? McaUd7Date { get; set; }
        public DateTime? McaUd8Date { get; set; }
        public DateTime? McaUd9Date { get; set; }
        public DateTime? McaUd10Date { get; set; }
        public bool? McaUd1Bit { get; set; }
        public bool? McaUd2Bit { get; set; }
        public bool? McaUd3Bit { get; set; }
        public bool? McaUd4Bit { get; set; }
        public bool? McaUd5Bit { get; set; }
        public bool? McaUd6Bit { get; set; }
        public bool? McaUd7Bit { get; set; }
        public bool? McaUd8Bit { get; set; }
        public bool? McaUd9Bit { get; set; }
        public bool? McaUd10Bit { get; set; }
        public bool? McaUd11Bit { get; set; }
        public bool? McaUd12Bit { get; set; }
        public bool? McaUd13Bit { get; set; }
        public bool? McaUd14Bit { get; set; }
        public bool? McaUd15Bit { get; set; }
        public bool? McaUd16Bit { get; set; }
        public bool? McaUd17Bit { get; set; }
        public bool? McaUd18Bit { get; set; }
        public bool? McaUd19Bit { get; set; }
        public bool? McaUd20Bit { get; set; }
        public bool? McaUd21Bit { get; set; }
        public bool? McaUd22Bit { get; set; }
        public bool? McaUd23Bit { get; set; }
        public bool? McaUd24Bit { get; set; }
        public decimal? McaUd1Numeric { get; set; }
        public decimal? McaUd2Numeric { get; set; }
        public decimal? McaUd3Numeric { get; set; }
        public decimal? McaUd4Numeric { get; set; }
        public decimal? McaUd5Numeric { get; set; }
        public decimal? McaUd6Numeric { get; set; }
        public decimal? McaUd7Numeric { get; set; }
        public decimal? McaUd8Numeric { get; set; }
        public decimal? McaUd9Numeric { get; set; }
        public decimal? McaUd10Numeric { get; set; }
        public Guid? SgId { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }
        public string Details { get; set; }

        public virtual Site Sit { get; set; }
        public virtual User Us { get; set; }
        public virtual McaBit McaBit { get; set; }
        public virtual McaDate McaDate { get; set; }
        public virtual McaNum McaNum { get; set; }
        public virtual McaTxt McaTxt { get; set; }
        public virtual McaUid McaUid { get; set; }
        public virtual ICollection<MarketingCampaignStage> MarketingCampaignStages { get; set; }
        public virtual ICollection<Touchpoint> Touchpoints { get; set; }
    }
}
