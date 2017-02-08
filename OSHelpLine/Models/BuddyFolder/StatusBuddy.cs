using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSHelpLine.Models
{
    [MetadataType(typeof(StatusBuddy))]
    public partial class Status
    {
    }

    sealed class StatusBuddy
    {
        public int StatusId { get; set; }

        [Display(Name = "Status")]
        public string StatusName { get; set; }
    }
}