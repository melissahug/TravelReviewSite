using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelRevewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime TripDate { get; set; }
        public string Email { get; set; }
        public string UserReview { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }
        
    }
}