public class ReviewModel 
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }

    public ReviewModel() 
    { 

    }

    public ReviewModel (int id, string description, string title) 
    {
        Id = id;
        Description = description;
        Title = title;
    }  
}