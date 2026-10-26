using SideQuest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class Plan
    {
        public Guid Id { get; set; }
        public Guid OwnerUserId { get; set; }
        public Guid? ClientDraftId { get; set; }          // idempotency key for guest-draft claims
        public string Title { get; set; } = "";
        public string? Notes { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int GroupSize { get; set; } = 1;
        public BudgetMode BudgetMode { get; set; } = BudgetMode.None;
        public long? BudgetAmountMinor { get; set; }
        public string Currency { get; set; } = "NGN";
        public string TimeZoneId { get; set; } = "Africa/Lagos";
        public PlanStatus Status { get; set; } = PlanStatus.Draft;
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public byte[] RowVersion { get; set; } = [];
        public ICollection<PlanStop> Stops { get; set; } = new List<PlanStop>();
    }
}
