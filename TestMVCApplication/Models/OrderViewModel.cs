using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TestMVCApplication.Models
{
    public class OrderViewModel
    {
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        [DisplayName("Customer ID")]
        public string CustomerID { get; set; }

        [DisplayName("Employee ID")]
        public Nullable<int> EmployeeID { get; set; }

        [DisplayName("Order Date")]
        public Nullable<System.DateTime> OrderDate { get; set; }

        [DisplayName("Required Date")]
        public Nullable<System.DateTime> RequiredDate { get; set; }

        [DisplayName("Shipped Date")]
        public Nullable<System.DateTime> ShippedDate { get; set; }

        [DisplayName("Ship Via")]
        public Nullable<int> ShipVia { get; set; }

        public Nullable<decimal> Freight { get; set; }

        [DisplayName("Ship Name")]
        public string ShipName { get; set; }

        [DisplayName("Ship Address")]
        public string ShipAddress { get; set; }

        [DisplayName("Ship City")]
        public string ShipCity { get; set; }

        [DisplayName("Ship Region")]
        public string ShipRegion { get; set; }

        [DisplayName("Ship Postal Code")]
        public string ShipPostalCode { get; set; }

        [DisplayName("Ship Country")]
        public string ShipCountry { get; set; }        
    }
}