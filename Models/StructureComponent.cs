using System;

namespace PrositeCM.Models
{
    public class StructureComponent : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // e.g. "Riser", "Frame"
        public string Status { get; set; } = "Pending";

        public Guid StructureId { get; set; }
        public Structure? Structure { get; set; }
    }
}