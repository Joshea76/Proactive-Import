﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsBookingsProduct
    {
        public Guid? SemId { get; set; }
        public Guid SembId { get; set; }
        public Guid? SemsaId { get; set; }
        public Guid? SemsprId { get; set; }
        public Guid? PrId { get; set; }
        public Guid SembprId { get; set; }
        public bool SembprDeleted { get; set; }
        public string Code { get; set; }
        public string ProductGroup { get; set; }
        public string Manufacturer { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public decimal PriceDiscount { get; set; }
        public decimal PriceFinal { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? Cost { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? IsEventbriteTicket { get; set; }
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
        public string PrUd11 { get; set; }
        public string PrUd12 { get; set; }
        public string PrUd13 { get; set; }
        public string PrUd14 { get; set; }
        public string PrUd15 { get; set; }
        public int ShortCode { get; set; }
        public Guid? TxcId { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }
        public Guid? SemprId { get; set; }
        public Guid? SembaId { get; set; }

        public virtual Product Pr { get; set; }
        public virtual Seminar Sem { get; set; }
        public virtual SeminarsBooking Semb { get; set; }
        public virtual SeminarsSessionsAttendee Semsa { get; set; }
        public virtual SeminarsSessionsProduct Semspr { get; set; }
        public virtual TaxCode Txc { get; set; }
    }
}
