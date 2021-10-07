using System;

namespace DevExtremeAspNetCoreApp4.Models.Gantt
{
    public class GanttTask
    {
        public int ID { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Progress { get; set; }
    }

    public class Dependency
    {
        public int ID { get; set; }
        public int PredecessorId { get; set; }
        public int SuccessorId { get; set; }
        public int Type { get; set; }
    }

    public class Resource
    {
        public int ID { get; set; }
        public string Text { get; set; }
    }
    public class ResourceAssignment
    {
        public int ID { get; set; }
        public int TaskId { get; set; }
        public int ResourceId { get; set; }
    }
}
