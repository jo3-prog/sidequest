using SideQuest.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Slug { get; set; } = "";
        public TagType Type { get; set; }
    }
}
