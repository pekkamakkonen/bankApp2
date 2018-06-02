using System;
using System.Collections.Generic;
using System.Text;
using bankApp2.Models;
using System.Linq;

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

        public static void Delete(int id)
        {
            var delBank = _context.Bank.FirstOrDefault(b => b.Id == id);
            if (delBank != null)
                _context.Bank.Remove(delBank);
            _context.SaveChanges();
        }
    }
}
