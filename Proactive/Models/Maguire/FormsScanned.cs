using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class FormsScanned
    {
        public Guid FsId { get; set; }
        public string MapiId { get; set; }
        public DateTime? ScannedDate { get; set; }
        public string Body { get; set; }
        public string Result { get; set; }
    }
}
