using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UserCulture
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string NativeName { get; set; }
        public string EnglishName { get; set; }
        public short? SortOrder { get; set; }
    }
}
