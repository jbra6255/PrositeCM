using System;
using System.Collections.Generic;

namespace PrositeCM.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Note: The 'Role' property must be [NotMapped] if it's for UI only
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string Role { get; set; } = string.Empty;

        public Guid OwnerId { get; set; }
        public User? Owner { get; set; }

        public List<Structure> Structures { get; set; } = new();
        public List<PipeOrder> PipeOrders { get; set; } = new();
    }
}