using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Document
    {
        public Document()
        {
            Agreements = new HashSet<Agreement>();
        }

        public Guid? AcId { get; set; }
        public Guid RefId { get; set; }
        public Guid DocId { get; set; }
        public bool? DocDeleted { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Ud1 { get; set; }
        public string Ud2 { get; set; }
        public string Ud3 { get; set; }
        public string Ud4 { get; set; }
        public string Ud5 { get; set; }
        public string Ud6 { get; set; }
        public string Ud7 { get; set; }
        public string Ud8 { get; set; }
        public string Ud9 { get; set; }
        public string Ud10 { get; set; }
        public string Ud11 { get; set; }
        public string Ud12 { get; set; }
        public string Ud13 { get; set; }
        public string Ud14 { get; set; }
        public string Ud15 { get; set; }

        public virtual Account Ac { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
