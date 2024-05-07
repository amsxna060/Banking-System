using Transactions;
using Accounts;
using System.Data;

namespace Transactions;
class Transaction : ITransaction
{
    public void Transfer(Account from, Account to, decimal amount){
        //// one-way
        // from.getSetBalance -= amount;
        // to.getSetBalance +=amount;

        //// second-way
        if (from.Withdraw(amount) && to.Deposit(amount))
            System.Console.WriteLine("Transfer Succesful...");
        else
            System.Console.WriteLine("Tranfer Failed...");


    }
}