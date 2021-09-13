﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Product
    {
        public Product()
        {
            OpportunitiesQuotesDetails = new HashSet<OpportunitiesQuotesDetail>();
            ProductsCurrencies = new HashSet<ProductsCurrency>();
            ProductsSchedules = new HashSet<ProductsSchedule>();
            SeminarsBookingsProducts = new HashSet<SeminarsBookingsProduct>();
            SeminarsProducts = new HashSet<SeminarsProduct>();
            SeminarsSessionsProducts = new HashSet<SeminarsSessionsProduct>();
        }

        public Guid? PrgId { get; set; }
        public Guid PrId { get; set; }
        public Guid? TxcId { get; set; }
        public bool PrDeleted { get; set; }
        public bool PrSelect { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public decimal? Support { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Quantity { get; set; }
        public double? Discount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string PrUd1 { get; set; }
        public string PrUd2 { get; set; }
        public string PrUd3 { get; set; }
        public string PrUd4 { get; set; }
        public string PrUd5 { get; set; }
        public string PrUd6 { get; set; }
        public string PrUd7 { get; set; }
        public string PrUd8 { get; set; }
        public string PrUd9 { get; set; }
        public string PrUd10 { get; set; }
        public string PrUd11 { get; set; }
        public string PrUd12 { get; set; }
        public string PrUd13 { get; set; }
        public string PrUd14 { get; set; }
        public string PrUd15 { get; set; }
        public Guid? PrUd1Id { get; set; }
        public Guid? PrUd2Id { get; set; }
        public Guid? PrUd3Id { get; set; }
        public Guid? PrUd4Id { get; set; }
        public Guid? PrUd5Id { get; set; }
        public Guid? PrUd6Id { get; set; }
        public Guid? PrUd7Id { get; set; }
        public Guid? PrUd8Id { get; set; }
        public Guid? PrUd9Id { get; set; }
        public Guid? PrUd10Id { get; set; }
        public DateTime? PrUd1Date { get; set; }
        public DateTime? PrUd2Date { get; set; }
        public DateTime? PrUd3Date { get; set; }
        public DateTime? PrUd4Date { get; set; }
        public DateTime? PrUd5Date { get; set; }
        public DateTime? PrUd6Date { get; set; }
        public DateTime? PrUd7Date { get; set; }
        public DateTime? PrUd8Date { get; set; }
        public DateTime? PrUd9Date { get; set; }
        public DateTime? PrUd10Date { get; set; }
        public bool? PrUd1Bit { get; set; }
        public bool? PrUd2Bit { get; set; }
        public bool? PrUd3Bit { get; set; }
        public bool? PrUd4Bit { get; set; }
        public bool? PrUd5Bit { get; set; }
        public bool? PrUd6Bit { get; set; }
        public bool? PrUd7Bit { get; set; }
        public bool? PrUd8Bit { get; set; }
        public bool? PrUd9Bit { get; set; }
        public bool? PrUd10Bit { get; set; }
        public decimal? PrUd1Numeric { get; set; }
        public decimal? PrUd2Numeric { get; set; }
        public decimal? PrUd3Numeric { get; set; }
        public decimal? PrUd4Numeric { get; set; }
        public decimal? PrUd5Numeric { get; set; }
        public decimal? PrUd6Numeric { get; set; }
        public decimal? PrUd7Numeric { get; set; }
        public decimal? PrUd8Numeric { get; set; }
        public decimal? PrUd9Numeric { get; set; }
        public decimal? PrUd10Numeric { get; set; }
        public string PrExternal { get; set; }
        public Guid? PrImport { get; set; }
        public bool? PrUd11Bit { get; set; }
        public bool? PrUd12Bit { get; set; }
        public bool? PrUd13Bit { get; set; }
        public bool? PrUd14Bit { get; set; }
        public bool? PrUd15Bit { get; set; }
        public bool? PrUd16Bit { get; set; }
        public bool? PrUd17Bit { get; set; }
        public bool? PrUd18Bit { get; set; }
        public bool? PrUd19Bit { get; set; }
        public bool? PrUd20Bit { get; set; }
        public bool? PrUd21Bit { get; set; }
        public bool? PrUd22Bit { get; set; }
        public bool? PrUd23Bit { get; set; }
        public bool? PrUd24Bit { get; set; }
        public Guid? FneId { get; set; }
        public int ShortCode { get; set; }
        public int TimeUnitValue { get; set; }
        public bool? TimeUnitIsTime { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual FinancialEntity Fne { get; set; }
        public virtual ProductsGroup Prg { get; set; }
        public virtual TaxCode Txc { get; set; }
        public virtual ICollection<OpportunitiesQuotesDetail> OpportunitiesQuotesDetails { get; set; }
        public virtual ICollection<ProductsCurrency> ProductsCurrencies { get; set; }
        public virtual ICollection<ProductsSchedule> ProductsSchedules { get; set; }
        public virtual ICollection<SeminarsBookingsProduct> SeminarsBookingsProducts { get; set; }
        public virtual ICollection<SeminarsProduct> SeminarsProducts { get; set; }
        public virtual ICollection<SeminarsSessionsProduct> SeminarsSessionsProducts { get; set; }
    }
}
