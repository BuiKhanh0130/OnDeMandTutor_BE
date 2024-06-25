using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class FeedbackDTO
    {
        public string StudentId { get; set; }

        public string Description { get; set; }

        public int Start { get; set; }
        public string? Title { get; set; }
        public string? TutorID { get; set; }

        public string? ClassID { get; set; }
    }
}
