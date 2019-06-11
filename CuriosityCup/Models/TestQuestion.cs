using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class TestQuestion
    {
        public int Id { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public string Question { get; set; }

        public virtual Test Test { get; set; }
    }
}
