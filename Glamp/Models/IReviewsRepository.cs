using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public interface IReviewsRepository
    {
        public void InsertReview(string user, string title, string description, string facilityID, Guid guid);
        public void DeleteReview(Reviews reviews);
        public IEnumerable<Reviews> GetAllReviews(string id);

    }
}
