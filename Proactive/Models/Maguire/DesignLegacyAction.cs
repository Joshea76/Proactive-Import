using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyAction
    {
        public Guid DlaId { get; set; }
        public Guid LegId { get; set; }
        public byte Type { get; set; }
        public short ActionType { get; set; }
        public string ActionBinding { get; set; }
        public string IconType { get; set; }
        public bool IsPrimary { get; set; }
        public bool Enabled { get; set; }
        public int Order { get; set; }
        public Guid? AcoId { get; set; }
        public bool AcoIsEdit { get; set; }
        public bool AcoIsDelete { get; set; }
        public Guid? LegIdListRef { get; set; }
        public Guid? LfdIdEnabledRef { get; set; }
        public bool IsCustomNewAction { get; set; }
        public Guid? FilterDfdId { get; set; }
        public bool? IsWhatsnext { get; set; }
        public Guid? IconDscId { get; set; }
        public bool IsCustomSaveAction { get; set; }

        public virtual AccessOption Aco { get; set; }
        public virtual DesignLegacyFile Leg { get; set; }
        public virtual DesignLegacyFile LegIdListRefNavigation { get; set; }
    }
}
