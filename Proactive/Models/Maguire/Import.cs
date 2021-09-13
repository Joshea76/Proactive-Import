using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Import
    {
        public Guid ImId { get; set; }
        public Guid? AcImId { get; set; }
        public string ImSource { get; set; }
        public string Count { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Sourcefile { get; set; }
        public string Importspec { get; set; }
        public DateTime? Lastimport { get; set; }
    }
}
