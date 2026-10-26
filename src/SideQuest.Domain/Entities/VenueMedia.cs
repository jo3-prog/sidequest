using SideQuest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class VenueMedia
    {
        public Guid Id { get; set; }
        public Guid VenueId { get; set; }
        public string StorageKey { get; set; } = "";
        public MediaType Type { get; set; }
        public string? AltText { get; set; }
        public int DisplayOrder { get; set; }
        public string? RightsSource { get; set; }
    }
}
