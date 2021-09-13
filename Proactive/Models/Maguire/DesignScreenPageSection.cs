using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignScreenPageSection
    {
        public DesignScreenPageSection()
        {
            DesignScreenFieldGroups = new HashSet<DesignScreenFieldGroup>();
            DesignSubLists = new HashSet<DesignSubList>();
        }

        public Guid DspsId { get; set; }
        public Guid DspId { get; set; }
        public short SectionType { get; set; }
        public short? SectionOrdinal { get; set; }
        public Guid? ReqId { get; set; }
        public Guid? SublistDltId { get; set; }
        public int AccessRights { get; set; }
        public int SectionWidth { get; set; }
        public string SubFolder { get; set; }
        public string IframeUrl { get; set; }
        public Guid? IntegrationId { get; set; }
        public bool? TimePurchased { get; set; }
        public bool? UnitPurchased { get; set; }
        public bool? UserTimePurchased { get; set; }
        public bool? UserUnitPurchased { get; set; }
        public bool? IsFixed { get; set; }

        public virtual DesignScreenPage Dsp { get; set; }
        public virtual ICollection<DesignScreenFieldGroup> DesignScreenFieldGroups { get; set; }
        public virtual ICollection<DesignSubList> DesignSubLists { get; set; }
    }
}
