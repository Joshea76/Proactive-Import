using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SystemXmlFilesBackup
    {
        public string FilePath { get; set; }
        public string XmlData { get; set; }
        public DateTime BackupDate { get; set; }
    }
}
