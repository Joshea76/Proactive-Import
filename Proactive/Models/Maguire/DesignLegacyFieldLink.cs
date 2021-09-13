using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFieldLink
    {
        public Guid LegId { get; set; }
        public Guid LfdId { get; set; }
        public string OverrideName { get; set; }
        public bool IsSummary { get; set; }
        public bool IsKey { get; set; }
        public bool IsFormatField { get; set; }
        public string ItemFieldLabelColumn { get; set; }
        public string FormatFieldColour { get; set; }
        public string ActionXml { get; set; }
        public string PickerXml { get; set; }
        public short DisplayType { get; set; }
        public string DefaultLabel { get; set; }
        public string Filter { get; set; }
        public bool IsDetailRow { get; set; }
        public string CurrencySymbolColumn { get; set; }
        public Guid? TodrId { get; set; }
        public string TimeUnitIsTimeColumnName { get; set; }
        public bool IsShortCode { get; set; }

        public virtual DesignLegacyFile Leg { get; set; }
        public virtual DesignLegacyField Lfd { get; set; }
    }
}
