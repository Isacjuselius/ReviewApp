public class TagModel 
{
    public int Id { get; set; }
    public string Category { get; set; }

    public TagModel (int id, string category) 
    {
        Id = id;
        Category = category;
    }  
}