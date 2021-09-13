using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Goal
    {
        public Goal()
        {
            GoalWins = new HashSet<GoalWin>();
        }

        public int GoalId { get; set; }
        public string GoalDesc { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime AchieveByDate { get; set; }
        public int GoalNumber { get; set; }
        public string UserId { get; set; }
        public DateTime? DoneDate { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<GoalWin> GoalWins { get; set; }
    }
}
