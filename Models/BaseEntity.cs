using System;

namespace PrositeCM.Models
{
    public abstract class BaseEntity
    {
        // This generates a new unique GUID automatically when the class is created
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}