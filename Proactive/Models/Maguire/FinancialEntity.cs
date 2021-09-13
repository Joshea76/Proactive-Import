using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class FinancialEntity
    {
        public FinancialEntity()
        {
            Currencies = new HashSet<Currency>();
            IntegrationIds = new HashSet<IntegrationId>();
            Jobs = new HashSet<Job>();
            OpportunitiesQuotes = new HashSet<OpportunitiesQuote>();
            Products = new HashSet<Product>();
            SeminarsBookings = new HashSet<SeminarsBooking>();
        }

        public Guid FneId { get; set; }
        public string Summary { get; set; }
        public string FneExternal { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? FneDeleted { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual ICollection<Currency> Currencies { get; set; }
        public virtual ICollection<IntegrationId> IntegrationIds { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<OpportunitiesQuote> OpportunitiesQuotes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SeminarsBooking> SeminarsBookings { get; set; }
    }
}
