using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VUsersAppointmentsAccountOverview
    {
        public Guid? AcId { get; set; }
        public Guid UsaId { get; set; }
        public string Subject { get; set; }
        public DateTime? Start { get; set; }
        public Guid? UsId { get; set; }
        public Guid? UsIdSales { get; set; }
        public Guid? UsIdSupport { get; set; }
        public short? UsaAccessLevel { get; set; }
        public Guid? SecurityId { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityObject { get; set; }
        public Guid? SecurityOwner { get; set; }
    }
}
