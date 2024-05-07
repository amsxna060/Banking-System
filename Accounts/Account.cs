using Exceptions;
using Extensions;
namespace Accounts
{
    class Account
    {
        private string accountNumber;
        private decimal balance;

        public Account()
        {
            accountNumber = "";
            balance = 0.0m;
        }
        public Account(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public string getsetAccountNumber
        {
            get
            {   
                // char[] hiddenAccNo = accountNumber.ToCharArray();
                // for(int i = 2;i<accountNumber.Length-4;i++){
                //     hiddenAccNo[i] = 'x';
                // }
                // return new String(hiddenAccNo);
                return accountNumber.MaskStrings();
            }
            set
            {
                try
                {
                    if (value.Length != 11)
                    {
                        throw new InvalidAccountNumber("Account Should have length greater than 10");
                    }
                    else
                    {
                        accountNumber = value;
                    }

                }
                catch (InvalidDataException e)
                {
                    System.Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
        }
        public decimal getSetBalance
        {
            get { return balance; }
            set { balance = value; }

        }

        public bool Deposit(decimal amount)
        {
            balance+=amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance>=amount){
                balance-=amount;
                return true;
            }
            else{
                System.Console.WriteLine($"\nInsufficient Balance in Acc No. {this.getsetAccountNumber}");
                return false;
            }
        }
        // first I was doing this with void Display();
        public override string ToString(){
            return $"Acc/No.: {getsetAccountNumber}\nBal: ${getSetBalance}";
        }
    }
}