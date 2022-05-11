using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    interface ICampgroundRepository
    {
        public List<Campgrounds> GetCampgrounds(string selectState, string selectActivity);
    }
}
