using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enterprise_gateway_demo.Entities
{
    public class Inventory
    {
        public Int64 InventoryId { get; set; }
        public int MyProperty { get; set; }

        public virtual Location Store { get; set; }
        public Int64 StoreId { get; set; }

        public virtual DateDim FinYear { get; set; }
        public Int64 FinYearId { get; set; }

        public virtual Product Product { get; set; }
        public Int64 ProductId { get; set; }

        public virtual Staff Staff { get; set; }
        public Int64 StaffId { get; set; }

        public double OpeningQuantity { get; set; }
        public double SaleQuantity { get; set; }

        public double ReturnQuantity { get; set; }

        public double ClosingQuantity { get; set; }





    }
}