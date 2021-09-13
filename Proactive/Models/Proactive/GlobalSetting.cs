using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class GlobalSetting
    {
        public int GlobalSettingId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
