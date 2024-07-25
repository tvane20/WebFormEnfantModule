using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormEnfant.Models
{
    public class EnfantModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TutorName { get; set; }
        public string CIN { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }
}