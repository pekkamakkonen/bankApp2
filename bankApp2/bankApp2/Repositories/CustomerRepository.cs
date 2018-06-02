using System;
using System.Collections.Generic;
using System.Text;
using bankApp2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace bankApp2.Repositories
{
    class CustomerRepository
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public static void Delete(int id)
        {
            var delCustomer = _context.Customer.FirstOrDefault(c => c.Id == id);
            if (delCustomer != null)
                _context.Customer.Remove(delCustomer);
            _context.SaveChanges();
        }

        public static void PrintCustomers(int bankId)
        {
            var customers = _context.Customer.Where(c => c.BankId == bankId);

            foreach(var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }
    }
}
