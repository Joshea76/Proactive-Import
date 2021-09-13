using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Delv2
    {
        public Guid? AcId { get; set; }
        public Guid AccId { get; set; }
        public string Summary { get; set; }
        public string BusinessAddressPostalcode { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressStreet2 { get; set; }
        public string BusinessAddressStreet3 { get; set; }
        public string BusinessTelephoneNumber { get; set; }
        public string BusinessAddressCountry { get; set; }
        public string Email1Address { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public bool? AccDeleted { get; set; }
    }
}
