using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VCampaignAllRecipient
    {
        public Guid AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid MacId { get; set; }
        public string Summary { get; set; }
        public string AcName { get; set; }
        public Guid? UsIdSales { get; set; }
        public string AccName { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int MaccuDeleted { get; set; }
        public string AcManager { get; set; }
        public int? McsCount { get; set; }
        public string MaccuId { get; set; }
        public int? MacMedium { get; set; }
        public string DefaultSalutation { get; set; }
        public string Invalid { get; set; }
        public string AcGroup { get; set; }
        public Guid? AcgId { get; set; }
        public string Jobtitle { get; set; }
        public bool? IsNew { get; set; }
    }
}
