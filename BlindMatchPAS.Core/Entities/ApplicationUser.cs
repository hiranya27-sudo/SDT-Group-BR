public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}
