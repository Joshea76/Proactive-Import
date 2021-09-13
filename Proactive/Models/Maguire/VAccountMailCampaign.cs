using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAccountMailCampaign
    {
        public Guid? MacacId { get; set; }
        public Guid MacId { get; set; }
        public Guid AcId { get; set; }
        public string Summary { get; set; }
        public bool? MacStatus { get; set; }
        public DateTime? RunDate { get; set; }
        public string RunBy { get; set; }
        public string MacMedium { get; set; }
        public bool MacDeleted { get; set; }
        public string MacStage { get; set; }
        public string MacStageHlight { get; set; }
        public string MacType { get; set; }
        public string MacTypeHlight { get; set; }
    }
}
