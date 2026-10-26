using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class VenueCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Slug { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }
}
