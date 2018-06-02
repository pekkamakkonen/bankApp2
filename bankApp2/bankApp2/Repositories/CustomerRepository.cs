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

        public void Delete(int id)
        {
            var delCustomer = _context.Customer.FirstOrDefault(c => c.Id == id);
            if (delCustomer != null)
                _context.Customer.Remove(delCustomer);
            _context.SaveChanges();
        }

        public void PrintAccountsOfCustomer(int customerId)
        {
            var accounts = _context.Account.Where(a => a.CustomerId == customerId);

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Iban} {account.Name} {account.Balance}");
            }
        }
    }
}
