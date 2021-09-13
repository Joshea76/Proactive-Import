﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccountsContact
    {
        public AccountsContact()
        {
            AccountsProfiles = new HashSet<AccountsProfile>();
            Activities = new HashSet<Activity>();
            Agreements = new HashSet<Agreement>();
            CallLogs = new HashSet<CallLog>();
            ContactSyncContacts = new HashSet<ContactSyncContact>();
            ContactSyncDates = new HashSet<ContactSyncDate>();
            CorrespondenceRecipients = new HashSet<CorrespondenceRecipient>();
            Correspondences = new HashSet<Correspondence>();
            LmContactSpines = new HashSet<LmContactSpine>();
            MailCampaignsContactsSentClicks = new HashSet<MailCampaignsContactsSentClick>();
            MarketingCampaignStageRunResults = new HashSet<MarketingCampaignStageRunResult>();
            MarketingSourceRules = new HashSet<MarketingSourceRule>();
            Notes = new HashSet<Note>();
            Opportunities = new HashSet<Opportunity>();
            OpportunitiesQuotes = new HashSet<OpportunitiesQuote>();
            Projects = new HashSet<Project>();
            SeminarsBookings = new HashSet<SeminarsBooking>();
            SeminarsBookingsAttendees = new HashSet<SeminarsBookingsAttendee>();
        }

        public Guid? AcId { get; set; }
        public Guid AccId { get; set; }
        public bool? AccDeleted { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public string Account { get; set; }
        public string Anniversary { get; set; }
        public string Assistantname { get; set; }
        public string AssistantTelephoneNumber { get; set; }
        public string Birthday { get; set; }
        public string BillingInformation { get; set; }
        public string Business2TelephoneNumber { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressCountry { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string BusinessAddressPostOfficeBox { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressStreet2 { get; set; }
        public string BusinessAddressStreet3 { get; set; }
        public string BusinessFaxNumber { get; set; }
        public string BusinessHomePage { get; set; }
        public string BusinessTelephoneNumber { get; set; }
        public string CallbackTelephoneNumber { get; set; }
        public string CarTelephoneNumber { get; set; }
        public string Categories { get; set; }
        public string Children { get; set; }
        public string Companies { get; set; }
        public string CompanyAndFullName { get; set; }
        public string CompanyLastFirstNoSpace { get; set; }
        public string CompanyLastFirstSpaceOnly { get; set; }
        public string CompanyMainTelephoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string ComputerNetworkName { get; set; }
        public string CreationTime { get; set; }
        public string Department { get; set; }
        public string Email1Address { get; set; }
        public string Email1AddressType { get; set; }
        public string Email1DisplayName { get; set; }
        public string Email1EntryId { get; set; }
        public string Email2Address { get; set; }
        public string Email2AddressType { get; set; }
        public string Email2DisplayName { get; set; }
        public string Email2EntryId { get; set; }
        public string Email3Address { get; set; }
        public string Email3AddressType { get; set; }
        public string Email3DisplayName { get; set; }
        public string Email3EntryId { get; set; }
        public string FirstName { get; set; }
        public string Ftpsite { get; set; }
        public string FullName { get; set; }
        public string FullNameAndCompany { get; set; }
        public string Hobby { get; set; }
        public string Home2TelephoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressCountry { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string HomeAddressPostOfficeBox { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressStreet2 { get; set; }
        public string HomeAddressStreet3 { get; set; }
        public string HomeFaxNumber { get; set; }
        public string HomeTelephoneNumber { get; set; }
        public string Initials { get; set; }
        public string InternetFreeBusyAddress { get; set; }
        public string Isdnnumber { get; set; }
        public string JobTitle { get; set; }
        public string LastFirstAndSuffix { get; set; }
        public string LastFirstNoSpaceCompany { get; set; }
        public string LastFirstSpaceOnly { get; set; }
        public string LastFirstSpaceOnlyCompany { get; set; }
        public string LastModificationTime { get; set; }
        public string LastName { get; set; }
        public string LastNameAndFirstName { get; set; }
        public string MailingAddress { get; set; }
        public string MailingAddressCity { get; set; }
        public string MailingAddressCountry { get; set; }
        public string MailingAddressPostalCode { get; set; }
        public string MailingAddressPostOfficeBox { get; set; }
        public string MailingAddressState { get; set; }
        public string MailingAddressStreet { get; set; }
        public string MailingAddressStreet2 { get; set; }
        public string MailingAddressStreet3 { get; set; }
        public string ManagerName { get; set; }
        public string MiddleName { get; set; }
        public string Mileage { get; set; }
        public string MobileTelephoneNumber { get; set; }
        public string NetMeetingAlias { get; set; }
        public string NetMeetingServer { get; set; }
        public string NickName { get; set; }
        public string OfficeLocation { get; set; }
        public string OtherAddress { get; set; }
        public string OtherAddressCity { get; set; }
        public string OtherAddressCountry { get; set; }
        public string OtherAddressPostalCode { get; set; }
        public string OtherAddressPostOfficeBox { get; set; }
        public string OtherAddressState { get; set; }
        public string OtherAddressStreet { get; set; }
        public string OtherAddressStreet2 { get; set; }
        public string OtherAddressStreet3 { get; set; }
        public string OtherFaxNumber { get; set; }
        public string OtherTelephoneNumber { get; set; }
        public string PersonalHomePage { get; set; }
        public string PrimaryTelephoneNumber { get; set; }
        public string Profession { get; set; }
        public string RadioTelephoneNumber { get; set; }
        public string ReferredBy { get; set; }
        public string SelectedMailingAddress { get; set; }
        public string Sensitivity { get; set; }
        public string Spouse { get; set; }
        public string Subject { get; set; }
        public string Suffix { get; set; }
        public string TelexNumber { get; set; }
        public string Title { get; set; }
        public string TtytddtelephoneNumber { get; set; }
        public string WebPage { get; set; }
        public string YomiCompanyName { get; set; }
        public string YomiFirstName { get; set; }
        public string YomiLastName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string AccUd1 { get; set; }
        public string AccUd2 { get; set; }
        public string AccUd3 { get; set; }
        public string AccUd4 { get; set; }
        public string AccUd5 { get; set; }
        public string AccUd6 { get; set; }
        public string AccUd7 { get; set; }
        public string AccUd8 { get; set; }
        public string AccUd9 { get; set; }
        public string AccUd10 { get; set; }
        public string AccUd11 { get; set; }
        public string AccUd12 { get; set; }
        public string AccUd13 { get; set; }
        public string AccUd14 { get; set; }
        public string AccUd15 { get; set; }
        public Guid? AccUd1Id { get; set; }
        public Guid? AccUd2Id { get; set; }
        public Guid? AccUd3Id { get; set; }
        public Guid? AccUd4Id { get; set; }
        public Guid? AccUd5Id { get; set; }
        public Guid? AccUd6Id { get; set; }
        public Guid? AccUd7Id { get; set; }
        public Guid? AccUd8Id { get; set; }
        public Guid? AccUd9Id { get; set; }
        public Guid? AccUd10Id { get; set; }
        public DateTime? AccUd1Date { get; set; }
        public DateTime? AccUd2Date { get; set; }
        public DateTime? AccUd3Date { get; set; }
        public DateTime? AccUd4Date { get; set; }
        public DateTime? AccUd5Date { get; set; }
        public DateTime? AccUd6Date { get; set; }
        public DateTime? AccUd7Date { get; set; }
        public DateTime? AccUd8Date { get; set; }
        public DateTime? AccUd9Date { get; set; }
        public DateTime? AccUd10Date { get; set; }
        public bool? AccUd1Bit { get; set; }
        public bool? AccUd2Bit { get; set; }
        public bool? AccUd3Bit { get; set; }
        public bool? AccUd4Bit { get; set; }
        public bool? AccUd5Bit { get; set; }
        public bool? AccUd6Bit { get; set; }
        public bool? AccUd7Bit { get; set; }
        public bool? AccUd8Bit { get; set; }
        public bool? AccUd9Bit { get; set; }
        public bool? AccUd10Bit { get; set; }
        public decimal? AccUd1Numeric { get; set; }
        public decimal? AccUd2Numeric { get; set; }
        public decimal? AccUd3Numeric { get; set; }
        public decimal? AccUd4Numeric { get; set; }
        public decimal? AccUd5Numeric { get; set; }
        public decimal? AccUd6Numeric { get; set; }
        public decimal? AccUd7Numeric { get; set; }
        public decimal? AccUd8Numeric { get; set; }
        public decimal? AccUd9Numeric { get; set; }
        public decimal? AccUd10Numeric { get; set; }
        public bool? PreferredContactEmail { get; set; }
        public bool? PreferredContactFax { get; set; }
        public bool? PreferredContactPhone { get; set; }
        public bool? PreferredContactLetter { get; set; }
        public string AccExternal { get; set; }
        public Guid? AccImport { get; set; }
        public int? PreferredContact { get; set; }
        public bool Exported { get; set; }
        public string Salutation { get; set; }
        public bool? AccDormant { get; set; }
        public Guid? AccStatus { get; set; }
        public string Reference { get; set; }
        public bool? AccUd11Bit { get; set; }
        public bool? AccUd12Bit { get; set; }
        public bool? AccUd13Bit { get; set; }
        public bool? AccUd14Bit { get; set; }
        public bool? AccUd15Bit { get; set; }
        public bool? AccUd16Bit { get; set; }
        public bool? AccUd17Bit { get; set; }
        public bool? AccUd18Bit { get; set; }
        public bool? AccUd19Bit { get; set; }
        public bool? AccUd20Bit { get; set; }
        public bool? AccUd21Bit { get; set; }
        public bool? AccUd22Bit { get; set; }
        public bool? AccUd23Bit { get; set; }
        public bool? AccUd24Bit { get; set; }
        public DateTime? SyncUpdatedDate { get; set; }
        public Guid? NtIdOutlook { get; set; }
        public Guid? UsId { get; set; }
        public byte? PrefPhone { get; set; }
        public byte? PrefAddress { get; set; }
        public byte? PrefEmail { get; set; }
        public string LinkedinName { get; set; }
        public bool? ConnectOptIn { get; set; }
        public bool? PrivacyNotified { get; set; }
        public DateTime? PrivacyNotifiedDate { get; set; }
        public string PrivacyNotifiedBy { get; set; }
        public string PrivacyNotifiedMethod { get; set; }
        public DateTime? RemovalDate { get; set; }
        public bool? Erased { get; set; }
        public DateTime? ErasedDate { get; set; }
        public string ErasedBy { get; set; }
        public DateTime? ConnectOptInDate { get; set; }
        public int ShortCode { get; set; }
        public Guid? BusinessSitId { get; set; }
        public bool? SyncedWithPortal { get; set; }
        public string ShortCodePrefix { get; set; }
        public bool? MultiAccountAccess { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccBit AccBit { get; set; }
        public virtual AccDate AccDate { get; set; }
        public virtual AccNum AccNum { get; set; }
        public virtual AccTxt AccTxt { get; set; }
        public virtual AccUid AccUid { get; set; }
        public virtual ICollection<AccountsProfile> AccountsProfiles { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<CallLog> CallLogs { get; set; }
        public virtual ICollection<ContactSyncContact> ContactSyncContacts { get; set; }
        public virtual ICollection<ContactSyncDate> ContactSyncDates { get; set; }
        public virtual ICollection<CorrespondenceRecipient> CorrespondenceRecipients { get; set; }
        public virtual ICollection<Correspondence> Correspondences { get; set; }
        public virtual ICollection<LmContactSpine> LmContactSpines { get; set; }
        public virtual ICollection<MailCampaignsContactsSentClick> MailCampaignsContactsSentClicks { get; set; }
        public virtual ICollection<MarketingCampaignStageRunResult> MarketingCampaignStageRunResults { get; set; }
        public virtual ICollection<MarketingSourceRule> MarketingSourceRules { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<OpportunitiesQuote> OpportunitiesQuotes { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SeminarsBooking> SeminarsBookings { get; set; }
        public virtual ICollection<SeminarsBookingsAttendee> SeminarsBookingsAttendees { get; set; }
    }
}
