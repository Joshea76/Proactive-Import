using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyField
    {
        public DesignLegacyField()
        {
            DesignFieldValidations = new HashSet<DesignFieldValidation>();
            DesignFields = new HashSet<DesignField>();
            DesignLegacyChildFieldLfdIdChildNavigations = new HashSet<DesignLegacyChildField>();
            DesignLegacyChildFieldLfdIdParentNavigations = new HashSet<DesignLegacyChildField>();
            DesignLegacyFieldAssociationAssociatedDesignLegacyFields = new HashSet<DesignLegacyFieldAssociation>();
            DesignLegacyFieldAssociationDesignLegacyFields = new HashSet<DesignLegacyFieldAssociation>();
            DesignLegacyFieldLabelPropagationMappingFromLfds = new HashSet<DesignLegacyFieldLabelPropagationMapping>();
            DesignLegacyFieldLabelPropagationMappingToLfds = new HashSet<DesignLegacyFieldLabelPropagationMapping>();
            DesignLegacyFieldLinks = new HashSet<DesignLegacyFieldLink>();
            DesignLegacyFieldMixedListLinkListLfds = new HashSet<DesignLegacyFieldMixedListLink>();
            DesignLegacyFieldMixedListLinkScreenLfds = new HashSet<DesignLegacyFieldMixedListLink>();
            DesignLegacyFieldSearchModifiers = new HashSet<DesignLegacyFieldSearchModifier>();
            GlobalSearchFields = new HashSet<GlobalSearchField>();
        }

        public Guid LfdId { get; set; }
        public string OriginalName { get; set; }
        public string OriginalObject { get; set; }
        public Guid? OriginalObjectId { get; set; }
        public Guid? DrId { get; set; }
        public short? DataType { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsReadonlyAfterSave { get; set; }
        public bool IsHidden { get; set; }
        public Guid? ActionLegId { get; set; }
        public Guid? PickerLegId { get; set; }
        public byte EditibilityLevel { get; set; }
        public byte? VisibilityLevel { get; set; }
        public Guid? EditibilityTeamId { get; set; }
        public Guid? VisibilityTeamId { get; set; }
        public bool GloballySearchable { get; set; }
        public bool? CanBeGloballySearched { get; set; }
        public bool IsGeocoded { get; set; }
        public Guid? ParentLfdId { get; set; }
        public Guid? NewitemPickerLegId { get; set; }
        public bool? CanBeGroupedBy { get; set; }
        public bool IsOwnerField { get; set; }
        public bool IsOwnersTeamField { get; set; }
        public bool IsUtc { get; set; }
        public Guid? ParentDropLfdId { get; set; }
        public int? TextFieldMaxLength { get; set; }
        public string Tooltip { get; set; }
        public Guid? DepLfdId { get; set; }
        public bool? IsCritical { get; set; }
        public bool? IsConvertedToInteger { get; set; }
        public bool? IsSecure { get; set; }

        public virtual ICollection<DesignFieldValidation> DesignFieldValidations { get; set; }
        public virtual ICollection<DesignField> DesignFields { get; set; }
        public virtual ICollection<DesignLegacyChildField> DesignLegacyChildFieldLfdIdChildNavigations { get; set; }
        public virtual ICollection<DesignLegacyChildField> DesignLegacyChildFieldLfdIdParentNavigations { get; set; }
        public virtual ICollection<DesignLegacyFieldAssociation> DesignLegacyFieldAssociationAssociatedDesignLegacyFields { get; set; }
        public virtual ICollection<DesignLegacyFieldAssociation> DesignLegacyFieldAssociationDesignLegacyFields { get; set; }
        public virtual ICollection<DesignLegacyFieldLabelPropagationMapping> DesignLegacyFieldLabelPropagationMappingFromLfds { get; set; }
        public virtual ICollection<DesignLegacyFieldLabelPropagationMapping> DesignLegacyFieldLabelPropagationMappingToLfds { get; set; }
        public virtual ICollection<DesignLegacyFieldLink> DesignLegacyFieldLinks { get; set; }
        public virtual ICollection<DesignLegacyFieldMixedListLink> DesignLegacyFieldMixedListLinkListLfds { get; set; }
        public virtual ICollection<DesignLegacyFieldMixedListLink> DesignLegacyFieldMixedListLinkScreenLfds { get; set; }
        public virtual ICollection<DesignLegacyFieldSearchModifier> DesignLegacyFieldSearchModifiers { get; set; }
        public virtual ICollection<GlobalSearchField> GlobalSearchFields { get; set; }
    }
}
