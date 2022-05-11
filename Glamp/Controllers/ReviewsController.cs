using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Glamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Glamp.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewsRepository repo;
        public ReviewsController(IReviewsRepository repo)
        {
            this.repo = repo;
        }

       
        public IActionResult Index(string user, string facilityID)
        {
            // var user = User.Identity.Name;
            // var reviews = repo.GetAllReviews(user);

            var viewReviews = new Reviews(user, facilityID);
            

            return View(viewReviews);
        }

        public IActionResult SeeReviews(string facilityID)
        {
            //var client = new HttpClient();
            //var quote = new ReviewsRepository(client);

            var seeReviews = repo.GetAllReviews(facilityID);


            return View(seeReviews);
        }

        public IActionResult InsertReviewsIntoDatabase( string user, string title, string description, string facilityID)
        {
            //repo.InsertReview(facilityID, title, description, stars, user);
            Guid guid = Guid.NewGuid();

            repo.InsertReview(user, title, description, facilityID, guid );

            return RedirectToAction("Index", "Campgrounds");

        }

        public IActionResult DeleteReview(Reviews review)
        {
            repo.DeleteReview(review);

            return RedirectToAction("Index");
        }

    }
}
