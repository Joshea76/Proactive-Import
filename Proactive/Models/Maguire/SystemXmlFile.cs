using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SystemXmlFile
    {
        public string FilePath { get; set; }
        public string XmlData { get; set; }
        public DateTime LastModified { get; set; }
    }
}
