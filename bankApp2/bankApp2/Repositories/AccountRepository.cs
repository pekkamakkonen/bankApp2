﻿using System;
using System.Collections.Generic;
using System.Text;
using bankApp2.Models;
using System.Linq;

namespace bankApp2.Repositories
{
    class AccountRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        public void Delete(string iban)
        {
            var delAccount = _context.Account.FirstOrDefault(a => a.Iban == iban);
            if (delAccount != null)
                _context.Account.Remove(delAccount);
            _context.SaveChanges();
        }
    }
}
