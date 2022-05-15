using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace Glamp.Models
{
    public class ReviewsRepository : IReviewsRepository
    {

        private readonly IDbConnection _conn;
        //private HttpClient client;

        public ReviewsRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Reviews> GetAllReviews(string facilityID)
        {

            return _conn.Query<Reviews>("SELECT * FROM reviews WHERE facilityID = @facilityID",
                new
                {
                    facilityID = facilityID
                });

        }

        public void InsertReview(string user, string title, string description, string facilityID, Guid guid)
        {
            //Checking to see if record exists to prevent duplicates.

            var exists = _conn.ExecuteScalar<bool>("select count(1) from Reviews where facilityID = @facilityID and user = @user", new { facilityID, user });

            if (!exists)
            {

                _conn.Execute("INSERT INTO reviews (user, title, description, facilityID, GUID) VALUES (@User, @Title, @Description, @facilityID, @guid);",
                    new { User = user, Title = title, Description = description, FacilityID = facilityID, guid = guid });
            }
        }

        public void DeleteReview(Reviews review)
        {
            _conn.Execute("DELETE FROM reviews WHERE facilityID = @facilityID AND user = @user;",
                                       new { user = review.User, facilityId = review.FacilityID });

        }

    }
}
