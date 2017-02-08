using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSHelpLine.Models
{
    [MetadataType(typeof(HelpTicketBuddy))]
    public partial class HelpTicket
    {
    }
    sealed class HelpTicketBuddy
    {
        public int HelpTicketId { get; set; }

        public int StudentId { get; set; }

        public Nullable<int> InstructorId { get; set; }

        public Nullable<int> LocationId { get; set; }

        public int StatusId { get; set; }

        [Display(Name = "Time In")]
        public System.DateTime TimeIn { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }

        [Display(Name = "Time Done")]
        public System.DateTime TimeDone { get; set; }


    }
}