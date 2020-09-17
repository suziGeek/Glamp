using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public interface IFavoritesRepository
    {
        public void InsertFavorite(string facilityID, string facilityName, string user, string contractID);
        public IEnumerable<Favorites> GetAllFavorites(string user);
        public void DeleteFavorite(Favorites favorite);
    }
}
