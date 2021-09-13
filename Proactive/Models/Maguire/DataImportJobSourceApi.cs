using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportJobSourceApi
    {
        public DataImportJobSourceApi()
        {
            DataImportJobSourceApiEndpoints = new HashSet<DataImportJobSourceApiEndpoint>();
        }

        public int Id { get; set; }
        public string BaseUrl { get; set; }
        public int AuthType { get; set; }
        public Guid? SocialAuthId { get; set; }

        public virtual ICollection<DataImportJobSourceApiEndpoint> DataImportJobSourceApiEndpoints { get; set; }
    }
}
