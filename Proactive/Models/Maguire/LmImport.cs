using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmImport
    {
        public LmImport()
        {
            LmImportMappings = new HashSet<LmImportMapping>();
            LmListcontrols = new HashSet<LmListcontrol>();
            LmUpdateImportMappings = new HashSet<LmUpdateImportMapping>();
        }

        public int PiId { get; set; }
        public string Summary { get; set; }
        public DateTime ImportDate { get; set; }
        public string TableName { get; set; }
        public string FilePath { get; set; }
        public short ImportType { get; set; }
        public bool DropTable { get; set; }
        public bool CreateMenu { get; set; }
        public bool? HasHeader { get; set; }
        public string Delimiter { get; set; }
        public string TextQualifier { get; set; }
        public int Status { get; set; }
        public int NumberOfFiles { get; set; }
        public DateTime? DedupeDate { get; set; }
        public string DedupePackage { get; set; }
        public string Label { get; set; }
        public int? NumColumns { get; set; }
        public Guid? UsId { get; set; }
        public string UsName { get; set; }
        public string ObjectName { get; set; }
        public string LayoutName { get; set; }
        public string UpdateUpdate { get; set; }
        public string UpdateInsert { get; set; }
        public string UpdateDelete { get; set; }
        public bool Isupdate { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsComplete { get; set; }
        public string MatchKey { get; set; }
        public int? OrigPiId { get; set; }
        public byte? ImportSource { get; set; }

        public virtual User Us { get; set; }
        public virtual ICollection<LmImportMapping> LmImportMappings { get; set; }
        public virtual ICollection<LmListcontrol> LmListcontrols { get; set; }
        public virtual ICollection<LmUpdateImportMapping> LmUpdateImportMappings { get; set; }
    }
}
