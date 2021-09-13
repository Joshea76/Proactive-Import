using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Integration
    {
        public Integration()
        {
            Agreements = new HashSet<Agreement>();
            DataImportJobs = new HashSet<DataImportJob>();
            IntegrationThirdPartyCompanyIds = new HashSet<IntegrationThirdPartyCompanyId>();
            IntegrationsModules = new HashSet<IntegrationsModule>();
            IntegrationsSettings = new HashSet<IntegrationsSetting>();
            SocialAuthIntegrations = new HashSet<SocialAuthIntegration>();
            Spaces = new HashSet<Space>();
        }

        public Guid SiId { get; set; }
        public Guid? SitId { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string BaseUri { get; set; }
        public Guid? FneId { get; set; }
        public string AuthClientId { get; set; }
        public string AuthClientSecret { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? RequiresPostInstallStep { get; set; }
        public string IdentityServerClientId { get; set; }
        public bool? RequiresIdentityServer { get; set; }
        public bool? AllowProfiling { get; set; }
        public bool? UserProfiling { get; set; }
        public string IntegrationCategory { get; set; }
        public int? IntegrationType { get; set; }
        public bool DependenciesInstalled { get; set; }
        public int? IntegrationThirdPartyCompanyId { get; set; }
        public bool DisabledByUpgrade { get; set; }
        public string InstalledVersion { get; set; }
        public bool? IsUpdating { get; set; }

        public virtual IntegrationThirdPartyCompanyId IntegrationThirdPartyCompany { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<DataImportJob> DataImportJobs { get; set; }
        public virtual ICollection<IntegrationThirdPartyCompanyId> IntegrationThirdPartyCompanyIds { get; set; }
        public virtual ICollection<IntegrationsModule> IntegrationsModules { get; set; }
        public virtual ICollection<IntegrationsSetting> IntegrationsSettings { get; set; }
        public virtual ICollection<SocialAuthIntegration> SocialAuthIntegrations { get; set; }
        public virtual ICollection<Space> Spaces { get; set; }
    }
}
