using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GeoCode
    {
        public int GeoId { get; set; }
        public string GeoPostCode { get; set; }
        public string GeoObjectName { get; set; }
        public string GeoTableName { get; set; }
        public string GeoColumnName { get; set; }
        public double? GeoLongitude { get; set; }
        public double? GeoLatitude { get; set; }
        public bool GeoPendingLookup { get; set; }
        public Guid GeoObjId { get; set; }
        public Guid? GeoAcId { get; set; }
        public DateTime GeoUpdatedDate { get; set; }
        public bool GeoIsExtension { get; set; }
        public string GeoAddress { get; set; }
        public Guid? GeoCountry { get; set; }
        public byte[] GeoHash { get; set; }
        public DateTime? GeoExpiry { get; set; }
    }
}
