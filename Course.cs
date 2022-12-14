using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfFineArtsModels
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Abbreviation { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int NumCredits { get; set; }
        [Required]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        [Required]
        public virtual List<CourseEnrollment> CourseEnrollment { get; set; } = new List<CourseEnrollment>();
    }
}

