namespace IDS.Models
{
    public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Tags { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<Comment> Comments { get; set; }
    public ICollection<Vote> Votes { get; set; }
    
    // Many-to-Many with Categories
    public ICollection<PostCategory> PostCategories { get; set; } 
}

}
    