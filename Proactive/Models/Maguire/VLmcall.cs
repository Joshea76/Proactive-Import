using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VLmcall
    {
        public Guid ClmId { get; set; }
        public Guid UsId { get; set; }
        public string UsName { get; set; }
        public int CsId { get; set; }
        public string Number { get; set; }
        public bool? Incomming { get; set; }
        public int? Duration { get; set; }
        public DateTime CallDate { get; set; }
        public Guid? UsIdControl { get; set; }
        public byte? LeadAllocationMode { get; set; }
        public int? ListOpen { get; set; }
        public Guid? UsgIdOwner { get; set; }
        public Guid? UsIdOwner { get; set; }
        public string Direction { get; set; }
        public string DirectionImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? AcoId { get; set; }
        public string CreatedBy { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
