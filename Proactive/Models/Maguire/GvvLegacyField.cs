using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvLegacyField
    {
        public Guid LfdId { get; set; }
        public string OriginalName { get; set; }
        public short? DataType { get; set; }
        public Guid? DrId { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsReadonlyAfterSave { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsHidden { get; set; }
        public bool IsSummary { get; set; }
        public bool IsKey { get; set; }
        public string ItemFieldLabelColumn { get; set; }
        public string DefaultLabel { get; set; }
        public short DefaultDisplayType { get; set; }
        public Guid? ActionLegId { get; set; }
        public Guid? PickerLegId { get; set; }
        public byte EditibilityLevel { get; set; }
        public byte? VisibilityLevel { get; set; }
        public Guid? EditibilityTeamId { get; set; }
        public Guid? VisibilityTeamId { get; set; }
        public bool? CanBeGloballySearched { get; set; }
        public bool GloballySearchable { get; set; }
        public Guid? ParentDropId { get; set; }
        public bool IsGeocoded { get; set; }
        public Guid? NewitemPickerLegId { get; set; }
        public bool? CanBeGroupedBy { get; set; }
        public string CurrencySymbolColumn { get; set; }
        public bool? DropOptionsAreScreenDesignable { get; set; }
        public bool IsUtc { get; set; }
        public Guid? LangId { get; set; }
        public bool IsExtension { get; set; }
        public bool IsAdmin { get; set; }
        public string XmlFilename { get; set; }
        public Guid LegId { get; set; }
        public string TimeUnitIsTimeColumnName { get; set; }
        public bool IsShortCode { get; set; }
        public bool? IsCritical { get; set; }
        public bool? IsConvertedToInteger { get; set; }
        public bool IsSecure { get; set; }
    }
}
