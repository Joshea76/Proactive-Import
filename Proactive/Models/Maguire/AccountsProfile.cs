using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccountsProfile
    {
        public AccountsProfile()
        {
            Agreements = new HashSet<Agreement>();
        }

        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid AcpId { get; set; }
        public bool? AcpDeleted { get; set; }
        public Guid? Type { get; set; }
        public Guid? Label { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string AcpUd1Text { get; set; }
        public string AcpUd2Text { get; set; }
        public string AcpUd3Text { get; set; }
        public string AcpUd4Text { get; set; }
        public string AcpUd5Text { get; set; }
        public string AcpUd6Text { get; set; }
        public string AcpUd7Text { get; set; }
        public string AcpUd8Text { get; set; }
        public string AcpUd9Text { get; set; }
        public string AcpUd10Text { get; set; }
        public DateTime? AcpUd1Date { get; set; }
        public DateTime? AcpUd2Date { get; set; }
        public DateTime? AcpUd3Date { get; set; }
        public DateTime? AcpUd4Date { get; set; }
        public DateTime? AcpUd5Date { get; set; }
        public DateTime? AcpUd6Date { get; set; }
        public DateTime? AcpUd7Date { get; set; }
        public DateTime? AcpUd8Date { get; set; }
        public DateTime? AcpUd9Date { get; set; }
        public DateTime? AcpUd10Date { get; set; }
        public Guid? AcpUd1Id { get; set; }
        public Guid? AcpUd2Id { get; set; }
        public Guid? AcpUd3Id { get; set; }
        public Guid? AcpUd4Id { get; set; }
        public Guid? AcpUd5Id { get; set; }
        public Guid? AcpUd6Id { get; set; }
        public Guid? AcpUd7Id { get; set; }
        public Guid? AcpUd8Id { get; set; }
        public Guid? AcpUd9Id { get; set; }
        public Guid? AcpUd10Id { get; set; }
        public bool? AcpUd1Bit { get; set; }
        public bool? AcpUd2Bit { get; set; }
        public bool? AcpUd3Bit { get; set; }
        public bool? AcpUd4Bit { get; set; }
        public bool? AcpUd5Bit { get; set; }
        public bool? AcpUd6Bit { get; set; }
        public bool? AcpUd7Bit { get; set; }
        public bool? AcpUd8Bit { get; set; }
        public bool? AcpUd9Bit { get; set; }
        public bool? AcpUd10Bit { get; set; }
        public decimal? AcpUd1Numeric { get; set; }
        public decimal? AcpUd2Numeric { get; set; }
        public decimal? AcpUd3Numeric { get; set; }
        public decimal? AcpUd4Numeric { get; set; }
        public decimal? AcpUd5Numeric { get; set; }
        public decimal? AcpUd6Numeric { get; set; }
        public decimal? AcpUd7Numeric { get; set; }
        public decimal? AcpUd8Numeric { get; set; }
        public decimal? AcpUd9Numeric { get; set; }
        public decimal? AcpUd10Numeric { get; set; }
        public string AcpExternal { get; set; }
        public Guid? AcpImport { get; set; }
        public string Reference { get; set; }
        public bool? AcpUd11Bit { get; set; }
        public bool? AcpUd12Bit { get; set; }
        public bool? AcpUd13Bit { get; set; }
        public bool? AcpUd14Bit { get; set; }
        public bool? AcpUd15Bit { get; set; }
        public bool? AcpUd16Bit { get; set; }
        public bool? AcpUd17Bit { get; set; }
        public bool? AcpUd18Bit { get; set; }
        public bool? AcpUd19Bit { get; set; }
        public bool? AcpUd20Bit { get; set; }
        public bool? AcpUd21Bit { get; set; }
        public bool? AcpUd22Bit { get; set; }
        public bool? AcpUd23Bit { get; set; }
        public bool? AcpUd24Bit { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual AcpBit AcpBit { get; set; }
        public virtual AcpDate AcpDate { get; set; }
        public virtual AcpNum AcpNum { get; set; }
        public virtual AcpTxt AcpTxt { get; set; }
        public virtual AcpUid AcpUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
