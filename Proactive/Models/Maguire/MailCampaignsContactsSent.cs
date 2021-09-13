using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaignsContactsSent
    {
        public MailCampaignsContactsSent()
        {
            MailCampaignsContactsSentClicks = new HashSet<MailCampaignsContactsSentClick>();
        }

        public Guid MacId { get; set; }
        public Guid MaccsId { get; set; }
        public Guid? McrId { get; set; }
        public Guid AcId { get; set; }
        public Guid AccId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressStreet2 { get; set; }
        public string BusinessAddressStreet3 { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string BusinessAddressCountry { get; set; }
        public string Email1Address { get; set; }
        public string BusinessFaxNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string AcName { get; set; }
        public string AccName { get; set; }
        public string UsName { get; set; }
        public string JobTitle { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressStreet2 { get; set; }
        public string HomeAddressStreet3 { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressPostalCode { get; set; }
        public string HomeAddressCountry { get; set; }
        public string Department { get; set; }
        public string WebPage { get; set; }
        public string MiddleName { get; set; }
        public string Email2Address { get; set; }
        public string Email3Address { get; set; }
        public string Phone1 { get; set; }
        public string Fax1 { get; set; }
        public string BusinessTelephoneNumber { get; set; }
        public string ManagerName { get; set; }
        public string HomeTelephoneNumber { get; set; }
        public string HomeFaxNumber { get; set; }
        public DateTime? GvcSentDate { get; set; }
        public bool? GvcSentFlag { get; set; }
        public DateTime? GvcReadDate { get; set; }
        public bool? GvcReadFlag { get; set; }
        public DateTime? GvcClickedThruDate { get; set; }
        public bool? GvcClickedThruFlag { get; set; }
        public DateTime? GvcUnsubDate { get; set; }
        public bool? GvcUnsubThis { get; set; }
        public bool? GvcUnsubAll { get; set; }
        public bool? GvcRepliedFlag { get; set; }
        public short? GvcRepliedCount { get; set; }
        public DateTime? GvcRepliedDate { get; set; }
        public bool? GvcForwardFlag { get; set; }
        public short? GvcForwardCount { get; set; }
        public DateTime? GvcForwardDate { get; set; }
        public bool? GvcBounceFlag { get; set; }
        public string GvcBounceCode { get; set; }
        public string GvcBounceText { get; set; }
        public int IMaccsId { get; set; }

        public virtual MailCampaign Mac { get; set; }
        public virtual ICollection<MailCampaignsContactsSentClick> MailCampaignsContactsSentClicks { get; set; }
    }
}
