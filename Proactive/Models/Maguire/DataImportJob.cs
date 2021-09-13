using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportJob
    {
        public DataImportJob()
        {
            DataImportJobSources = new HashSet<DataImportJobSource>();
        }

        public int Id { get; set; }
        public string JobName { get; set; }
        public DateTime? LastRunUtcDate { get; set; }
        public int? TimeSpan { get; set; }
        public bool IsPeriodic { get; set; }
        public TimeSpan? RunAtUtc { get; set; }
        public byte? JobState { get; set; }
        public Guid RunAsUserId { get; set; }
        public Guid? IntegrationId { get; set; }
        public bool? Enabled { get; set; }

        public virtual Integration Integration { get; set; }
        public virtual User RunAsUser { get; set; }
        public virtual ICollection<DataImportJobSource> DataImportJobSources { get; set; }
    }
}
