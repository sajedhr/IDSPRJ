public class Vote
{
    public int Id { get; set; }
    public string Type { get; set; } // "Up" or "Down"

    public int PostId { get; set; }
    public Post Post { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
