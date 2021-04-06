using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sens_Hospital.Models
{
    public class Donation
    {
        [Key]
        public int DonationID { get; set; }
        public decimal DonationAmount { get; set; }
        public DateTime DonationDate { get; set; }

        [ForeignKey("DonorInfo")]
        public int DonorID { get; set; }
        public virtual DonorInfo DonorInfo { get; set; }
    }
}