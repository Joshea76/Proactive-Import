using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaignsRun
    {
        public MailCampaignsRun()
        {
            MailCampaignsAccounts = new HashSet<MailCampaignsAccount>();
        }

        public Guid McrId { get; set; }
        public Guid? MacId { get; set; }
        public DateTime? RunDate { get; set; }
        public int? SendCount { get; set; }
        public int? MacMedium { get; set; }
        public bool? Csv { get; set; }
        public Guid? MacStage { get; set; }
        public bool? GvConnect { get; set; }
        public bool? PendingActivities { get; set; }
        public Guid? AccaOwner { get; set; }
        public bool? UsIdSales { get; set; }
        public Guid? AccaStage { get; set; }
        public DateTime? AccaStartDate { get; set; }
        public DateTime? AccaDueDate { get; set; }
        public bool? NewOnly { get; set; }
        public string RunBy { get; set; }
        public byte? GvConnectUploaded { get; set; }
        public DateTime? GvConnectUploadedDate { get; set; }
        public string GvConnectUploadedBy { get; set; }
        public Guid? GvConnectUploadedId { get; set; }
        public string GvConnectUploadedMsg { get; set; }
        public Guid? MacType { get; set; }
        public byte? ConnectOptInType { get; set; }

        public virtual MailCampaign Mac { get; set; }
        public virtual ICollection<MailCampaignsAccount> MailCampaignsAccounts { get; set; }
    }
}
