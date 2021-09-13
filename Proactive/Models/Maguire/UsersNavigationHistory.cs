using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersNavigationHistory
    {
        public Guid Id { get; set; }
        public Guid UsId { get; set; }
        public Guid? LabelObjId { get; set; }
        public Guid? RequestId { get; set; }
        public string ItemSummary { get; set; }
        public Guid? ItemId { get; set; }
        public Guid? DesignId { get; set; }
        public DateTime CreatedDate { get; set; }
        public short? NavigationType { get; set; }
        public byte? Color { get; set; }
        public string Icon { get; set; }
        public string PagePath { get; set; }
    }
}
