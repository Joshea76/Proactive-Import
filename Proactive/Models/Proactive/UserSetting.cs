using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserSetting
    {
        public int Id { get; set; }
        public string HoursPerDay { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpPort { get; set; }
        public string UserId { get; set; }
        public string SmtpFromAddress { get; set; }
        public bool IsGoogleCalendarActive { get; set; }
        public string MailChimpApiKey { get; set; }
        public bool IsGoogleContactActive { get; set; }
        public bool? IsShowJumpStartTabOnHomePage { get; set; }
        public bool IsGoogleMailActive { get; set; }
        public string ImapServer { get; set; }
        public int? ImapPort { get; set; }
        public bool? ImapIsRequireSsl { get; set; }
        public string ImapUsername { get; set; }
        public string ImapPassword { get; set; }
        public string ImapFolders { get; set; }
        public int FirstInvoiceNumber { get; set; }
        public string MailjetApiKeyPublic { get; set; }
        public string MailjetApiKeyPrivate { get; set; }
        public string EmailSignature { get; set; }
        public bool IsOutlookCalendarActive { get; set; }
        public bool IsOutlookContactActive { get; set; }
        public bool IsOutlookMailActive { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
        public int HomePage { get; set; }
        public bool? ContactActivities { get; set; }
        public bool? DailyRituals { get; set; }
        public bool? FollowUpManager { get; set; }
        public bool? Gdprconsents { get; set; }
        public bool? Invoices { get; set; }
        public bool? Jobs { get; set; }
        public bool? Lists { get; set; }
        public bool? Opportunities { get; set; }
        public bool? Projects { get; set; }
        public bool? Quotes { get; set; }
        public bool? Reports { get; set; }
        public bool? Todos { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
