using System;

public class Account
{
    private decimal _balance;
    private string _name;

    public Account(string name, decimal balance)
    {
        _name=name;
        _balance=balance;
    }

    public void Deposit(decimal amoutToAdd)
    {
        _balance=_balance+amoutToAdd;
    }

    public void Withdraw(decimal amountToWithDraw)
    {
        _balance=_balance-amountToWithDraw;
    }

    public string name
    {
        get{return _name;}
    }

    public void Print()
    {
        Console.WriteLine("Name: "+_name);
        Console.WriteLine("Balance: "+_balance);
    }
}
