using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AHCWebDeveloperExam.Models
{
    public class OrderSummaryModel
    {
        public int Id { get; set; }
        public string PeriodDate { get; set; }
        public string PeriodLabel { get; set; }
        public int Ordered { get; set; }
        public int Shipped { get; set; }
        public int Remainder { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double TotalOrderedAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public double TotalShippedAmount { get; set; }
    }
}