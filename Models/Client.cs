using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BPEC.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        [Required]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        [Display(Name = "About Client")]
        public string ClientAbout { get; set; }
        [ScaffoldColumn(false)]
        public bool HasLogo { get; set; }
        [Required]
        public string LastUpdatedBy { get; set; }
        [Required]
        public DateTime LasyUpdatedDate { get; set; }
    }
}