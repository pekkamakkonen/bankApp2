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

        public Bank GetBankById(int id)
        {
            var bank = _context.Bank.FirstOrDefault(b => b.Id == id);
            return bank;
        }

        public void Update(int id, Bank bank)
        {
            var updateBank = GetBankById(id);
            if (updateBank != null)
            {
                _context.Bank.Update(bank);
            }
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
            var bank = _context.Bank.Where(b => b.Id == bankId);
            var accounts = _context.Account.Where(a => a.BankId == bankId);

            foreach (var b in bank)
            {
                Console.WriteLine($"Pankin {b.Name} tilit:\n");
            }

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Iban} {account.Name} {account.Balance}");
            }
            Console.WriteLine("---");
        }

        public void PrintCustomers(int bankId)
        {
            var bank = _context.Bank.Where(b => b.Id == bankId);
            var customers = _context.Customer.Where(c => c.BankId == bankId);

            foreach (var b in bank)
            {
                Console.WriteLine($"Pankin {b.Name} asiakkaat:\n");
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
            Console.WriteLine("---");
        }
    }
}
