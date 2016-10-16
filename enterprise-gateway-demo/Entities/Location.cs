using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enterprise_gateway_demo.Entities
{
    public class Location
    {
        public Int64 StoreId { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StateCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}