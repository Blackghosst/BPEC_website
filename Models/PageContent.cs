using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BPEC.Models
{
    public class PageContent
    {
        public int PageContentID { get; set; }
        [Required]
        public string PageCode { get; set; }
        [Required]
        public string PageDisplayName { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string PageContentHTML { get; set; }
        [Required]
        public string LastUpdatedBy { get; set; }
        [Required]
        public DateTime LasyUpdatedDate { get; set; }
    }
}