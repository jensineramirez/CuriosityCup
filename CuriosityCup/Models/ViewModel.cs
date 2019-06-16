using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuriosityCup.Models
{
    public class ViewModel
    {
        public IEnumerable<Lesson> Lessons { get; set; }
        public IEnumerable<Test> Tests { get; set; }
    }
}
