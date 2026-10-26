using System;
using System.Collections.Generic;
using System.Text;

namespace SideQuest.Domain.Entities
{
    public class AuditEvent
    {
        public Guid Id { get; set; }
        public Guid ActorUserId { get; set; }
        public string Action { get; set; } = "";
        public string EntityType { get; set; } = "";
        public Guid EntityId { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string? Summary { get; set; }
    }
}
