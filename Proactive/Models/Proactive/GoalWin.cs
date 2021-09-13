using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class GoalWin
    {
        public int GoalWinId { get; set; }
        public int GoalWinCounter { get; set; }
        public int GoalId { get; set; }
        public string UserId { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual Goal Goal { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
