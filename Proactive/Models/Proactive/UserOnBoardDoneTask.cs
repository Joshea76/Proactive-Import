using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserOnBoardDoneTask
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int OnBoardTaskId { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
