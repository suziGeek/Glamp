using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models.Services
{
    public class ReviewsService
    {
        private readonly IReviewsRepository _reviewsRepository;

        public ReviewsService(IReviewsRepository reviewsRepository)
        {
            _reviewsRepository = reviewsRepository;
        }

        public IEnumerable<Reviews> GetReviews(string id)
        {
            return _reviewsRepository.GetAllReviews(id);
        }
    }
}
