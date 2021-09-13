using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventInfoAssetItem
    {
        public Guid EvtAssetItemId { get; set; }
        public Guid EvtAssetId { get; set; }
        public string FileName { get; set; }
        public string LinkLabel { get; set; }
    }
}
