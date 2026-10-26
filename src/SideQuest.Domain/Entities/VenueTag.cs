using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class VenueTag
    {
        public Guid VenueId { get; set; }
        public Guid TagId { get; set; }
        public Venue Venue { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}
