using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVCApplication.Entities;
using TestMVCApplication.Models;

namespace TestMVCApplication.Data
{
    public interface ICustomerRepository
    {
        List<CustomerViewModel> GetCustomers();
        List<OrderViewModel> GetCustomerOrders(string customerId);
        void CreateCustomer(CustomerViewModel customerViewModel);
        Customer GetCustomerByCustomerID(string customerId);
    }
}
