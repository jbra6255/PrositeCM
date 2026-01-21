using System;
using System.Collections.Generic;

namespace PrositeCM.Models // Capital 'S' to match Project.cs
{
    public class Structure : BaseEntity // Must be 'public'
    {
        // --- Identification ---
        public string Tag { get; set; } = string.Empty;
        public string Type { get; set; } = "CB";

        // --- Geometry ---
        public double RimElevation { get; set; }
        public double InvertOutElevation { get; set; }
        public double? VertDrop { get; set; }
        public int? InvertOutAngle { get; set; }

        // --- Run Management ---
        public string RunDesignation { get; set; } = "A";
        public bool IsPrimaryRun { get; set; } = true;

        // --- Pipe Data ---
        public double? PipeLength { get; set; }
        public double? PipeDiameter { get; set; }
        public string PipeType { get; set; } = "RCP";

        // --- Details ---
        public string FrameType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // --- Relationships ---
        public Guid ProjectId { get; set; }
        public Project? Project { get; set; }

        public Guid? UpstreamStructureId { get; set; }
        public Structure? UpstreamStructure { get; set; }

        public List<StructureComponent> Components { get; set; } = new();
    }
}