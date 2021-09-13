using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SecureNotesDetail
    {
        public Guid NtId { get; set; }
        public string EncryptedDetails { get; set; }
    }
}
