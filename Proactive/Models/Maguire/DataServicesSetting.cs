using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DataServicesSetting
    {
        public Guid DtaId { get; set; }
        public Guid? UsId { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public int ServiceType { get; set; }
        public string ConnectionIdentifier { get; set; }
        public string ServerAddress1 { get; set; }
        public string ServerAddress2 { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProxyAddress { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPassword { get; set; }
        public string DefaultObject { get; set; }
        public bool Impersonate { get; set; }
        public int AllowSelfCert { get; set; }
        public byte[] CertificateBytes { get; set; }
        public bool? ImportThirdParty { get; set; }
    }
}
