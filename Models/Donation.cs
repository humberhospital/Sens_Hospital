using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sens_Hospital.Models
{
    public class Donation
    {
        [Key]
        public int DonationID { get; set; }
        public decimal DonationAmount { get; set; }
        public DateTime DonationDate { get; set; }

        [ForeignKey("UserInfo")]
        public int UserID { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }

    public class DonationDto
    {
        public int DonationID { get; set; }


        [DisplayName("Donation amount")]
        public decimal DonationAmount { get; set; }

        [DisplayName("Donation Date")]
        public DateTime DepartmentClass { get; set; }


    }

}