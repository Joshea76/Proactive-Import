using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Language
    {
        public Language()
        {
            AlertLabels = new HashSet<AlertLabel>();
            DashboardHomepageLabels = new HashSet<DashboardHomepageLabel>();
            DashboardUserWidgetLabels = new HashSet<DashboardUserWidgetLabel>();
            DashboardWidgetLabels = new HashSet<DashboardWidgetLabel>();
            DesignLabels = new HashSet<DesignLabel>();
            LabelImports = new HashSet<LabelImport>();
            SystemLabels = new HashSet<SystemLabel>();
            Users = new HashSet<User>();
        }

        public Guid LangId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AlertLabel> AlertLabels { get; set; }
        public virtual ICollection<DashboardHomepageLabel> DashboardHomepageLabels { get; set; }
        public virtual ICollection<DashboardUserWidgetLabel> DashboardUserWidgetLabels { get; set; }
        public virtual ICollection<DashboardWidgetLabel> DashboardWidgetLabels { get; set; }
        public virtual ICollection<DesignLabel> DesignLabels { get; set; }
        public virtual ICollection<LabelImport> LabelImports { get; set; }
        public virtual ICollection<SystemLabel> SystemLabels { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
