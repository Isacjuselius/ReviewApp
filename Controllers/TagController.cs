using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;

namespace ReviewApp.Controllers  
{ 
   public class TagController : Controller
   { 
        public IActionResult Tags()
        {
            IList<TagModel> tagList = new List<TagModel>()
            {
                new TagModel (1, "Spel"),
                new TagModel (2, "Fordon"),
                new TagModel (3, "Elektronik"),
                new TagModel (4, "Hemma"),
                
            };
            
            return View(tagList);
    
        } 
    }
}    