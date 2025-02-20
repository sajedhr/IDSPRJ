namespace  IDS.Models
{
    public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Descriptions { get; set; }

    public ICollection<PostCategory> PostCategorie { get; set; }
}

}