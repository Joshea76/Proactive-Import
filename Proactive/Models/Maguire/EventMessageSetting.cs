using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventMessageSetting
    {
        public Guid Id { get; set; }
        public string FriendlyName { get; set; }
        public int EventMessageType { get; set; }
        public short? AuthenticationType { get; set; }
        public string TargetUri { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MessageMapping { get; set; }
        public bool? Enabled { get; set; }
        public Guid? SocialAuthId { get; set; }
        public string SocialAuthUrl { get; set; }
    }
}
