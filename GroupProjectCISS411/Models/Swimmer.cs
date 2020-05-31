using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProjectCISS411.Models
{
    public class Swimmer
    {
        public int SwimmerId { get; set; }
        public string SwimmerName { get; set; }
        public string UserId { get; set; }
        public string SwimmerGender { get; set; }
        public string SwimmerPhone { get; set; }
        public string BirthDate { get; set; }
        public virtual ApplicationUser User { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
