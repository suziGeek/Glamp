using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public class Reviews
    {
        public Reviews() { }

        public Reviews(string User, string FacilityID)
        {
            this.User = User;
            this.FacilityID = FacilityID;

        }

        public Reviews(string FacilityID)
        {
          
            this.FacilityID = FacilityID;

        }

        public Reviews(string User, string Description, string Title)
        {
           
            this.Description = Description;

            this.Title = Title;
            this.User = User;
        }

        [MinLength(3)]
        [MaxLength(100)]
        public string Title { get; set; }

        [MinLength(5)]
        [MaxLength(1024)]
        public string Description { get; set;}
        
        public int? Stars { get; set; }

        public string FacilityID { get; set; }

        public string User { get; set; }

        public string guid { get; set; }
    }
}
