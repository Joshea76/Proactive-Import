using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFile
    {
        public DesignLegacyFile()
        {
            DesignLegacyActionLegIdListRefNavigations = new HashSet<DesignLegacyAction>();
            DesignLegacyActionLegs = new HashSet<DesignLegacyAction>();
            DesignLegacyChildLegIdChildNavigations = new HashSet<DesignLegacyChild>();
            DesignLegacyChildLegIdParentNavigations = new HashSet<DesignLegacyChild>();
            DesignLegacyFieldLinks = new HashSet<DesignLegacyFieldLink>();
            DesignLegacyListOptions = new HashSet<DesignLegacyListOption>();
            DesignLegacySubListListLegs = new HashSet<DesignLegacySubList>();
            DesignLegacySubListObjectLegs = new HashSet<DesignLegacySubList>();
            DesignThemes = new HashSet<DesignTheme>();
            InverseListObjectRefNavigation = new HashSet<DesignLegacyFile>();
            InverseUndeleteLeg = new HashSet<DesignLegacyFile>();
        }

        public Guid LegId { get; set; }
        public string XmlFilename { get; set; }
        public short LegacyType { get; set; }
        public Guid? ListObjectRef { get; set; }
        public bool IsExtension { get; set; }
        public bool IsAdmin { get; set; }
        public string PrimaryKeyColumn { get; set; }
        public Guid? AccessOption { get; set; }
        public short SaveEndpointType { get; set; }
        public string ObjectNameForMigration { get; set; }
        public bool? CanAddFields { get; set; }
        public short Category { get; set; }
        public short? ListDefaultView { get; set; }
        public bool? PrimaryList { get; set; }
        public bool? IsEditable { get; set; }
        public bool? RenderRowsInEditMode { get; set; }
        public Guid? UndeleteLegId { get; set; }
        public string SqlFunction { get; set; }
        public string SecondaryGlobalSearchDataColumn { get; set; }
        public Guid? GlobalSearchListId { get; set; }
        public bool? IsLeadObject { get; set; }
        public bool RequiresAdminAccess { get; set; }
        public string TableName { get; set; }

        public virtual DesignLegacyFile ListObjectRefNavigation { get; set; }
        public virtual DesignLegacyFile UndeleteLeg { get; set; }
        public virtual DesignMenuGroupItemOrder DesignMenuGroupItemOrder { get; set; }
        public virtual ICollection<DesignLegacyAction> DesignLegacyActionLegIdListRefNavigations { get; set; }
        public virtual ICollection<DesignLegacyAction> DesignLegacyActionLegs { get; set; }
        public virtual ICollection<DesignLegacyChild> DesignLegacyChildLegIdChildNavigations { get; set; }
        public virtual ICollection<DesignLegacyChild> DesignLegacyChildLegIdParentNavigations { get; set; }
        public virtual ICollection<DesignLegacyFieldLink> DesignLegacyFieldLinks { get; set; }
        public virtual ICollection<DesignLegacyListOption> DesignLegacyListOptions { get; set; }
        public virtual ICollection<DesignLegacySubList> DesignLegacySubListListLegs { get; set; }
        public virtual ICollection<DesignLegacySubList> DesignLegacySubListObjectLegs { get; set; }
        public virtual ICollection<DesignTheme> DesignThemes { get; set; }
        public virtual ICollection<DesignLegacyFile> InverseListObjectRefNavigation { get; set; }
        public virtual ICollection<DesignLegacyFile> InverseUndeleteLeg { get; set; }
    }
}
