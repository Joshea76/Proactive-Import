using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PluginSetting
    {
        public int PlsId { get; set; }
        public string Plugin { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
