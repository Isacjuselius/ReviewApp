namespace ReviewApp.Models 
{
    public class UserModel 
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }  

        public UserModel (int id, string password, string email, int age) 
        {
            Id = id;
            Password = password;
            Email = email;
            Age = age;
        }  
    }
}