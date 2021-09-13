using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class CorrespondenceAttachment
    {
        public Guid CoaId { get; set; }
        public Guid? CoId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public byte[] Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Filepath { get; set; }
        public string LinkId { get; set; }

        public virtual Correspondence Co { get; set; }
    }
}
