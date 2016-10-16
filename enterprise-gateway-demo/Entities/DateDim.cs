using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enterprise_gateway_demo.Entities
{
    public class DateDim
    {
        public Int64 FinYearId { get; set; }
        public DateTime FinYear { get; set; }
        public DateTime FiscalYear { get; set; }
        public DateTime FiscalMonth { get; set; }
        public int MonthNumber { get; set; }
        public DateTime Year { get; set; }
        public int Quarter { get; set; }

    }
}