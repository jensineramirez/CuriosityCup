using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class TestAnswer
    {
        public int Id { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public string QuestionId { get; set; }
        [Required]
        public string Answer { get; set; }
        [Required]
        public bool IsCorrect { get; set; }

        public virtual Test Test { get; set; }
        public virtual TestQuestion TestQuestion { get; set; }
    }
}
