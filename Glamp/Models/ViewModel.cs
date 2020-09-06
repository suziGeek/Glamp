using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamp.Models
{
    public class ViewModel
    {

        public List<Campgrounds> CampGrounds { get; set; }
        public DropDownMenu DropDownMenu { get; set; }
       

    }
}
