namespace Accounts; // from C#8.0 namespace can be created like this without curly brackets.
class CheckingAccount : SavingsAccount
{
    private int noOfTransPerDay;

    public CheckingAccount() : base()
    {
        noOfTransPerDay = 10;
    }
    public CheckingAccount(string accountNumber, decimal balance
                         , decimal minBalance = 1000m, double rateOnFD = 7.5d, int noOfTransPerDay = 10) : base(accountNumber, balance, minBalance, rateOnFD)
    {
        this.noOfTransPerDay = noOfTransPerDay;
    }
    public int NoOfTransPerDay
    {
        get => noOfTransPerDay;
        set => noOfTransPerDay = value;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nNo Of Transaction Per day: {noOfTransPerDay}";
    }

}
