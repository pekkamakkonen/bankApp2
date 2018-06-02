using System;
using System.Collections.Generic;
using System.Text;
using bankApp2.Models;
using System.Linq;

namespace bankApp2.Repositories
{
    class BankRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        public void Create(Bank bank)
        {
            _context.Bank.Add(bank);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var delBank = _context.Bank.FirstOrDefault(b => b.Id == id);
            if (delBank != null)
                _context.Bank.Remove(delBank);
            _context.SaveChanges();
        }

        public void PrintAccountsOfBank(int bankId)
        {
            var accounts = _context.Account.Where(a => a.BankId == bankId);

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Iban} {account.Name} {account.Balance}");
            }
        }

        public void PrintCustomers(int bankId)
        {
            var customers = _context.Customer.Where(c => c.BankId == bankId);

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }
    }
}
