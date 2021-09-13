using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationsProfilesUsersSetting
    {
        public Guid SiId { get; set; }
        public Guid SipId { get; set; }
        public Guid SipuId { get; set; }
        public Guid SipusId { get; set; }
        public string Settingkey { get; set; }
        public string Settingvalue { get; set; }
        public int? Settingtype { get; set; }
    }
}
