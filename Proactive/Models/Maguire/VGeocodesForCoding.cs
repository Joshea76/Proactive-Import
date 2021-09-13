using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGeocodesForCoding
    {
        public string GeoAddress { get; set; }
        public string GeoPostCode { get; set; }
        public string Iso2code { get; set; }
        public int? GeoId { get; set; }
        public DateTime? GeoExpiry { get; set; }
        public bool? GeoPendingLookup { get; set; }
    }
}
