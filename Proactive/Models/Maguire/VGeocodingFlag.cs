using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGeocodingFlag
    {
        public bool? IsGeocoded { get; set; }
        public DateTime? LastGeocoded { get; set; }
        public int GeoId { get; set; }
    }
}
