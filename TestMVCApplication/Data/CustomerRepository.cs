using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMVCApplication.Entities;
using TestMVCApplication.Models;

namespace TestMVCApplication.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private NorthwindContext _context;
        public CustomerRepository(NorthwindContext context)
        {
            _context = context;
        }       

        public List<OrderViewModel> GetCustomerOrders(string customerId)
        {
            return _context.Orders.Where(e => e.CustomerID == customerId)
                .Select(o => new OrderViewModel
                {
                    OrderID = o.OrderID,
                    CustomerID = o.CustomerID,
                    EmployeeID = o.EmployeeID,
                    OrderDate = o.OrderDate,
                    RequiredDate = o.RequiredDate,
                    ShippedDate = o.ShippedDate,
                    ShipVia = o.ShipVia,
                    Freight = o.Freight,
                    ShipName = o.ShipName,
                    ShipAddress = o.ShipAddress,
                    ShipCity = o.ShipCity,
                    ShipRegion = o.ShipRegion,
                    ShipPostalCode = o.ShipPostalCode,
                    ShipCountry = o.ShipCountry
                }).ToList();
        }

        public List<CustomerViewModel> GetCustomers()
        {
            return _context.Customers.Select( c=> new CustomerViewModel {
                CustomerID = c.CustomerID,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                City = c.City,
                Region = c.Region,
                PostalCode = c.PostalCode,
                Phone = c.Phone,
                Fax = c.Fax
                }).ToList() ;
        }

        public void CreateCustomer(CustomerViewModel customerViewModel)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerViewModel.CustomerID;
            customer.CompanyName = customerViewModel.CompanyName;
            customer.ContactName = customerViewModel.ContactName;
            customer.ContactTitle = customerViewModel.ContactTitle;
            customer.City = customerViewModel.City;
            customer.Region = customerViewModel.Region;
            customer.PostalCode = customerViewModel.PostalCode;
            customer.Phone = customerViewModel.Phone;
            customer.Fax = customerViewModel.Fax;

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer GetCustomerByCustomerID(string customerId)
        {
            return _context.Customers.SingleOrDefault(x=>x.CustomerID == customerId);
        }
    }
}