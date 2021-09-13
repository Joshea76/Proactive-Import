﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmContactSpine
    {
        public LmContactSpine()
        {
            LmCallLogs = new HashSet<LmCallLog>();
            LmDeduplicationItems = new HashSet<LmDeduplicationItem>();
            LmDeduplicationQueues = new HashSet<LmDeduplicationQueue>();
            LmDuplicateEntityCsId1Navigations = new HashSet<LmDuplicateEntity>();
            LmDuplicateEntityCsId2Navigations = new HashSet<LmDuplicateEntity>();
            LmMailRunClickdata = new HashSet<LmMailRunClickdatum>();
            LmMailRunRecipients = new HashSet<LmMailRunRecipient>();
            LmNotes = new HashSet<LmNote>();
            SeminarsBookingsAttendees = new HashSet<SeminarsBookingsAttendee>();
        }

        public int CsId { get; set; }
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public string Summary { get; set; }
        public bool CsDeleted { get; set; }
        public bool CsMigrated { get; set; }
        public bool? CsDiscarded { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? MigratedDate { get; set; }
        public string MigratedBy { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string AssignedBy { get; set; }
        public DateTime? LastactionDate { get; set; }
        public string LastactionBy { get; set; }
        public Guid? LastactionById { get; set; }
        public string ContactFirstname { get; set; }
        public string ContactLastname { get; set; }
        public string ContactFirstnameSoundex { get; set; }
        public string ContactLastnameSoundex { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPhoneDd { get; set; }
        public string ContactMobile { get; set; }
        public string ContactMobileDd { get; set; }
        public string ContactEmail { get; set; }
        public string ContactEmailDd { get; set; }
        public string ContactSoundex { get; set; }
        public string ContactTitle { get; set; }
        public string ContactJobtitle { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebdomain { get; set; }
        public string CompanyWebdomainDd { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyAddress3 { get; set; }
        public string CompanyTown { get; set; }
        public string CompanyCounty { get; set; }
        public string CompanyPostcode { get; set; }
        public string CompanyPostcodeDd { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyLongestword { get; set; }
        public string CompanySoundex { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyPhoneDd { get; set; }
        public int? LsId { get; set; }
        public int? LcId { get; set; }
        public Guid? UsIdOwner { get; set; }
        public Guid? UsgIdOwner { get; set; }
        public int? DuplicateCount { get; set; }
        public int? DuplicateScore { get; set; }
        public DateTime? CallbackDate { get; set; }
        public bool? PendingUpgrade { get; set; }
        public bool? PreferredContactEmail { get; set; }
        public bool? PreferredContactFax { get; set; }
        public bool? PreferredContactPhone { get; set; }
        public bool? PreferredContactLetter { get; set; }
        public bool? ConnectOptIn { get; set; }
        public string Status { get; set; }
        public Guid? BatchId { get; set; }
        public int? TimeSpentSecs { get; set; }
        public string LinkedinPublicId { get; set; }
        public string LinkedinPrivateId { get; set; }
        public string LinkedinProfileUrl { get; set; }
        public string LinkedinImage { get; set; }
        public string LinkedinName { get; set; }
        public string FacebookPublicId { get; set; }
        public string FacebookPrivateId { get; set; }
        public string FacebookProfileUrl { get; set; }
        public string FacebookImage { get; set; }
        public string FacebookName { get; set; }
        public string GplusPublicId { get; set; }
        public string GplusPrivateId { get; set; }
        public string GplusProfileUrl { get; set; }
        public string GplusImage { get; set; }
        public string GplusName { get; set; }
        public string Twitter1PublicId { get; set; }
        public string Twitter1PrivateId { get; set; }
        public string Twitter1ProfileUrl { get; set; }
        public string Twitter1Image { get; set; }
        public string Twitter1Name { get; set; }
        public string Twitter2PublicId { get; set; }
        public string Twitter2PrivateId { get; set; }
        public string Twitter2ProfileUrl { get; set; }
        public string Twitter2Image { get; set; }
        public string Twitter2Name { get; set; }
        public string Twitter3PublicId { get; set; }
        public string Twitter3PrivateId { get; set; }
        public string Twitter3ProfileUrl { get; set; }
        public string Twitter3Image { get; set; }
        public string Twitter3Name { get; set; }
        public string Twitter4PublicId { get; set; }
        public string Twitter4PrivateId { get; set; }
        public string Twitter4ProfileUrl { get; set; }
        public string Twitter4Image { get; set; }
        public string Twitter4Name { get; set; }
        public string Twitter5PublicId { get; set; }
        public string Twitter5PrivateId { get; set; }
        public string Twitter5ProfileUrl { get; set; }
        public string Twitter5Image { get; set; }
        public string Twitter5Name { get; set; }
        public bool? PotentialAccount { get; set; }
        public bool? PrivacyNotified { get; set; }
        public DateTime? PrivacyNotifiedDate { get; set; }
        public string PrivacyNotifiedBy { get; set; }
        public string PrivacyNotifiedMethod { get; set; }
        public DateTime? RemovalDate { get; set; }
        public bool? Erased { get; set; }
        public DateTime? ErasedDate { get; set; }
        public string ErasedBy { get; set; }
        public DateTime? ConnectOptInDate { get; set; }
        public Guid? StatusId { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual User UsIdOwnerNavigation { get; set; }
        public virtual UsersGroup UsgIdOwnerNavigation { get; set; }
        public virtual ICollection<LmCallLog> LmCallLogs { get; set; }
        public virtual ICollection<LmDeduplicationItem> LmDeduplicationItems { get; set; }
        public virtual ICollection<LmDeduplicationQueue> LmDeduplicationQueues { get; set; }
        public virtual ICollection<LmDuplicateEntity> LmDuplicateEntityCsId1Navigations { get; set; }
        public virtual ICollection<LmDuplicateEntity> LmDuplicateEntityCsId2Navigations { get; set; }
        public virtual ICollection<LmMailRunClickdatum> LmMailRunClickdata { get; set; }
        public virtual ICollection<LmMailRunRecipient> LmMailRunRecipients { get; set; }
        public virtual ICollection<LmNote> LmNotes { get; set; }
        public virtual ICollection<SeminarsBookingsAttendee> SeminarsBookingsAttendees { get; set; }
    }
}
