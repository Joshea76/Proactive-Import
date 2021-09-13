using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationThirdPartyCompanyId
    {
        public IntegrationThirdPartyCompanyId()
        {
            Integrations = new HashSet<Integration>();
        }

        public int IntegrationThirdPartyCompanyId1 { get; set; }
        public Guid IntegrationId { get; set; }
        public string ExternalCompanyName { get; set; }
        public string ExternalCompanyId { get; set; }

        public virtual Integration Integration { get; set; }
        public virtual ICollection<Integration> Integrations { get; set; }
    }
}
