using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public class DropDownMenu
    {
        public Dictionary<string, string> activityDictionary = new Dictionary<string, string>
                {

                  {  "RVSites","2001" },
                  {  "Cabins","10001" },
                  {  "Tent","2003" },
                  { "Trailer","2002"},
                  { "GroupSite","9002"},
                  { "DayUse","9001"},
                  { "HorseSite","3001"},
                  {"BoatSite","2004"}
                };

        [BindProperty]
        public string selectActivity { get; set; }


        [BindProperty]
        public string selectState { get; set; }

        public enum States
        {
            AL,
            AZ,
            AR,
            CA,
            CO,
            CT,
            DC,
            DE,
            FL,
            GA,
            HI,
            ID,
            IL,
            IN,
            IA,
            KS,
            KY,
            LA,
            ME,
            MD,
            MA,
            MI,
            MN,
            MS,
            MO,
            MT,
            NE,
            NV,
            NH,
            NJ,
            NM,
            NY,
            NC,
            ND,
            OH,
            OK,
            OR,
            PA,
            RI,
            SC,
            SD,
            TN,
            TX,
            UT,
            VT,
            VA,
            WA,
            WV,
            WI,
            WY
        };

    }
}
