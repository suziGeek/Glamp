using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public interface ICampsiteDetailRepository
    {
        public CampsiteDetail GetCamperDetail(string campId, string contractID);
    }
}
