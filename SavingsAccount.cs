namespace Accounts;

public class SavingAccount: BankAccount{

    // call ctor to autocomplete
    public SavingAccount(): base()
    {
        
    }
    public SavingAccount(string owner, decimal initialBalance): base(owner, initialBalance){
        
    }
    public decimal InterestRate {get; set;}
    public void MonthlyInterest(){
        Balance += Balance * InterestRate;
    }
}