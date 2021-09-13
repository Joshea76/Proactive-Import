using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvToDoListSecurity
    {
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? MacId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? PjId { get; set; }
        public Guid ActId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? UsId { get; set; }
        public Guid? UsIdSales { get; set; }
        public Guid? UsIdSupport { get; set; }
        public string UsName { get; set; }
        public Guid? UsgId { get; set; }
        public string UsgName { get; set; }
        public string ActivityType { get; set; }
        public Guid? SecurityId { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityObject { get; set; }
        public Guid? SecurityOwner { get; set; }
        public Guid AcaId { get; set; }
        public Guid AccaId { get; set; }
        public Guid OpaId { get; set; }
        public Guid PjaId { get; set; }
        public DateTime? DueDate { get; set; }
        public string PrefixedShortCode { get; set; }
        public string ActivitySummary { get; set; }
        public bool Complete { get; set; }
        public bool? ActDeleted { get; set; }
    }
}
