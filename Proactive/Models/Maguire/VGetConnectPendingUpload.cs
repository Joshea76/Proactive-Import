using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGetConnectPendingUpload
    {
        public Guid MacId { get; set; }
        public Guid McrId { get; set; }
        public string Summary { get; set; }
        public byte GvConnectUploaded { get; set; }
        public string GvConnectUploadedBy { get; set; }
        public Guid? GvConnectUploadedId { get; set; }
        public bool? NewOnly { get; set; }
        public Guid? MacType { get; set; }
        public byte ConnectOptInType { get; set; }
    }
}
