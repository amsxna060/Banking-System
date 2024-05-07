using Microsoft.VisualBasic;

namespace Accounts
{
    class SavingsAccount:Account{
        private decimal minBalance;
        private double interestOnFD;

        public SavingsAccount():base(){
            minBalance = 1000.00m;
            interestOnFD = 7.50d;
        }
        public SavingsAccount(string accountNumber,decimal balance
                             ,decimal minBalance=1000m,double rateOnFD=7.5d):base(accountNumber,balance){
            
            // just to show we can use both way.
            this.minBalance = minBalance;
            interestOnFD = rateOnFD;
        }
        public decimal MinBalance{
            get => minBalance;
            set => minBalance = value;

        }
        public double InterestOnFD{
            get => interestOnFD;
            set => interestOnFD = value;
        }
        // Note : before overriding it was using Base class ToString, After Override obj will use this.
        public override string ToString(){
            return $"Acc/No.: {getsetAccountNumber}\nBal: ${getSetBalance}\nMin Balance: ${minBalance}\nRate On FD: {interestOnFD}% p.a.";
        }
    }
}