namespace Blazor_Server.Web.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public int TeamId { get; set; }
    }
}
