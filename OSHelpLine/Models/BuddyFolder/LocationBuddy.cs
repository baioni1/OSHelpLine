using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSHelpLine.Models
{
    [MetadataType(typeof(LocationBuddy))]
    public partial class Location
    {
    }

    sealed class LocationBuddy
    {
        public int LocationId { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

    }
}
