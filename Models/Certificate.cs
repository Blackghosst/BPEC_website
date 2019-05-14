using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BPEC.Models
{
    public class Certificate
    {
        public int CertificateID { get; set; }
        [Required]
        public string CertificateName { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string CertificateAbout { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string CertificateWhy { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string CertificateWhyBPEC { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string CertificateWho { get; set; }
        [Required]
        public string LastUpdatedBy { get; set; }
        [Required]
        public DateTime LasyUpdatedDate { get; set; }
    }
}