using System;
using System.Collections.Generic;

namespace PrositeCM.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        // Relationship: One user can own many projects
        public List<Project> OwnedProjects { get; set; } = new();
    }
}