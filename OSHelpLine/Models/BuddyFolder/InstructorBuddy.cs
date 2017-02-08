using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSHelpLine.Models
{
    [MetadataType(typeof(InstructorBuddy))]
    public partial class Instructor
    {
    }

    sealed class InstructorBuddy
    {
 
        public int InstructorId { get; set; }
                
        [Display(Name = "Instructor's Name")]
        public string FullName { get; set; }
 
        [Display(Name = "Slack User Name")]
        public string SlackUserName { get; set; }

    }
}
