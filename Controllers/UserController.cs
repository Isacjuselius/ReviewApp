using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;

namespace ReviewApp.Controllers  
{ 
   public class UserController : Controller
   { 
        public IActionResult Users()
        {
            IList<UserModel> userList = new List<UserModel>()
            {
                new UserModel (1, "adam123", "adam.hultgren@gmail.com", 24),
                new UserModel (2, "omar123", "omar.lundgren@gmail.com", 22),
                new UserModel (3, "nils123", "nils.sjolund@gmail.com", 21),
                new UserModel (4, "jacob123", "jacob.bergan@gmail.com", 22), 
                new UserModel (5, "sebbe123", "sebbe.gabbe@gmail.com", 22)   

            };
            
            return View(userList);
    
        } 
    }
}    