using System;
using System.Collections.Generic;
using System.Text;
using bankApp2.Models;

namespace bankApp2.Repositories
{
    class BankRepository
    {
        private static BankdbContext _context = new BankdbContext();

        public static void Create(Bank bank)
        {
            _context.Bank.Add(bank);
            _context.SaveChanges();
        }
    }
}
