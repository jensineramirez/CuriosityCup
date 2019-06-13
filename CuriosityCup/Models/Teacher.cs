using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string TeacherName { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
