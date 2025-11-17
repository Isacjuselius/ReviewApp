public class ReviewModel 
{
    public int Id { get; set; }
    public string Desc { get; set; }
    public string Title { get; set; }

    public ReviewModel (int id, string desc, string title) 
    {
        Id = id;
        Desc = desc;
        Title = title;
    }  
}