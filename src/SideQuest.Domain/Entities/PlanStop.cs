using SideQuest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class PlanStop
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Plan Plan { get; set; } = null!;
        public Guid? VenueId { get; set; }                // null => custom activity
        public Venue? Venue { get; set; }
        public string Title { get; set; } = "";           // snapshot, survives venue rename/deactivation
        public string? Notes { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly? StartTime { get; set; }          // local time in plan's TimeZoneId
        public int? DurationMinutes { get; set; }
        public int SortOrder { get; set; }
        public bool Pinned { get; set; }
        public long? CostAmountMinor { get; set; }        // group total; null when CostStatus == Unknown
        public PriceStatus CostStatus { get; set; } = PriceStatus.Unknown;
        public string Currency { get; set; } = "NGN";
    }
}
