using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class UserTest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }  
        [Required]
        public int TestId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTaken { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        [Display(Name = "Status")]
        public bool PassFail { get; set; }

        public virtual IdentityUser User { get; set; }
        public virtual Test Test { get; set; }
    }
}
