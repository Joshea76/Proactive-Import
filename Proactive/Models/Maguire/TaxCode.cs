using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TaxCode
    {
        public TaxCode()
        {
            OpportunitiesQuotesDetails = new HashSet<OpportunitiesQuotesDetail>();
            Products = new HashSet<Product>();
            SeminarsBookingsProducts = new HashSet<SeminarsBookingsProduct>();
        }

        public Guid TxcId { get; set; }
        public bool? TxcDeleted { get; set; }
        public string Summary { get; set; }
        public string Code { get; set; }
        public decimal TaxPercentage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string TxcExternal { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual ICollection<OpportunitiesQuotesDetail> OpportunitiesQuotesDetails { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SeminarsBookingsProduct> SeminarsBookingsProducts { get; set; }
    }
}
