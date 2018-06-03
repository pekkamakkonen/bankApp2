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
        private readonly BankdbContext _context = new BankdbContext();

        public void Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customer.FirstOrDefault(c => c.Id == id);
            return customer;
        }

        public void Update (int id, Customer customer)
        {
            var updateCustomer = GetCustomerById(id);
            if (updateCustomer != null)
            {
                _context.Customer.Update(customer);
            }
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var delCustomer = _context.Customer.FirstOrDefault(c => c.Id == id);
            if (delCustomer != null)
                _context.Customer.Remove(delCustomer);
            _context.SaveChanges();
        }

        public void PrintAccountsOfCustomer(int customerId)
        {
            var customer = _context.Customer.Where(c => c.Id == customerId);
            var accounts = _context.Account.Where(a => a.CustomerId == customerId);

            foreach (var c in customer) {
                Console.WriteLine($"Asiakkaan {c.FirstName} {c.LastName} tilit:\n");
            }

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Iban} {account.Name} {account.Balance}");
            }
            Console.WriteLine("---");
        }
    }
}
