using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VStageHistory
    {
        public Guid SthId { get; set; }
        public Guid RefId { get; set; }
        public Guid? DroId { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal? NumericValue { get; set; }
        public string FieldName { get; set; }
        public string ObjectType { get; set; }
        public short? ValueType { get; set; }
        public Guid PjId { get; set; }
        public Guid OpId { get; set; }
        public int? Days { get; set; }
        public string DurationText { get; set; }
        public string Stage { get; set; }
        public string StageHlight { get; set; }
        public string DisplayValue { get; set; }
    }
}
