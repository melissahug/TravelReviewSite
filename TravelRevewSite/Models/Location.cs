using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelRevewSite.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}