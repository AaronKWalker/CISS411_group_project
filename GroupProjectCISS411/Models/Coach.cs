using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProjectCISS411.Models
{
    public class Coach
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public string CoachPhone { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
