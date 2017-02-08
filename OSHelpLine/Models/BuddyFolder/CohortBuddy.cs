using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSHelpLine.Models
{
    [MetadataType(typeof(CohortBuddy))]
    public partial class Cohort
    {
    }

    sealed class CohortBuddy
    {
        public int StatusId { get; set; }

        [Display(Name = "Cohort")]
        public string CohortName { get; set; }
    }
}