using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMembership
    {
        public Guid OmId { get; set; }
        public Guid? ObjId { get; set; }
        public Guid? UsgId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? Role { get; set; }
        public byte? Owner { get; set; }
        public string UsgName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string TypeLabel { get; set; }
        public Guid AcId { get; set; }
        public string AcName { get; set; }
        public Guid? UsIdSales { get; set; }
        public Guid? UsIdSupport { get; set; }
        public string AcGroup { get; set; }
        public string RoleName { get; set; }
        public string UsgType { get; set; }
    }
}
