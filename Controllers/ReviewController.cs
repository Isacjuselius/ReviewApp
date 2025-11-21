using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;

namespace ReviewApp.Controllers  
{ 
   public class ReviewController : Controller
   { 
        public IActionResult Reviews()
        {
            IList<ReviewModel> reviewList = new List<ReviewModel>()
            {
                new ReviewModel (1, "Jätteroligt och går bra att spela med vänner", "Recension av Mario Kart"),
                new ReviewModel (2, "Bra produkt men dåliga instruktioner", "Recension av ett 3x6 garagetält"),
                new ReviewModel (3, "Mitt nya favoritspel 10/10", "Counter-strike recension"),
                new ReviewModel (4, "Inte den snabbaste bilen men väldigt stilren", "Recension av BMW M4 Competition"), 
                new ReviewModel (5, "Jätteroligt spel", "Recension av Forza Horizon 5"),   

            };
            
            return View(reviewList);
    
        } 

        public IActionResult CreateReview()
        {
            return View();
        }

        public IActionResult CreateReviewSubmit(ReviewModel review)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Message = "Review created!";
                return View();
            }


            return View("CreateReview", review);
            
        }
    }
}    