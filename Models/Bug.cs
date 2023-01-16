
namespace BugTrackerCP.Models
{
    public class Bug
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public IEnumerable<Assignee> Assignees { get; set; }
        public string Status { get; set; }

        public Bug()
        {
            Id = Guid.Empty;
            Name = string.Empty;
            Description = string.Empty;
            Created = DateTime.MinValue;
            LastUpdated = DateTime.MinValue;
            Assignees = new List<Assignee>();
            Status = string.Empty;
        }

        public static Bug Empty() { return new Bug(); }

    }
}
