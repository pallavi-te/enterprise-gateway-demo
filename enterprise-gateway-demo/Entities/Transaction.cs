using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enterprise_gateway_demo.Entities
{
    public class Transaction
    {
        public Int64 TransactionId { get; set; }

        public virtual Product Product { get; set; }
        public Int64 ProductId { get; set; }

        public virtual Location Store { get; set; }
        public Int64 StoreId { get; set; }

        public virtual Staff Staff { get; set; }
        public Int64 StaffId { get; set; }

        public virtual CustomerSegment Segment { get; set; }
        public Int64 CustomerSegmentId { get; set; }

        public string COGS { get; set; }
        public double SaleQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double SaleAmount { get; set; }
        public double TaxRate { get; set; }
        public double TaxAmount { get; set; }
        public double GrossAmount { get; set; }
        public double TenderedAmount { get; set; }
        public double ProfitMargin { get; set; }
        public int PaymentCount { get; set; }
        public int ReturnQuantity { get; set; }
        public double ReturnAmonut { get; set; }
        public DateTime TransactionDate { get; set; }
        public double CogsPerUnit { get; set; }

    }
}