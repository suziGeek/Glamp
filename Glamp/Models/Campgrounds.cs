using Microsoft.AspNetCore.Mvc;

using System;

using System.Collections.Generic;


namespace Glamp.Models
{
    [Serializable]
    public class Campgrounds
    {
        public string FacilityName
        {
            get { return facilityName; }
            set { facilityName = value; }
        }
        public string FacilityID
        {
            get { return facilityID; }
            set { facilityID = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public decimal Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public decimal Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public string ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }


        public string contractID;
        public string facilityName;
        public string facilityID;
        public string state;
        public decimal latitude;
        public decimal longitude;

        public Campgrounds(string facilityName, string facilityID, string state, decimal latitude, decimal longitude, string contractID)
        {
            this.facilityName = facilityName;
            this.facilityID = facilityID;
            this.state = state;
            this.latitude = latitude;
            this.longitude = longitude;
            this.contractID = contractID;
        }


        public Campgrounds() { }

        public void Add(object obj)
        {
            //requirement of XmlSerializer when serializing IEnumerables
        }




        public string agencyIcon { get; set; }

        public string agencyName { get; set; }

        //public string contractID { get; set; }

        public string contractType { get; set; }

        //public uint facilityID { get; set; }

        //public string facilityName { get; set; }

        public string faciltyPhoto { get; set; }

        public string favorite { get; set; }

        //public decimal latitude { get; set; }

        public string listingOnly { get; set; }

        //public decimal longitude { get; set; }

        public string regionName { get; set; }

        public string shortName { get; set; }

        public string sitesWithAmps { get; set; }

        public string sitesWithPetsAllowed { get; set; }

        public string sitesWithSewerHookup { get; set; }

        public string sitesWithWaterHookup { get; set; }

        public string sitesWithWaterfront { get; set; }

        //public string state { get; set; }
        public string user { get; set; }
        public string fullReservationUrl { get; set; }

        
        public Dictionary<string, string> activityDictionary = new Dictionary<string, string>
                {

                  {  "RV Sites","2001" },
                  {  "Cabins","10001" },
                  {  "Tent","2003" },
                  { "Trailer","2002"},
                  { "Group Site","9002"},
                  { "Day Use","9001"},
                  { "Horse Site","3001"},
                  {"Boat Site","2004"}
                };

       
        public Dictionary<string, string> selectActivity { get; set; }


        [BindProperty]
        public States selectState { get; set; }

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

