using SideQuest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class Venue
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Slug { get; set; } = "";
        public string? Description { get; set; }
        public string Address { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public string? WhatsAppNumber { get; set; }

        public Guid CategoryId { get; set; }
        public VenueCategory Category { get; set; } = null!;
        public Guid NeighbourhoodId { get; set; }
        public Neighbourhood Neighbourhood { get; set; } = null!;

        public ListingStatus ListingStatus { get; set; } = ListingStatus.Draft;
        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Unverified;
        public string? Source { get; set; }
        public DateTimeOffset? LastCheckedAt { get; set; }
        public bool IsFeatured { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public ICollection<VenueMedia> Media { get; set; } = new List<VenueMedia>();
        public ICollection<VenuePrice> Prices { get; set; } = new List<VenuePrice>();
        public ICollection<VenueOpeningHour> OpeningHours { get; set; } = new List<VenueOpeningHour>();
        public ICollection<VenueTag> VenueTags { get; set; } = new List<VenueTag>();
    }
}
