using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccTxt
    {
        public Guid AccTxtId { get; set; }
        public string AccTxt1 { get; set; }

        public virtual AccountsContact AccTxtNavigation { get; set; }
    }
}
