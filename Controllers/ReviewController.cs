using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;

namespace ReviewApp.Controllers  
{ 
   public class ReviewController : Controller
   { 
        
        static IList<ReviewModel> reviewList = new List<ReviewModel>()
        {
            new ReviewModel (1, "Jätteroligt och går bra att spela med vänner", "Recension av Mario Kart"),
            new ReviewModel (2, "Bra produkt men dåliga instruktioner", "Recension av ett 3x6 garagetält"),
            new ReviewModel (3, "Mitt nya favoritspel 10/10", "Counter-strike recension"),
            new ReviewModel (4, "Inte den snabbaste bilen men väldigt stilren", "Recension av BMW M4 Competition"), 
            new ReviewModel (5, "Jätteroligt spel", "Recension av Forza Horizon 5"),   

        };

        public IActionResult Reviews()
        {
            return View(reviewList);
        } 

        [HttpGet]
        public IActionResult CreateReview()
        {
            return View("CreateReview");
        }

        [HttpPost]
        public IActionResult CreateReviewSubmit(ReviewModel review)
        {
            
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Information is missing.";
                return View("CreateReview", review);
            } 

            reviewList.Add(review);

            return RedirectToAction("Reviews");
        }
        
        [HttpGet]
        public IActionResult EditReview(int Id)
        {
            var rview = reviewList.Where(r => r.Id == Id).FirstOrDefault();
            return View(rview); 
            
        }

        [HttpPost]
        public IActionResult EditReviewSubmit(ReviewModel review)
        {
            
            var updatedreview = reviewList.Where(r => r.Id == review.Id).FirstOrDefault();

            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Information is missing.";
                return View("EditReview", review);
            }
            
            if (updatedreview != null)
            {
                reviewList.Remove(updatedreview);
                reviewList.Add(review);
            }

            return RedirectToAction("Reviews");
        }

    }
}    