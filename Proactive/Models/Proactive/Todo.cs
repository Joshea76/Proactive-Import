using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Todo
    {
        public Todo()
        {
            TodoCustomSelectValues = new HashSet<TodoCustomSelectValue>();
            TodoNotes = new HashSet<TodoNote>();
        }

        public int TodoId { get; set; }
        public int? ContactId { get; set; }
        public string TodoDesc { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DoBy { get; set; }
        public DateTime? DateDone { get; set; }
        public int? MarketingListId { get; set; }
        public int? TodoType { get; set; }
        public int IsDone { get; set; }
        public string UserId { get; set; }
        public string ExtarnalId { get; set; }
        public int? OpportunityId { get; set; }
        public int? ContactToDoFieldId { get; set; }
        public string OutlookId { get; set; }
        public int? ToDoTypeId { get; set; }
        public int? OrgId { get; set; }
        public string AssignedUserId { get; set; }
        public int? OrgTodoTypeId { get; set; }
        public int? StatusId { get; set; }
        public int? Priority { get; set; }

        public virtual AspNetUser AssignedUser { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual ContactToDoField ContactToDoField { get; set; }
        public virtual MarketingList MarketingList { get; set; }
        public virtual Opportunity Opportunity { get; set; }
        public virtual Org Org { get; set; }
        public virtual OrgTodoType OrgTodoType { get; set; }
        public virtual TodoStatus Status { get; set; }
        public virtual TodoCategory ToDoType { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<TodoCustomSelectValue> TodoCustomSelectValues { get; set; }
        public virtual ICollection<TodoNote> TodoNotes { get; set; }
    }
}
