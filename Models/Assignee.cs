namespace BugTrackerCP.Models
{
    public class Assignee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Assignee(string name)
        {
            Id = Guid.NewGuid();
            Name= name;
        }

        public Assignee() { }
    }
}
