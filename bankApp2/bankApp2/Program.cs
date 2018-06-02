using System;
using bankApp2.Models;
using bankApp2.Repositories;

namespace bankApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BankApp");
            BankRepository bankRepository = new BankRepository();
            CustomerRepository customerRepository = new CustomerRepository();
            AccountRepository accountRepository = new AccountRepository();

            //Create Bank
            //Bank bank = new Bank("S-Pankki", "SBANFIHH");
            //bankRepository.Create(bank);

            //Delete Bank
            //bankRepository.Delete(3);

            //Create Customer
            //Customer customer = new Customer("Jukka", "Salin", 2);
            //customerRepository.Create(customer);

            //Delete Customer
            //customerRepository.Delete(4);

            //Delete Account
            //accountRepository.Delete("34567890123456789012");

            //Print Bank's Accounts
            bankRepository.PrintAccountsOfBank(1);

            //Print Bank's Customers
            bankRepository.PrintCustomers(1);

            //Print Customer's Accounts and Balances
            customerRepository.PrintAccountsOfCustomer(2);

            Console.ReadKey();

        }
    }
}
