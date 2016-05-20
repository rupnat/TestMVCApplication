using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestMVCApplication.Data;
using TestMVCApplication.Models;

namespace TestMVCApplication.Controllers
{
    public class CustomerController : ApiController
    {
        private NorthwindContext db;
        public CustomerController()
        {
            db = new NorthwindContext();
        }
        public List<CustomerViewModel> Get()
        {
            return db.Customers.Select(
                    r => new CustomerViewModel()
                    {
                        CustomerID = r.CustomerID,
                        CompanyName = r.CompanyName,
                        ContactName = r.ContactName
                    }).ToList();
        }        
    }
}
