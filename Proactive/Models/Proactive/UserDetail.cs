using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string UserId { get; set; }
        public string ProviderCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyBankInfo { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Website { get; set; }
        public bool ChargeVat { get; set; }
        public string Terms { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
