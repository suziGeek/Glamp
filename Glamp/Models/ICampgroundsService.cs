using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    interface ICampgroundsService
    {
      
            Task<List<Campgrounds>> GetPaginatedResult(int currentPage, int pageSize = 10);
            Task<int> GetCount();
        
    }
}
