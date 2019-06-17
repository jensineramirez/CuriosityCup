using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Teacher")]
        public string TeacherId { get; set; }
        [Required]
        [Display(Name = "Subject")]
        public int SubjectId { get; set; }
        [Required]
        [Display(Name = "Lesson")]
        public int LessonId { get; set; }

        public virtual IdentityUser Teacher { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
