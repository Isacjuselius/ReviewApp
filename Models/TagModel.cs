public class TagModel 
{
    public int Id { get; set; }
    public string Name { get; set; }

    public TagModel (int id, string name) 
    {
        int Id = id;
        string Name = name;
    }  
}