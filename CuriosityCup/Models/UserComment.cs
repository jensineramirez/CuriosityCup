using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class UserComment
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Title of Lesson")]
        public int LessonId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CommentAdded { get; set; }
        [Required]
        public string Comment { get; set; }

        public virtual IdentityUser User { get; set; }
        public virtual Lesson Lesson { get; set; } 
    }
}
