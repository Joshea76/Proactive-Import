using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SecureNotesPermission
    {
        public Guid NoteId { get; set; }
        public Guid PermissionId { get; set; }
        public int PermissionType { get; set; }
    }
}
