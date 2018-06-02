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

            //Create Bank
            //Bank bank = new Bank("S-Pankki", "SBANFIHH");
            //BankRepository.Create(bank);

            //Delete Bank
            //BankRepository.Delete(3);

            //Create Customer
            //Customer customer = new Customer("Jukka", "Salin", 2);
            //CustomerRepository.Create(customer);

            //Delete Customer
            CustomerRepository.Delete(4);
        }
    }
}
