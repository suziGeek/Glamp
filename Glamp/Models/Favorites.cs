using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public class Favorites
    {

        public Favorites()
        {
        }

        public string user { get; set; }
        public string facilityName { get; set; }
        public string facilityID { get; set; }
        public string CampsiteName { get; set; }
        public string campID { get; set; }
        public string ContractID { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }


    }
}
