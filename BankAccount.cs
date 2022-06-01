namespace Accounts;
public class BankAccount
{
    // if we type prop, emmet will complete the typing
    public string AccountNumber { get; set; }
    public string Owner { get; set; }
    public decimal Balance { get; set; }

    // constructor

    public BankAccount(){
        AccountNumber = "My Account";
        Owner = "RHNM";
        Balance = decimal.MaxValue;
    }

    public BankAccount( string owner, decimal initialBalance){
        Owner = owner;
        Balance = initialBalance;
    }
}