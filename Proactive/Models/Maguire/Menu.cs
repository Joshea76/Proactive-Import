using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Menu
    {
        public Guid MenusId { get; set; }
        public string MenusName { get; set; }
        public Guid ColumnLayoutId { get; set; }
    }
}
