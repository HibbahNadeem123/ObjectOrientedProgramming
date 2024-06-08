using System;

namespace BankProject
{
    public class Program
    {
        public static void Main()
        {
            Account account= new Account("Jakes Account", 200000);
            account.Print();
            account.Deposit(100);
            account.Print();
            account.Withdraw(25);
            account.Print();

            //creating 2nd object of Account class using constructor
            Account account1= new Account("Hibbahs Account", 50000);
            //calling fucntions of account class for the 2nd object created
            account1.Print();
            account1.Deposit(250);
            account1.Print();
            account1.Withdraw(500);
            account1.Print();
            account1.Deposit(250);
            account1.Print();
        }
    }
}
