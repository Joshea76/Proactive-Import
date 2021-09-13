using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationsProfilesSetting
    {
        public Guid SiId { get; set; }
        public Guid SipId { get; set; }
        public Guid SipsId { get; set; }
        public string Settingkey { get; set; }
        public string Settingvalue { get; set; }
        public int? Settingtype { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
