using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public class FavoritesRepository: IFavoritesRepository
    {
        private readonly IDbConnection _conn;



        public FavoritesRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Favorites> GetAllFavorites(string user)
        {

            return _conn.Query<Favorites>("SELECT * FROM Favorites WHERE user = @user",
                new
                {
                    user = user
                });

        }

        public void InsertFavorite(string facilityID, string facility, string user, string contractID)
        {
             _conn.Execute("INSERT INTO Favorites (campId, campsiteName, user, contractID) VALUES (@facilityID, @facility, @user, @contractID);",
                new { facilityID = facilityID, facility = facility, user = user, contractID = contractID });

        }

        public void DeleteFavorite(Favorites favorite)
        {
            _conn.Execute("DELETE FROM favorites WHERE campId = @campID AND user = @user;",
                                       new { user = favorite.user, campId = favorite.campID });

        }




    }
}
