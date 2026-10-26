using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class VenueOpeningHour
    {
        public Guid Id { get; set; }
        public Guid VenueId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeOnly? OpensAt { get; set; }
        public TimeOnly? ClosesAt { get; set; }
        public bool IsClosed { get; set; }
        public string? Source { get; set; }
    }
}
