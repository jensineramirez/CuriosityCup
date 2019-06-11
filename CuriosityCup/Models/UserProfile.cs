using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Display(Name = "Picture")]
        public string UserPicture { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Required]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public string DOB { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
