
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
            Id = Guid.NewGuid();
            Name = string.Empty;
            Description = string.Empty;
            Created = DateTime.Now;
            LastUpdated = DateTime.Now;
            Assignees = new List<Assignee>();
            Status = "Open";
        }

        public static Bug Empty() { return new Bug(); }

    }
}
