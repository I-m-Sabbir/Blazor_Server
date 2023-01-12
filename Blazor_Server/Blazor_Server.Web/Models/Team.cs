namespace Blazor_Server.Web.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Region { get; set; } = null!;
        public List<TeamMember>? Members { get; set; }
    }
}
