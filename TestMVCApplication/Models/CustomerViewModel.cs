using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVCApplication.Models
{
    public class CustomerViewModel
    {
        [DisplayName("Customer ID")]
        [Required]
        public string CustomerID { get; set; }

        [DisplayName("Company Name")]
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [DisplayName("Contact Name")]
        [StringLength(30)]
        public string ContactName { get; set; }

        [DisplayName("Contact Title")]
        [StringLength(30)]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }
    }
}