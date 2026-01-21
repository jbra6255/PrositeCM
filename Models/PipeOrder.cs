using System;

namespace PrositeCM.Models
{
    public class PipeOrder : BaseEntity
    {
        public string OrderNumber { get; set; } = string.Empty;
        public string Supplier { get; set; } = string.Empty;

        public Guid ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}