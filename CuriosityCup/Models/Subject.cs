using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class Subject
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }
    }
}
