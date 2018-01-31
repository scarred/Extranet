using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{

    public class Employee
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "First name required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

    }

}