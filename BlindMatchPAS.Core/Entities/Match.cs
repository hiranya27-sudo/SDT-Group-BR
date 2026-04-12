public enum MatchStatus { Interested, Confirmed, Rejected }
 
public class Match
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;
    public string SupervisorId { get; set; } = string.Empty;
    public ApplicationUser Supervisor { get; set; } = null!;
    public MatchStatus Status { get; set; } = MatchStatus.Interested;
    // THE KEY FLAG — false = blind, true = identities revealed
    public bool IdentityRevealed { get; set; } = false;
    public DateTime? ConfirmedAt { get; set; }
}
