using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sens_Hospital.Models
{
    public class FaqCategory
    {
        [Key]
        public int FaqCategoryID { get; set; }

        [ForeignKey("Faq")]
        public int FaqID { get; set; }
        public virtual Faq Faq { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}