using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "Email")]
        public string TeacherID { get; set; }
        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "Subject")]
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "Required Field. Please enter a title.")]
        [Display(Name = "Lesson Title")]
        public string Title { get; set; }
        [Url]
        [Required(ErrorMessage = "Required Field. Please provide a link.")]
        public string Video { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string SectionDescription { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual IdentityUser Teacher { get; set; }

    }
}
