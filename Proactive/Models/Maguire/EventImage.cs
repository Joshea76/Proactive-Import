using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventImage
    {
        public Guid EvtImageId { get; set; }
        public Guid EvtId { get; set; }
        public Guid EvtAssetId { get; set; }
        public string FileName { get; set; }
        public string CroppedImageFileName { get; set; }
        public string CropPoints { get; set; }
        public string Zoom { get; set; }
    }
}
