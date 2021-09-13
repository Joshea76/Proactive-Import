using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VUsersGroupsMember
    {
        public string Summary { get; set; }
        public string EmailAddress { get; set; }
        public string Exchangeid { get; set; }
        public string NtAccount { get; set; }
        public Guid UsId { get; set; }
        public string GroupName { get; set; }
        public bool? PrimaryGroup { get; set; }
        public int ShareEmail { get; set; }
        public bool? Manager { get; set; }
        public Guid? UsgId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid UsmId { get; set; }
        public Guid? UsmIdSafe { get; set; }
        public string DeleteText { get; set; }
        public string ManageText { get; set; }
        public string UserText { get; set; }
        public string Details { get; set; }
        public int AcoOverridden { get; set; }
        public string ShortCode { get; set; }
    }
}
