using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGetUserScanInfo
    {
        public Guid UsId { get; set; }
        public string Summary { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? LastScanned { get; set; }
        public string EmailScanDetails { get; set; }
        public string EmailScanFolders { get; set; }
        public string EmailScanExclusions { get; set; }
        public bool? EmailScanEmails { get; set; }
        public bool? EmailScanContacts { get; set; }
        public bool? EmailScanAppointments { get; set; }
        public bool? EmailScanTasks { get; set; }
        public int EmailScanMaxSensitivity { get; set; }
        public string NtAccount { get; set; }
        public bool? PrivateEmail { get; set; }
    }
}
