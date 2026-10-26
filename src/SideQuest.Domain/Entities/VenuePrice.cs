using SideQuest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class VenuePrice
    {
        public Guid Id { get; set; }
        public Guid VenueId { get; set; }
        public string Label { get; set; } = "";
        public long? AmountMinor { get; set; }           // null only when Status == Unknown
        public string Currency { get; set; } = "NGN";
        public PriceStatus Status { get; set; }
        public string? Source { get; set; }
        public DateTimeOffset? LastCheckedAt { get; set; }
        public string? Note { get; set; }
    }
}
