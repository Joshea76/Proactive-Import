using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMailCampaignActivity
    {
        public Guid? AccId { get; set; }
        public Guid? AccaId { get; set; }
        public string Summary { get; set; }
        public string AccName { get; set; }
        public string Email1Address { get; set; }
        public string BusinessFaxNumber { get; set; }
        public string AccountName { get; set; }
        public string Stage { get; set; }
        public string StageHlight { get; set; }
        public Guid MacId { get; set; }
        public bool? Complete { get; set; }
        public string UsName { get; set; }
        public int Overdue { get; set; }
        public string AcTown { get; set; }
        public string AcPostcode { get; set; }
        public string AcBillingTown { get; set; }
        public string AcBillingPostcode { get; set; }
        public string Phone { get; set; }
    }
}
