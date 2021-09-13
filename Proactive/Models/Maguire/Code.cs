using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Code
    {
        public Guid CodId { get; set; }
        public Guid AcoId { get; set; }
        public Guid? AcoId2 { get; set; }
        public string Ref { get; set; }
        public string TableName { get; set; }
        public int Seed { get; set; }
        public short Seedwidth { get; set; }
        public string Expression { get; set; }
        public bool CreateOnInsert { get; set; }
        public byte Optional { get; set; }
        public bool AppendSummary { get; set; }
    }
}
