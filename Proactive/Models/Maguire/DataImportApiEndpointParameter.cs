using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataImportApiEndpointParameter
    {
        public int Id { get; set; }
        public int EndpointId { get; set; }
        public string ParameterKey { get; set; }
        public string ParameterValue { get; set; }
    }
}
