﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Activity
    {
        public Activity()
        {
            Agreements = new HashSet<Agreement>();
            MarketingCampaignStageRunResults = new HashSet<MarketingCampaignStageRunResult>();
            TimeUnitsRecordAcas = new HashSet<TimeUnitsRecord>();
            TimeUnitsRecordAccas = new HashSet<TimeUnitsRecord>();
            TimeUnitsRecordOpas = new HashSet<TimeUnitsRecord>();
            TimeUnitsRecordPjas = new HashSet<TimeUnitsRecord>();
        }

        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? MacId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? PjId { get; set; }
        public Guid ActId { get; set; }
        public Guid? ParentId { get; set; }
        public bool? ActDeleted { get; set; }
        public bool? ActReadOnly { get; set; }
        public Guid? UsId { get; set; }
        public string ActivityType { get; set; }
        public Guid? Type { get; set; }
        public Guid? AccaStage { get; set; }
        public string Duration { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public double PercentComplete { get; set; }
        public bool Complete { get; set; }
        public string BillingInformation { get; set; }
        public byte Priority { get; set; }
        public byte Sensitivity { get; set; }
        public byte Status { get; set; }
        public bool Private { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string AcaUd1Text { get; set; }
        public string AcaUd2Text { get; set; }
        public string AcaUd3Text { get; set; }
        public string AcaUd4Text { get; set; }
        public string AcaUd5Text { get; set; }
        public string AcaUd6Text { get; set; }
        public string AcaUd7Text { get; set; }
        public string AcaUd8Text { get; set; }
        public string AcaUd9Text { get; set; }
        public string AcaUd10Text { get; set; }
        public DateTime? AcaUd1Date { get; set; }
        public DateTime? AcaUd2Date { get; set; }
        public DateTime? AcaUd3Date { get; set; }
        public DateTime? AcaUd4Date { get; set; }
        public DateTime? AcaUd5Date { get; set; }
        public DateTime? AcaUd6Date { get; set; }
        public DateTime? AcaUd7Date { get; set; }
        public DateTime? AcaUd8Date { get; set; }
        public DateTime? AcaUd9Date { get; set; }
        public DateTime? AcaUd10Date { get; set; }
        public Guid? AcaUd1Id { get; set; }
        public Guid? AcaUd2Id { get; set; }
        public Guid? AcaUd3Id { get; set; }
        public Guid? AcaUd4Id { get; set; }
        public Guid? AcaUd5Id { get; set; }
        public Guid? AcaUd6Id { get; set; }
        public Guid? AcaUd7Id { get; set; }
        public Guid? AcaUd8Id { get; set; }
        public Guid? AcaUd9Id { get; set; }
        public Guid? AcaUd10Id { get; set; }
        public bool? AcaUd1Bit { get; set; }
        public bool? AcaUd2Bit { get; set; }
        public bool? AcaUd3Bit { get; set; }
        public bool? AcaUd4Bit { get; set; }
        public bool? AcaUd5Bit { get; set; }
        public bool? AcaUd6Bit { get; set; }
        public bool? AcaUd7Bit { get; set; }
        public bool? AcaUd8Bit { get; set; }
        public bool? AcaUd9Bit { get; set; }
        public bool? AcaUd10Bit { get; set; }
        public decimal? AcaUd1Numeric { get; set; }
        public decimal? AcaUd2Numeric { get; set; }
        public decimal? AcaUd3Numeric { get; set; }
        public decimal? AcaUd4Numeric { get; set; }
        public decimal? AcaUd5Numeric { get; set; }
        public decimal? AcaUd6Numeric { get; set; }
        public decimal? AcaUd7Numeric { get; set; }
        public decimal? AcaUd8Numeric { get; set; }
        public decimal? AcaUd9Numeric { get; set; }
        public decimal? AcaUd10Numeric { get; set; }
        public string AccaUd1Text { get; set; }
        public string AccaUd2Text { get; set; }
        public string AccaUd3Text { get; set; }
        public string AccaUd4Text { get; set; }
        public string AccaUd5Text { get; set; }
        public string AccaUd6Text { get; set; }
        public string AccaUd7Text { get; set; }
        public string AccaUd8Text { get; set; }
        public string AccaUd9Text { get; set; }
        public string AccaUd10Text { get; set; }
        public DateTime? AccaUd1Date { get; set; }
        public DateTime? AccaUd2Date { get; set; }
        public DateTime? AccaUd3Date { get; set; }
        public DateTime? AccaUd4Date { get; set; }
        public DateTime? AccaUd5Date { get; set; }
        public DateTime? AccaUd6Date { get; set; }
        public DateTime? AccaUd7Date { get; set; }
        public DateTime? AccaUd8Date { get; set; }
        public DateTime? AccaUd9Date { get; set; }
        public DateTime? AccaUd10Date { get; set; }
        public Guid? AccaUd1Id { get; set; }
        public Guid? AccaUd2Id { get; set; }
        public Guid? AccaUd3Id { get; set; }
        public Guid? AccaUd4Id { get; set; }
        public Guid? AccaUd5Id { get; set; }
        public Guid? AccaUd6Id { get; set; }
        public Guid? AccaUd7Id { get; set; }
        public Guid? AccaUd8Id { get; set; }
        public Guid? AccaUd9Id { get; set; }
        public Guid? AccaUd10Id { get; set; }
        public bool? AccaUd1Bit { get; set; }
        public bool? AccaUd2Bit { get; set; }
        public bool? AccaUd3Bit { get; set; }
        public bool? AccaUd4Bit { get; set; }
        public bool? AccaUd5Bit { get; set; }
        public bool? AccaUd6Bit { get; set; }
        public bool? AccaUd7Bit { get; set; }
        public bool? AccaUd8Bit { get; set; }
        public bool? AccaUd9Bit { get; set; }
        public bool? AccaUd10Bit { get; set; }
        public decimal? AccaUd1Numeric { get; set; }
        public decimal? AccaUd2Numeric { get; set; }
        public decimal? AccaUd3Numeric { get; set; }
        public decimal? AccaUd4Numeric { get; set; }
        public decimal? AccaUd5Numeric { get; set; }
        public decimal? AccaUd6Numeric { get; set; }
        public decimal? AccaUd7Numeric { get; set; }
        public decimal? AccaUd8Numeric { get; set; }
        public decimal? AccaUd9Numeric { get; set; }
        public decimal? AccaUd10Numeric { get; set; }
        public string OpaUd1Text { get; set; }
        public string OpaUd2Text { get; set; }
        public string OpaUd3Text { get; set; }
        public string OpaUd4Text { get; set; }
        public string OpaUd5Text { get; set; }
        public string OpaUd6Text { get; set; }
        public string OpaUd7Text { get; set; }
        public string OpaUd8Text { get; set; }
        public string OpaUd9Text { get; set; }
        public string OpaUd10Text { get; set; }
        public DateTime? OpaUd1Date { get; set; }
        public DateTime? OpaUd2Date { get; set; }
        public DateTime? OpaUd3Date { get; set; }
        public DateTime? OpaUd4Date { get; set; }
        public DateTime? OpaUd5Date { get; set; }
        public DateTime? OpaUd6Date { get; set; }
        public DateTime? OpaUd7Date { get; set; }
        public DateTime? OpaUd8Date { get; set; }
        public DateTime? OpaUd9Date { get; set; }
        public DateTime? OpaUd10Date { get; set; }
        public Guid? OpaUd1Id { get; set; }
        public Guid? OpaUd2Id { get; set; }
        public Guid? OpaUd3Id { get; set; }
        public Guid? OpaUd4Id { get; set; }
        public Guid? OpaUd5Id { get; set; }
        public Guid? OpaUd6Id { get; set; }
        public Guid? OpaUd7Id { get; set; }
        public Guid? OpaUd8Id { get; set; }
        public Guid? OpaUd9Id { get; set; }
        public Guid? OpaUd10Id { get; set; }
        public bool? OpaUd1Bit { get; set; }
        public bool? OpaUd2Bit { get; set; }
        public bool? OpaUd3Bit { get; set; }
        public bool? OpaUd4Bit { get; set; }
        public bool? OpaUd5Bit { get; set; }
        public bool? OpaUd6Bit { get; set; }
        public bool? OpaUd7Bit { get; set; }
        public bool? OpaUd8Bit { get; set; }
        public bool? OpaUd9Bit { get; set; }
        public bool? OpaUd10Bit { get; set; }
        public decimal? OpaUd1Numeric { get; set; }
        public decimal? OpaUd2Numeric { get; set; }
        public decimal? OpaUd3Numeric { get; set; }
        public decimal? OpaUd4Numeric { get; set; }
        public decimal? OpaUd5Numeric { get; set; }
        public decimal? OpaUd6Numeric { get; set; }
        public decimal? OpaUd7Numeric { get; set; }
        public decimal? OpaUd8Numeric { get; set; }
        public decimal? OpaUd9Numeric { get; set; }
        public decimal? OpaUd10Numeric { get; set; }
        public string PjaUd1Text { get; set; }
        public string PjaUd2Text { get; set; }
        public string PjaUd3Text { get; set; }
        public string PjaUd4Text { get; set; }
        public string PjaUd5Text { get; set; }
        public string PjaUd6Text { get; set; }
        public string PjaUd7Text { get; set; }
        public string PjaUd8Text { get; set; }
        public string PjaUd9Text { get; set; }
        public string PjaUd10Text { get; set; }
        public DateTime? PjaUd1Date { get; set; }
        public DateTime? PjaUd2Date { get; set; }
        public DateTime? PjaUd3Date { get; set; }
        public DateTime? PjaUd4Date { get; set; }
        public DateTime? PjaUd5Date { get; set; }
        public DateTime? PjaUd6Date { get; set; }
        public DateTime? PjaUd7Date { get; set; }
        public DateTime? PjaUd8Date { get; set; }
        public DateTime? PjaUd9Date { get; set; }
        public DateTime? PjaUd10Date { get; set; }
        public Guid? PjaUd1Id { get; set; }
        public Guid? PjaUd2Id { get; set; }
        public Guid? PjaUd3Id { get; set; }
        public Guid? PjaUd4Id { get; set; }
        public Guid? PjaUd5Id { get; set; }
        public Guid? PjaUd6Id { get; set; }
        public Guid? PjaUd7Id { get; set; }
        public Guid? PjaUd8Id { get; set; }
        public Guid? PjaUd9Id { get; set; }
        public Guid? PjaUd10Id { get; set; }
        public bool? PjaUd1Bit { get; set; }
        public bool? PjaUd2Bit { get; set; }
        public bool? PjaUd3Bit { get; set; }
        public bool? PjaUd4Bit { get; set; }
        public bool? PjaUd5Bit { get; set; }
        public bool? PjaUd6Bit { get; set; }
        public bool? PjaUd7Bit { get; set; }
        public bool? PjaUd8Bit { get; set; }
        public bool? PjaUd9Bit { get; set; }
        public bool? PjaUd10Bit { get; set; }
        public decimal? PjaUd1Numeric { get; set; }
        public decimal? PjaUd2Numeric { get; set; }
        public decimal? PjaUd3Numeric { get; set; }
        public decimal? PjaUd4Numeric { get; set; }
        public decimal? PjaUd5Numeric { get; set; }
        public decimal? PjaUd6Numeric { get; set; }
        public decimal? PjaUd7Numeric { get; set; }
        public decimal? PjaUd8Numeric { get; set; }
        public decimal? PjaUd9Numeric { get; set; }
        public decimal? PjaUd10Numeric { get; set; }
        public string ActExternal { get; set; }
        public Guid? ActImport { get; set; }
        public bool Exported { get; set; }
        public int? AccaNumber { get; set; }
        public Guid? McrId { get; set; }
        public string Reference { get; set; }
        public bool? Reminder { get; set; }
        public bool? ReminderAlerted { get; set; }
        public DateTime? SyncUpdatedDate { get; set; }
        public Guid? NtIdOutlook { get; set; }
        public Guid? SemId { get; set; }
        public int? ReminderMinutes { get; set; }
        public bool? ShowOnCalendar { get; set; }
        public Guid? StgId { get; set; }
        public int ShortCode { get; set; }
        public int EstimatedUnits { get; set; }
        public int EstimatedTime { get; set; }
        public int ActualUnits { get; set; }
        public int ActualTime { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual MailCampaign Mac { get; set; }
        public virtual Site Sit { get; set; }
        public virtual User Us { get; set; }
        public virtual AcaBit AcaBit { get; set; }
        public virtual AcaDate AcaDate { get; set; }
        public virtual AcaNum AcaNum { get; set; }
        public virtual AcaTxt AcaTxt { get; set; }
        public virtual AcaUid AcaUid { get; set; }
        public virtual AccaBit AccaBit { get; set; }
        public virtual AccaDate AccaDate { get; set; }
        public virtual AccaNum AccaNum { get; set; }
        public virtual AccaTxt AccaTxt { get; set; }
        public virtual AccaUid AccaUid { get; set; }
        public virtual OpaBit OpaBit { get; set; }
        public virtual OpaDate OpaDate { get; set; }
        public virtual OpaNum OpaNum { get; set; }
        public virtual OpaTxt OpaTxt { get; set; }
        public virtual OpaUid OpaUid { get; set; }
        public virtual PjaBit PjaBit { get; set; }
        public virtual PjaDate PjaDate { get; set; }
        public virtual PjaNum PjaNum { get; set; }
        public virtual PjaTxt PjaTxt { get; set; }
        public virtual PjaUid PjaUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<MarketingCampaignStageRunResult> MarketingCampaignStageRunResults { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecordAcas { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecordAccas { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecordOpas { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecordPjas { get; set; }
    }
}
