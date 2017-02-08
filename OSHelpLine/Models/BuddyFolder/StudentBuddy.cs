using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSHelpLine.Models
{
    [MetadataType(typeof(StudentBuddy))]
    public partial class Student
    {
    }

    sealed class StudentBuddy
    {
        public int StudentId { get; set; }

        public int CohortId { get; set; }

        [Display(Name = "Student's Name")]
        public string FullName { get; set; }


        public string Email { get; set; }
        public string Password { get; set; }

        [Display(Name = "Slack User Name")]
        public string SlackUserName { get; set; }

    }
}