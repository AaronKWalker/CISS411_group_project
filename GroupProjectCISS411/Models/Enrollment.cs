using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupProjectCISS411.Models
{
    public enum Report
          {
            A, B, C, D, F, I, W, P
          }
          
    public class Enrollment
    {
        // Connector between session&swimmer (pg 301)
       public int EnrollmentId { get; set; }
       public int SwimmerId { get; set; }
       public int SessionId { get; set; }
        public Swimmer Swimmer { get; set; }
        public Session Session { get; set; }
        [DisplayFormat(NullDisplayText = "No Report")]
        public Report? Report { get; set; }
    }
}
