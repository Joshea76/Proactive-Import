using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMailCampaignContact
    {
        public Guid? AccId { get; set; }
        public string FullName { get; set; }
        public string Email1Address { get; set; }
        public string BusinessFaxNumber { get; set; }
        public string AccountName { get; set; }
        public Guid MacId { get; set; }
    }
}
