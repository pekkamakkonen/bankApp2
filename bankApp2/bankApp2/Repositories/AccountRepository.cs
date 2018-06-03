using System;
using System.Collections.Generic;
using System.Text;
using bankApp2.Models;
using System.Linq;

namespace bankApp2.Repositories
{
    class AccountRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        public Account GetAccountByIban(string iban)
        {
            var account = _context.Account.FirstOrDefault(a => a.Iban == iban);
            return account;
        }

        public void Delete(string iban)
        {
            var delAccount = _context.Account.FirstOrDefault(a => a.Iban == iban);
            if (delAccount != null)
            {
                _context.Account.Remove(delAccount);
            }
            _context.SaveChanges();
        }

        public void PrintTransactionsOfCustomer(int customerId)
        {
            var customer = _context.Customer.Where(c => c.Id == customerId);
            var accounts = _context.Account.Where(a => a.CustomerId == customerId);

            foreach (var c in customer)
            {
                Console.WriteLine($"Asiakkaan {c.FirstName} {c.LastName} tilitapahtumat:\n");
            }
            foreach (var a in accounts)
            {
                var transactions = _context.Transactions.Where(t => t.Iban == a.Iban);

                foreach (var t in transactions)
                {
                    Console.WriteLine($"{t.Iban} {t.Amount} {t.TimeStamp}");
                }
            }
            Console.WriteLine("---");
        }
    }
}
