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

        public void InsertFavorite(string facilityID, string facility, string user)
        {
             _conn.Execute("INSERT INTO Favorites (campId, campsiteName, user) VALUES (@facilityID, @facility, @user);",
                new { facilityID = facilityID, facility = facility, user = user });

        }




    }
}
