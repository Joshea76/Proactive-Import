using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SocialAuthIntegration
    {
        public Guid SocsiId { get; set; }
        public Guid SocId { get; set; }
        public Guid SiId { get; set; }

        public virtual Integration Si { get; set; }
        public virtual SocialAuth Soc { get; set; }
    }
}
