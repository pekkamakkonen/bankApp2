using System;
using bankApp2.Models;
using bankApp2.Repositories;

namespace bankApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BankApp\n");

            BankRepository bankRepository = new BankRepository();
            CustomerRepository customerRepository = new CustomerRepository();
            AccountRepository accountRepository = new AccountRepository();

            //Create Bank
            Bank bank = new Bank("S-Pankki", "SBANFIHH");
            bankRepository.Create(bank);

            //Update Bank
            Bank updateBank = bankRepository.GetBankById(3);
            updateBank.Name = "Handelsbanken";
            updateBank.Bic = "HANDFIHH";
            bankRepository.Update(3, updateBank);

            //Delete Bank
            bankRepository.Delete(3);

            //Create Customer
            Customer customer = new Customer("Jukka", "Salin", 1);
            customerRepository.Create(customer);

            //Update Customer
            Customer updateCustomer = customerRepository.GetCustomerById(4);
            updateCustomer.FirstName = "Lasse";
            updateCustomer.LastName = "Sievinen";
            updateCustomer.BankId = 2;
            customerRepository.Update(4, updateCustomer);

            //Delete Customer
            customerRepository.Delete(4);

            //Delete Account
            accountRepository.Delete("FI44 1234");

            //Print Bank's Accounts
            bankRepository.PrintAccountsOfBank(1);

            //Print Bank's Customers
            bankRepository.PrintCustomers(1);

            //Print Customer's Accounts and Balances
            customerRepository.PrintAccountsOfCustomer(1);

            //Print Customer's Transactions
            accountRepository.PrintTransactionsOfCustomer(1);

            Console.ReadKey();

        }
    }
}
