using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersAppointment
    {
        public UsersAppointment()
        {
            Agreements = new HashSet<Agreement>();
        }

        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? UsId { get; set; }
        public Guid UsaId { get; set; }
        public bool UsaDeleted { get; set; }
        public string UsaMapiId { get; set; }
        public string UsaStoreId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool? AllDay { get; set; }
        public string Location { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Ud1 { get; set; }
        public string Ud2 { get; set; }
        public string Ud3 { get; set; }
        public string Ud4 { get; set; }
        public string Ud5 { get; set; }
        public string Ud6 { get; set; }
        public string Ud7 { get; set; }
        public string Ud8 { get; set; }
        public string Ud9 { get; set; }
        public string Ud10 { get; set; }
        public string Ud11 { get; set; }
        public string Ud12 { get; set; }
        public string Ud13 { get; set; }
        public string Ud14 { get; set; }
        public string Ud15 { get; set; }
        public string ParentType { get; set; }
        public Guid? ActId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? PjId { get; set; }
        public bool? GoneFromOutlook { get; set; }
        public bool? Recurring { get; set; }
        public int? RecurrenceType { get; set; }
        public string RecurrenceInfo { get; set; }
        public DateTime? SyncUpdatedDate { get; set; }
        public Guid? NtIdOutlook { get; set; }
        public decimal? UsaUd1Numeric { get; set; }
        public decimal? UsaUd2Numeric { get; set; }
        public decimal? UsaUd3Numeric { get; set; }
        public decimal? UsaUd4Numeric { get; set; }
        public decimal? UsaUd5Numeric { get; set; }
        public decimal? UsaUd6Numeric { get; set; }
        public decimal? UsaUd7Numeric { get; set; }
        public decimal? UsaUd8Numeric { get; set; }
        public decimal? UsaUd9Numeric { get; set; }
        public decimal? UsaUd10Numeric { get; set; }
        public DateTime? UsaUd1Date { get; set; }
        public DateTime? UsaUd2Date { get; set; }
        public DateTime? UsaUd3Date { get; set; }
        public DateTime? UsaUd4Date { get; set; }
        public DateTime? UsaUd5Date { get; set; }
        public DateTime? UsaUd6Date { get; set; }
        public DateTime? UsaUd7Date { get; set; }
        public DateTime? UsaUd8Date { get; set; }
        public DateTime? UsaUd9Date { get; set; }
        public DateTime? UsaUd10Date { get; set; }
        public Guid? UsaUd1Id { get; set; }
        public Guid? UsaUd2Id { get; set; }
        public Guid? UsaUd3Id { get; set; }
        public Guid? UsaUd4Id { get; set; }
        public Guid? UsaUd5Id { get; set; }
        public Guid? UsaUd6Id { get; set; }
        public Guid? UsaUd7Id { get; set; }
        public Guid? UsaUd8Id { get; set; }
        public Guid? UsaUd9Id { get; set; }
        public Guid? UsaUd10Id { get; set; }
        public bool? UsaUd1Bit { get; set; }
        public bool? UsaUd2Bit { get; set; }
        public bool? UsaUd3Bit { get; set; }
        public bool? UsaUd4Bit { get; set; }
        public bool? UsaUd5Bit { get; set; }
        public bool? UsaUd6Bit { get; set; }
        public bool? UsaUd7Bit { get; set; }
        public bool? UsaUd8Bit { get; set; }
        public bool? UsaUd9Bit { get; set; }
        public bool? UsaUd10Bit { get; set; }
        public bool? UsaUd11Bit { get; set; }
        public bool? UsaUd12Bit { get; set; }
        public bool? UsaUd13Bit { get; set; }
        public bool? UsaUd14Bit { get; set; }
        public bool? UsaUd15Bit { get; set; }
        public bool? UsaUd16Bit { get; set; }
        public bool? UsaUd17Bit { get; set; }
        public bool? UsaUd18Bit { get; set; }
        public bool? UsaUd19Bit { get; set; }
        public bool? UsaUd20Bit { get; set; }
        public bool? UsaUd21Bit { get; set; }
        public bool? UsaUd22Bit { get; set; }
        public bool? UsaUd23Bit { get; set; }
        public bool? UsaUd24Bit { get; set; }
        public Guid? UsaType { get; set; }
        public int? ReminderMinutes { get; set; }
        public bool? ReminderAlerted { get; set; }
        public string Reference { get; set; }
        public bool? DoNotSyncWith3p { get; set; }
        public short? UsaAccessLevel { get; set; }
        public bool? UsaRemoved { get; set; }
        public bool UtcConverted { get; set; }
        public Guid? StgId { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public Guid? OwnerId { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual User Us { get; set; }
        public virtual UsaBit UsaBit { get; set; }
        public virtual UsaDate UsaDate { get; set; }
        public virtual UsaNum UsaNum { get; set; }
        public virtual UsaTxt UsaTxt { get; set; }
        public virtual UsaUid UsaUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
