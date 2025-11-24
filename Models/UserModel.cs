public class UserModel 
{

    public string Password { get; set; }
    public string Email { get; set; } 
    public string Name { get; set; } 

    public UserModel (string email, string password, string name) 
    {
        Password = password;
        Email = email;
        Name = name;
    }

    public UserModel() 
    {

    }  
}
