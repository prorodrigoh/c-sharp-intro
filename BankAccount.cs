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
        AccountNumber = "4874 6424 9588 4647";
        Owner = owner;
        Balance = initialBalance;
    }

    public void MakeDeposit(decimal amount){
        if(amount <=0){
            throw new ArgumentException("Can't deposit nothing!");
        }
        Balance += amount;
    }


}