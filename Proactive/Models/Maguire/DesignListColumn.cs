using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignListColumn
    {
        public Guid DlcId { get; set; }
        public Guid? DefaultField { get; set; }
        public Guid? DltId { get; set; }
        public short ColumnOrdinal { get; set; }
        public bool Selectable { get; set; }
        public bool IsSortColumn { get; set; }
        public bool IsSortAsc { get; set; }
        public short? ColumnWidth { get; set; }
        public bool IsFrozenColumn { get; set; }
        public int? FrozenColumnLeftPosition { get; set; }

        public virtual DesignField DefaultFieldNavigation { get; set; }
        public virtual DesignList Dlt { get; set; }
    }
}
