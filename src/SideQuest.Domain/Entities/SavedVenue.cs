using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class SavedVenue
    {
        public Guid UserId { get; set; }
        public Guid VenueId { get; set; }
        public Venue Venue { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}
