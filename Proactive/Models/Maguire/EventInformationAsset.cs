using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventInformationAsset
    {
        public Guid AssetId { get; set; }
        public Guid EvtId { get; set; }
        public byte AssetType { get; set; }
        public int EvtInfoOrder { get; set; }
    }
}
