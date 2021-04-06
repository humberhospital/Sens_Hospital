﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sens_Hospital.Models
{
    public class Faq
    {
        [Key]
        public int FaqID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}