using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SecureFieldValue
    {
        public Guid ItemId { get; set; }
        public string DatabaseColumn { get; set; }
        public string EncryptedValue { get; set; }
    }
}
