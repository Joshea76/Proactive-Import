using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Delv1
    {
        public Guid? AcgId { get; set; }
        public Guid AcId { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Phone1 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddress3 { get; set; }
        public string BillingTown { get; set; }
        public string BillingCounty { get; set; }
        public string BillingPostCode { get; set; }
        public string BillingCountry { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string WebSite1 { get; set; }
        public bool? AcDeleted { get; set; }
    }
}
